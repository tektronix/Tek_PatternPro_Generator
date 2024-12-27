using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Ivi.Visa;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Tektronix.PatternPro
{
    internal struct PpgModelParams
    {
        public string model;
        public int numChannels;
        public float maxDataRate;

        public PpgModelParams(string model, int numChannels, float maxDataRate)
        {
            this.model = model;
            this.numChannels = numChannels;
            this.maxDataRate = maxDataRate;
        }
    }

    public struct PatternProID
    {
        public string Manufacturer;
        public string Model;
        public string Serial;
        public string Revision;

        public override string ToString()
        {
            return $"{Manufacturer}, {Model}, {Serial}, {Revision}";
        }
    }

    public enum TriggerSource
    {
        Periodic = 0,
        Bitstream
    }

    public class PatternProGenerator : IDisposable
    {
        private static Dictionary<string, PpgModelParams> _modelLookup = null;
        
        private bool disposedValue;
        internal IMessageBasedSession _vi = null;
        private PpgModelParams _ppgParams;

        public IMessageBasedSession VisaSession { get { return _vi; } }
        public List<PatternProChannel> Channels { get; private set; }
        public PatternProID ID { get; private set; }
        public float MaxBitRate { get => _ppgParams.maxDataRate; }


        internal PatternProGenerator()
        {
            if (_modelLookup == null)
            {
                _modelLookup = new Dictionary<string, PpgModelParams>(11);
                _modelLookup.Add("12050", new PpgModelParams("PPG1251", 1, 12e9f));
                _modelLookup.Add("12601", new PpgModelParams("PPG1601", 1, 16e9f));
                _modelLookup.Add("12602", new PpgModelParams("PPG1602", 2, 16e9f));
                _modelLookup.Add("12603", new PpgModelParams("PPG1604", 4, 16e9f));
                _modelLookup.Add("12593", new PpgModelParams("PPG3001", 1, 30e9f));
                _modelLookup.Add("12594", new PpgModelParams("PPG3002", 2, 30e9f));
                _modelLookup.Add("12595", new PpgModelParams("PPG3004", 4, 30e9f));
                _modelLookup.Add("12590", new PpgModelParams("PPG3201", 1, 32e9f));
                _modelLookup.Add("12591", new PpgModelParams("PPG3202", 2, 32e9f));
                _modelLookup.Add("12592", new PpgModelParams("PPG3204", 4, 32e9f));
                _modelLookup.Add("12604", new PpgModelParams("PPG4001", 1, 32e9f));
            }

            this.Channels = new List<PatternProChannel>(4);
        }
        
        public PatternProGenerator(string visaResourceAddress) : this()
        {
            _vi = GlobalResourceManager.Open(visaResourceAddress) as IMessageBasedSession;

            _vi.FormattedIO.WriteLine("*IDN?");
            string idString = _vi.FormattedIO.ReadLine();

            string[] idParts = idString.Split(new char[] { ',' });

            if (_modelLookup.ContainsKey(idParts[1].Trim()))
            {
                _ppgParams = _modelLookup[idParts[1].Trim()];

                PatternProID id = new PatternProID();
                id.Manufacturer = idParts[0].Trim();
                id.Model = _ppgParams.model;
                id.Serial = idParts[2].Trim();
                id.Revision = idParts[3].Trim();
                this.ID = id;

                Channels.Clear();
                for (int i = 0; i < _ppgParams.numChannels; i++)
                {
                    Channels.Add(new PatternProChannel(this, (i + 1).ToString()));
                }
            }
            else
            {
                if (_vi != null) { _vi.Dispose(); _vi = null; }
                throw new Exception($"Instrument at address {visaResourceAddress} is invalid.\r\n\r\n" +
                    $"The model {idParts[1]} is not supported.");
            }
        }


        #region :OUTput

        /// <summary>
        /// Programs the trigger out event.
        /// PERiodic means the trigger will output a signal whose frequency is the clock rate divided
        /// by N, where N is the trigger divider setting.
        /// BITStream means trigger pulses will be aligned with the pattern length.
        /// </summary>
        public TriggerSource TriggerSource
        {
            get
            {
                _vi.FormattedIO.WriteLine($":OUTP0:SOUR?");
                string response = _vi.FormattedIO.ReadLine();
                if (response.Contains("PER")) { return TriggerSource.Periodic; }
                else if (response.Contains("BITS")) { return TriggerSource.Bitstream; }
                else { throw new Exception($"Instrument returned unknown trigger source: {response}"); }
            }
            set
            {
                if (value == TriggerSource.Periodic) { _vi.FormattedIO.WriteLine(":OUTP0:SOUR PER"); }
                else if (value == TriggerSource.Bitstream) { _vi.FormattedIO.WriteLine(":OUTP0:SOUR BIT"); }
            }
        }

        /// <summary>
        /// Programs the trigger divider. This is meaningful only if the trigger output event is
        /// set to periodic.
        /// Default: 64
        /// </summary>
        public int TriggerDivider
        {
            get
            {
                _vi.FormattedIO.WriteLine($":OUTP0:DIV?");
                string response = _vi.FormattedIO.ReadLine();
                return Int32.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":OUTP0:DIV {value}");
            }
        }

        /// <summary>
        /// Programs the clock output divider. The input to this divider is internal clock, and the output
        /// from the divider goes to the clock output or to the divided clock output if the full rate and
        /// divided outputs are separate.The maximum and minimum valid values depend on the instrument
        /// model and options.
        /// Valid Values: 1 | 2 | 4 | 8 | 16
        /// Note: Varies with model and options. The minimum allowed value is either 1 or 2.
        /// </summary>
        public int ClockDivider
        {
            get
            {
                _vi.FormattedIO.WriteLine($":OUTPut:CLOCk:DIVider?");
                string response = _vi.FormattedIO.ReadLine();
                return Int32.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":OUTPut:CLOCk:DIVider {value}");
            }
        }

        #endregion

        #region :SOURce
        /// <summary>
        /// Programs the skew.
        /// </summary>
        public float Frequency
        {
            get
            {
                _vi.FormattedIO.WriteLine($":SOUR:FREQ?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":SOUR:FREQ {value}");
            }
        }
        #endregion


        /// <summary>
        /// Query the system error queue.
        /// </summary>
        /// <param name="errorCode">The code for the error.</param>
        /// <returns>The error message.</returns>
        public string QueryError(out int errorCode)
        {
            _vi.FormattedIO.WriteLine(":SYST:ERR?");
            string response = _vi.FormattedIO.ReadLine();
            string[] errorStrings = response.Split(',');

            errorCode = Int32.Parse(errorStrings[0]);

            if (errorCode < 0 && errorStrings.Length > 2)
            {
                return errorStrings[2];
            }
            else { return errorStrings[1]; }
        }

        public override string ToString()
        {
            return $"<{ID.Manufacturer}, {ID.Model} | {_vi.ResourceName}>";
        }

        #region Dispose Pattern
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    if (_vi != null)
                    {
                        _vi.Dispose();
                    }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _vi = null; ;
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~PatternProGenerator()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
