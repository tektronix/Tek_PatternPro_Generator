using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ivi.Visa;
using Tek_PatternPro_Generator;

namespace Tektronix.PatternPro
{
    /*
    interface IVoltageLevel
    {
        float Amplitude { get; set; }
        float Offset { get; set; }
        float Termination { get; set; }
    }

    interface IVoltage
    {
        bool Link { get; set; }
        IVoltageLevel Positive { get; }
        IVoltageLevel Negative { get; }
    }
    // */

    public enum DigitalPatternType
    {
        DATA = 0,
        PRBS
    }
    public enum PRBSPattern
    {
        PRBS7 = 7,
        PRBS9 = 9,
        PRBS11 = 11,
        PRBS15 = 15,
        PRBS23 = 23,
        PRBS31 = 31,
    }

    public class PatternProChannel
    {
        internal PatternProGenerator _parrentGenerator = null;
        internal IMessageBasedSession _vi = null;
        internal string _chNum;

        internal PatternProChannel(PatternProGenerator parrentGenerator, string channelNumber)
        {
            _parrentGenerator = parrentGenerator;
            _vi = _parrentGenerator._vi;
            _chNum = channelNumber;
        }

        public PatternProGenerator ParrentGenerator { get => _parrentGenerator; }
        public string ChannelNumber { get => _chNum; }

        #region :OUTPut[1|2|3|4] Commands
        /// <summary>
        /// Programs the polarity of the channel outputs.
        /// Normal is true, Inverted is false.
        /// </summary>
        public bool OutputPolarity
        {
            get
            {
                _vi.FormattedIO.Write($"OUTP{_chNum}:POL?");
                return (_vi.FormattedIO.ReadLine().Contains("NORM")) ? true : false;
            }
            set
            {
                string polarity = value ? "NORM" : "INV";
                _vi.FormattedIO.Write($"OUTP{_chNum}:STAT {polarity}");
            }
        }

        /// <summary>
        /// Enables/Disables the channel output.
        /// </summary>
        public bool OutputEnabled
        {
            get
            {
                _vi.FormattedIO.WriteLine($"OUTP{_chNum}:STAT?");
                return (_vi.FormattedIO.ReadLine().Trim() == "ON") ? true : false;
            }
            set
            {
                string state = value ? "ON" : "OFF";
                _vi.FormattedIO.WriteLine($"OUTP{_chNum}:STAT {state}");
            }
        }
        #endregion


        #region SOURce:___[1|2|3|4] Commands

        /// <summary>
        /// Programs the skew.
        /// </summary>
        public float Skew
        {
            get
            {
                _vi.FormattedIO.WriteLine($":SOUR:SKEW{_chNum}?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":SOUR:SKEW{_chNum} {value}");
            }
        }

        /// <summary>
        /// Equivalent to setting the positive voltage amplitude.
        /// Usually used when Link is enabled.
        /// </summary>
        public float VoltageAmplitude
        {
            get
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:AMPL?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:AMPL {value}");
            }
        }
        
        /// <summary>
        /// Sets the voltage amplitude of the positive channel output.
        /// </summary>
        public float VoltageAmplitudePositive
        {
            get
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:POS:AMPL?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:POS:AMPL {value}");
            }
        }
        
