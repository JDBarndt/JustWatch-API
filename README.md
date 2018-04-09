# C# JustWatch API Wrapper
This API was built to pull title information from JustWatch.

## Install
Available on NuGet:
```
Install-Package JustWatchApi -Version 0.1.0
```

## Examples

### Get popular titles

```csharp
var response = client.GetPopular(new GetPopularRequest(Country.UnitedStates));
```

### Get movie

```csharp
var response = client.GetMovie(new GetMovieRequest(Country.UnitedStates, 122337));
```

### Get show

```csharp
var response = client.GetShow(new GetShowRequest(Country.UnitedStates, 12));
```

## Additional Information

This is an unofficial wrapper library written against publicly accessible APIs. There is no support or affiliation with JustWatch.
