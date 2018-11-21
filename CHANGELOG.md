# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
### Added
- Contribution guidelines, code of conduct and changelog

### Changed
- nothing 

### Removed
- nothing

### Fixed
- nothing


## [0.0.2] - 2018-11-21
### Added
- basic implementation to read trackers and logs

### Changed
- compatibility to .NET Standard 2.0 as the web request stuff in .NET Standard 1.X doesn't allow to eveluate the response status code without parsing strings.
- naming of service classes - there will be no guaranteed compatibility to previous versions before release of version 1.0.0


## [0.0.1] - 2018-11-19
### Added
- basic implementation to read timebookings.
- based on .NET Standard 1.4 to provide high compatibility.