# Unofficial C# JustWatch API Wrapper
This API was built to pull title information from JustWatch.

## Install
Available on NuGet:
```
Install-Package JustWatchApi -Version 0.2.0
```

## Examples

### Get popular titles

```csharp
var client = new JustWatchClient();
var response = client.GetPopular(new GetPopularRequest(Country.UnitedStates));
```

### Get movie

```csharp
var client = new JustWatchClient();
var response = client.GetMovie(new GetMovieRequest(Country.UnitedStates, 122337));
```

### Get show

```csharp
var client = new JustWatchClient();
var response = client.GetShow(new GetShowRequest(Country.UnitedStates, 12));
```

### Get season and episodes

```csharp
var client = new JustWatchClient();
var response = client.GetSeason(new GetSeasonRequest(Country.UnitedStates, 9));
```

## Disclaimer

**This is not the official JustWatch API.**

The work of many developers went and is still going into the development and maintenance of the data and the API. The main business of JustWatch is to operate a streaming guide with apps for iOS, Android and TV that offers the data for business intelligence and marketing. Therefore it is prohibited to use the API for commercial purposes, meaning all purposes intended for, or directed towards, commercial advantage or monetization by an individual or organization (consumer service, data science, business intelligence etc.). The API may be used for non-commercial purposes such as private projects, but please be respectful with your API calls to prevent an overload on the API.

JustWatch does not warrant that the API is free of inaccuracies, errors, bugs, malicious code or interruptions or that it is reliable, flawless, complete or otherwise valid. JustWatch does not warrant that the API will meet your requirements, will be available without interruption, or that the results from its use will be accurate or reliable, the quality of the products, services, information or other materials received through the API meets your expectations, and errors regarding the API are corrected. Use of the API is at your sole discretion and risk. You are solely responsible for any damages resulting from your use of the API, including damage to its system or loss of data. JustWatch can disable and change the API at any time without notice and without giving any reason. JustWatch excludes any liability to the extent permitted for direct, indirect or incidental damages, consequential damages, lost profits, quantifiable pecuniary losses arising out of or in connection with the use of the API.
Incorrect or prohibited use of the API, for example for commercial use, may result in a claim for damages by JustWatch.

If you would like to work with JustWatch and use the official Data API take a look at JustWatch Media and contact us at data-partner@justwatch.com. Currently, JustWatch can only work with bigger partners and clients. JustWatch is also hiring: https://www.justwatch.com/us/talent and has some interesting open source projects on GitHub.