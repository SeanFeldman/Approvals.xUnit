![Icon](https://github.com/SeanFeldman/Approvals.xUnit/blob/master/images/project-icon.png)

## Approvals testing with xUnit

[![license](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/SeanFeldman/Approvals.xUnit/blob/master/LICENSE)
[![develop](https://img.shields.io/appveyor/ci/seanfeldman/Approvals-xUnit/develop.svg?style=flat-square&branch=develop)](https://ci.appveyor.com/project/seanfeldman/Approvals-xUnit)
[![opened issues](https://img.shields.io/github/issues-raw/badges/shields/website.svg)](https://github.com/SeanFeldman/Approvals.xUnit/issues)

### Nuget package

[![NuGet Status](https://buildstats.info/nuget/Approvals.xUnit?includePreReleases=true)](https://www.nuget.org/packages/Approvals.xUnit/)

Available here http://nuget.org/packages/Approvals.xUnit

To Install from the Nuget Package Manager Console 
    
    PM> Install-Package Approvals.xUnit

## How to use

- Install the latest version of the `PublicApiGenerator` package.
- Install this package (`Approvals.xUnit`).
- Add `<Optimize>false</Optimize>` to test project.
- Remove any `[MethodImpl(MethodImplOptions.NoInlining)]` from tests using approvals.
- Call `Approver.Verify()`

## Icon

Created by Srinivas Agra from the Noun Project