        /// <summary>
        /// Sets the voltage amplitude of the negative channel output.
        /// </summary>
        public float VoltageAmplitudeNegative
        {
            get
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:NEG:AMPL?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:NEG:AMPL {value}");
            }
        }

        /// <summary>
        /// Equivalent to setting the positive voltage offset.
        /// Usually used when Link is enabled.
        /// </summary>
        public float VoltageOffset
        {
            get
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:OFFS?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:OFFS {value}");
            }
        }
        
        /// <summary>
        /// Sets the voltage offset of the positive channel output.
        /// </summary>
        public float VoltageOffsetPositive
        {
            get
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:POS:OFFS?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:POS:OFFS {value}");
            }
        }

        /// <summary>
        /// Sets the voltage offset of the negative channel output.
        /// </summary>
        public float VoltageOffsetNegative
        {
            get
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:NEG:OFFS?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:NEG:OFFS {value}");
            }
        }

        /// <summary>
        /// Equivalent to setting the positive termination voltage.
        /// Usually used when Link is enabled.
        /// </summary>
        public float VoltageTermination
        {
            get
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:TERM?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:TERM {value}");
            }
        }

        /// <summary>
        /// Sets the termination voltage of the positive channel output. 
        /// </summary>
        public float VoltageTerminationPositive
        {
            get
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:POS:TERM?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:POS:TERM {value}");
            }
        }

        /// <summary>
        /// Sets the termination voltage of the negative channel output. 
        /// </summary>
        public float VoltageTerminationNegative
        {
            get
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:NEG:TERM?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":VOLT{_chNum}:NEG:TERM {value}");
            }
        }
        
        /// <summary>
        /// Enables/Disables link the positive and negative voltage values.
        /// Note: The Link command will fail to turn Link on if the voltages are not already set to the same value.
        /// </summary>
        public bool VoltageLink
        {
            get
            {
                _vi.FormattedIO.WriteLine($":SOUR:VOLT{_chNum}:LINK?");
                string response = _vi.FormattedIO.ReadLine().Trim();

                if ( response == "ON") { return true; }
                else if ( response == "OFF") {  return false; }
                else { throw new Exception($"Instrument returned unknown voltage link state: {response}"); }
            }
            set
            {
                // Link won't turn on unless the positive and negative terms are already the same.
                string linkState = (value) ? "ON" : "OFF";
                _vi.FormattedIO.WriteLine($":SOUR:VOLT{_chNum}:LINK {linkState}");
            }
        }
        #endregion


        #region DIGital[1|2|3|4]:PATTern Commands
        /// <summary>
        /// Programs the Pattern Length. This value is only relevant if the pattern type is DATA.
        /// For the one channel instruments, the length may be any integer from 2 through 4,194,304.
        /// In a two or four channel unit, the maximum pattern length per channel is 2,097,152.
        /// </summary>
        public int PatternLength
        {
            get
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:LENG?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Int32.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:LENG {value}");
            }
        }

        /// <summary>
        /// Programs the Pattern PRBS Length. PRBS Length is specified as 2N-1, where N is the
        /// specified value.This value is only relevant if the pattern type is PRBS.
        /// </summary>
        public int PatternPRBSLength
        {
            get
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:PLEN?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Int32.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:PLEN {value}");
            }
        }

        /// <summary>
        /// Programs the Pattern Type.
        /// </summary>
        public DigitalPatternType PatternType
        {
            get
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:TYPE?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                if (response == "PRBS") { return DigitalPatternType.PRBS; }
                else if (response == "DATA") { return DigitalPatternType.DATA; }
                else { throw new Exception($"Instrument returned unknown pattern type: {response}"); }
            }
            set
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:TYPE {value.ToString()}");
            }
        }

        /// <summary>
        /// Programs the PRBS Pattern.
        /// PRBS Length is specified as 2N-1, where N is the specified value. This value is
        /// only relevant if the pattern type is PRBS
        /// </summary>
        public PRBSPattern PatternPRBS
        {
            get
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:PLEN?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                PRBSPattern prbsPatt = (PRBSPattern)Int32.Parse(response);
                return prbsPatt; ;
            }
            set
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:PLEN {(int)value}");
            }
        }

        /// <summary>
        /// Inserts a single error into the data output. Error insertion works for either data patterns
        /// or PRBS patterns.  If there is no pattern currently being output, for instance if the
        /// outputs are disabled, the command has no effect.
        /// </summary>
        public void SingleError()
        {
            _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:SERR");
        }

        /// <summary>
        /// Insert errors into the data output at the specified rate. Error rate insertion works for
        /// either data patterns or PRBS patterns when error rate is enabled.
        /// </summary>
        public float ErrorRate
        {
            get
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:ERAT?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:ERAT {value}");
            }
        }
        
        /// <summary>
        /// Enables insertion of errors into the data output at a rate specified by ErrorRate.
        /// </summary>
        public bool ErrorRateState
        {
            get
            {
                _vi.FormattedIO.Write($":DIG{_chNum}:PATT:ERAT:STAT?");
                return (_vi.FormattedIO.ReadLine().Trim() == "ON") ? true : false;
            }
            set
            {
                string state = value ? "ON" : "OFF";
                _vi.FormattedIO.Write($":DIG{_chNum}:PATT:ERAT:STAT {state}");
            }
        }

        /// <summary>
        /// Shift the pattern by the specified number of bits relative to nominal position.
        /// </summary>
        /// <param name="shiftCount">The number of bits to shift by.</param>
        public void PatternBitShift(int shiftCount)
        {
            _vi.FormattedIO.WriteLine($":DIG{_chNum}:PATT:BSH {shiftCount}");
        }

        /// <summary>
        /// This feature is available for the PPG1600 and PPG3000 series only.
        /// Programs the NRZ signal crossing point.  Positive(Data out) and negative
        /// outputs(Data out Bar) have independent crossing point adjustment.
        /// Note: to maintain normal complement behavior, if the POS output crossing point
        /// is set to 50+X, then the NEG should be set to 50-X.For example, if the POS were
        /// set to 57%, the NEG would be set to 43%.
        /// </summary>
        public float CrossOverValuePositive
        {
            get
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:SIGN:POS:CROS:VAL?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:SIGN:POS:CROS:VAL {value}");
            }
        }

        /// <summary>
        /// This feature is available for the PPG1600 and PPG3000 series only.
        /// Programs the NRZ signal crossing point.  Positive(Data out) and negative
        /// outputs(Data out Bar) have independent crossing point adjustment.
        /// Note: to maintain normal complement behavior, if the POS output crossing point
        /// is set to 50+X, then the NEG should be set to 50-X.For example, if the POS were
        /// set to 57%, the NEG would be set to 43%.
        /// </summary>
        public float CrossOverValueNegative
        {
            get
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:SIGN:NEG:CROS:VAL?");
                string response = _vi.FormattedIO.ReadLine().Trim();
                return Single.Parse(response);
            }
            set
            {
                _vi.FormattedIO.WriteLine($":DIG{_chNum}:SIGN:NEG:CROS:VAL {value}");
            }
        }
        #endregion

        public override string ToString()
        {
            return $"<Channel {_chNum} | {_parrentGenerator.ToString()}>";
        }
    }
}
