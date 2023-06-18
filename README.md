# C# JustWatch API Wrapper
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

## Additional Information

This is not the official JustWatch API. JustWatch doesn't offer an open API and doesn't plan to do this in the future.

The work of many developers went and is still going into the development and maintenance of the data and the API. JustWatch's main business is to operate a [streaming guide](https://www.justwatch.com/) with apps for iOS and Android. They offer the data for business intelligence and marketing. Therefore it is prohibited to use the API for commercial use (consumer service, data science, business intelligence, etc.). It is ok to use the API for private projects, but please be respectful with your API calls to not put too much load on the API. The API is not supported in any way and will change frequently without warning.

If you would like to work with JustWatch and use the data/API please get in contact with them via [info@justwatch.com](mailto:info@justwatch.com). Currently, JustWatch can only work with bigger partners and clients.
JustWatch is also hiring: https://www.justwatch.com/us/talent and has some interesting open source projects:

- [JustWatch on Github](https://github.com/justwatchcom)
- [GoPass Password Manager](https://github.com/gopasspw/gopass)
