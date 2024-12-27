# .github Folder Guide
This folder is a special folder used by Github to autodetect features like codeowners and workflows.

## CODEOWNERS
> [Link to Github docs](https://docs.github.com/en/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-code-owners)

> **LINTED**

A codeowner is responsible for communications regarding the repository and handling pull request approvals. You can assign a global owner (required), but you can also assign granular owners (i.e. all .js files belong to x). The respective codeowner will always be requested as a reviewer on relevant pull requests.

#### Instructions
1. Create a file named `CODEOWNERS` in this directory
2. Copy the contents of [CODEOWNERS](https://github.com/tektronix/best-practice-resources/blob/main/.github/CODEOWNERS)
   - Remember to change the global owner name on the first line

## dependabot
> [Link to Github docs](https://docs.github.com/en/code-security/dependabot/dependabot-version-updates/configuration-options-for-the-dependabot.yml-file)

> **LINTED**

A bot that keeps dependencies up to date, usually for node packages and Github actions. Dependabot is compatible with over 15 different package managers at the time of writing.

Dependabot will create pull requests on a weekly frequency (can be changed in the file) when it detects new versions of packages in the repository. A few pointers when deciding whether to merge the pull request and upgrade the package:
- Dependabot provides a compatibility score when making pull requests. It should be generally safe to merge if the badges is NOT `unknown`
- If the compatibility badge is `unknown`, look at the changelog provided for any project breaking changes
- Version number will also tell you how big of a change is being made to the package (major, minor, patch)

#### Instructions
1. Create a file named `dependabot.yml` in this directory
2. Copy the contents of [dependabot.yml](https://github.com/tektronix/best-practice-resources/blob/main/.github/dependabot.yml)
   - Remember to uncomment the bottom section and replace with the package ecosystem used by your project (if applicable and supported)

## Workflows
> [Link to Github docs](https://docs.github.com/en/actions/using-workflows/about-workflows)

Workflows allow you to automate certain jobs that act on repositories and make use of [Github Actions](https://docs.github.com/en/actions). Most of these just require you to copy the files (keeping their names) to your own project `/.github/workflows/` directory.

#### Instructions
1. Create a directory named `workflows` in your `.github` directory

### Repo Lint
> [Link to Docs](https://github.com/initialstate/file-check-action)

The `Repo Lint` workflow is powered by the [file-check-action](https://github.com/initialstate/file-check-action) action and confirms:
- CODEOWNERS file with at least a global owner
- README with content
- LICENSE with content
- dependabot.yml file with content

**IF WORKING IN A PUBLIC REPO**
- Uncomment line 12 to `state: public` and comment out line 11 `# state: private`

**IF WORKING IN A PRIVATE REPO**
- Don't change anything

#### Instructions
1. Create a file named `tek-repo-lint.yml` in the workflows directory
2. Copy the contents of [/workflows/tek-repo-lint.yml](https://github.com/tektronix/best-practice-resources/blob/main/.github/workflows/tek-repo-lint.yml) and save
   - Your main branch must be named `main` (or you can change the name next to "branches" in the file)

### CodeScan
> [Link to Github docs](https://docs.github.com/en/code-security/code-scanning/automatically-scanning-your-code-for-vulnerabilities-and-errors/about-code-scanning-with-codeql)

> **LINTED**

This workflow uses the [codeql-action](https://github.com/github/codeql-action#codeql-action) action to scan code for security vulnerabilities.

**CodeScan is only available for public repositories**

The workflow is currently setup to do nothing unless you uncomment the bottom half of the file.

#### Instructions
1. Create a file named `codeql-analysis.yml` in the workflows directory
2. Copy the contents of [/workflows/codeql-analysis.yml](https://github.com/tektronix/best-practice-resources/blob/main/.github/workflows/codeql-analysis.yml)

**IF WORKING IN A PUBLIC REPO**
- Uncomment line 26 to `state: public` and comment out line 25 `# state: private`
- Make sure the language(s) under `strategy: matrix: language:` match the languages you want scanned in your project
- **IF YOUR PROJECT DOES NOT HAVE A SUPPORTED LANGUAGE** comment out the remainder of the file starting at line 45


**IF WORKING IN A PRIVATE REPO**
- Don't change anything
- Make sure the language(s) under `strategy: matrix: language:` match the languages you want scanned in your project
- **IF YOUR PROJECT DOES NOT HAVE A SUPPORTED LANGUAGE** comment out the remainder of the file starting at line 45



