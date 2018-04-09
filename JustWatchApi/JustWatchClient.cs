namespace JustWatchApi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using JustWatchApi.Models;
    using JustWatchApi.Models.Common;
    using Newtonsoft.Json;

    /// <summary>
    /// Client to access JustWatch API.
    /// </summary>
    public class JustWatchClient
    {
        private const string BaseUrl = "https://apis.justwatch.com/";
        private const string UserAgent = "JustWatch C# Client (github.com/JDBarndt/JustWatch-API)";
        private readonly HttpClient httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="JustWatchClient"/> class.
        /// </summary>
        /// <param name="handler">Optional pre-configured handler to use for requests.</param>
        public JustWatchClient(HttpClientHandler handler = null)
        {
            if (handler == null)
            {
                handler = new HttpClientHandler();
            }

            handler.AutomaticDecompression = System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.GZip;

            this.httpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri(BaseUrl)
            };

            this.httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgent);
        }

        /// <summary>
        /// Returns list of age certifications.
        /// Filtered by country if <see cref="GetAgeCertificationsRequest.Country"/> is set.
        /// </summary>
        /// <param name="request">Container for the necessary parmeters to execute the <see cref="GetAgeCertifications(GetAgeCertificationsRequest)"/> method.</param>
        /// <returns>The response from the Age Certifications API.</returns>
        public List<GetAgeCertificationResponse> GetAgeCertifications(GetAgeCertificationsRequest request)
        {
            var response = this.ApiRequest<List<GetAgeCertificationResponse>>(request);
            response = (request.Country == null) ? response : response.Where(x => x.Country == Utils.GetCountryCode((Country)request.Country)).ToList();
            response = (request.ContentType == null) ? response : response.Where(x => x.ObjectType == Utils.GetContentTypeString((ContentType)request.ContentType)).ToList();
            return response;
        }

        /// <summary>
        /// Returns list of age certifications.
        /// Filtered by country if <see cref="GetAgeCertificationsRequest.Country"/> is set.
        /// </summary>
        /// <param name="request">Container for the necessary parmeters to execute the <see cref="GetAgeCertificationsAsync(GetAgeCertificationsRequest)"/> method.</param>
        /// <returns>The response from the Age Certifications API.</returns>
        public async Task<List<GetAgeCertificationResponse>> GetAgeCertificationsAsync(GetAgeCertificationsRequest request)
        {
            var response = await this.ApiRequestAsync<List<GetAgeCertificationResponse>>(request);
            response = (request.Country == null) ? response : response.Where(x => x.Country == Utils.GetCountryCode((Country)request.Country)).ToList();
            response = (request.ContentType == null) ? response : response.Where(x => x.ObjectType == Utils.GetContentTypeString((ContentType)request.ContentType)).ToList();
            return response;
        }

        /*
        public string GetCinemas()
        {
            // https://apis.justwatch.com/content/cinemas/en_US?latitude=33.9772015&longitude=-118.1963514&radius=20000
            throw new NotImplementedException();
        }
        */

        /// <summary>
        /// Returns list of genres.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetGenres(GetGenresRequest)"/> method.</param>
        /// <returns>The response from the Genres API.</returns>
        public List<GetGenreResponse> GetGenres(GetGenresRequest request)
        {
            return this.ApiRequest<List<GetGenreResponse>>(request);
        }

        /// <summary>
        /// Returns list of genres.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetGenresAsync(GetGenresRequest)"/> method.</param>
        /// <returns>The response from the Genres API.</returns>
        public async Task<List<GetGenreResponse>> GetGenresAsync(GetGenresRequest request)
        {
            return await this.ApiRequestAsync<List<GetGenreResponse>>(request);
        }

        /// <summary>
        /// Returns list of locales.
        /// Filtered by country if <see cref="GetLocalesRequest.Country"/> is set.
        /// </summary>
        /// <param name="request">Container for the necessary parmeters to execute the <see cref="GetLocales(GetLocalesRequest)"/> method.</param>
        /// <returns>The response from the Locales API.</returns>
        public List<GetLocaleResponse> GetLocales(GetLocalesRequest request)
        {
            var response = this.ApiRequest<List<GetLocaleResponse>>(request);
            response = (request.Country == null) ? response : response.Where(x => x.FullLocale == Utils.GetCulture((Country)request.Country)).ToList();
            return response;
        }

        /// <summary>
        /// Returns list of locales.
        /// Filtered by country if <see cref="GetLocalesRequest.Country"/> is set.
        /// </summary>
        /// <param name="request">Container for the necessary parmeters to execute the <see cref="GetLocalesAsync(GetLocalesRequest)"/> method.</param>
        /// <returns>The response from the Locales API.</returns>
        public async Task<List<GetLocaleResponse>> GetLocalesAsync(GetLocalesRequest request)
        {
            var response = await this.ApiRequestAsync<List<GetLocaleResponse>>(request);
            response = (request.Country == null) ? response : response.Where(x => x.FullLocale == Utils.GetCulture((Country)request.Country)).ToList();
            return response;
        }

        /// <summary>
        /// Returns movie.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetMovie(GetMovieRequest)"/> method.</param>
        /// <returns>The response from the Movie API.</returns>
        public GetMovieResponse GetMovie(GetMovieRequest request)
        {
            return this.ApiRequest<GetMovieResponse>(request);
        }

        /// <summary>
        /// Returns movie.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetMovie(GetMovieRequest)"/> method.</param>
        /// <returns>The response from the Movie API.</returns>
        public async Task<GetMovieResponse> GetMovieAsync(GetMovieRequest request)
        {
            return await this.ApiRequestAsync<GetMovieResponse>(request);
        }

        /*
        public string GetMovieShowtimes()
        {
            // https://apis.justwatch.com/content/titles/movie/207121/showtimes?date=2018-04-08&latitude=33.9772015&longitude=-118.1963514&radius=20000
            throw new NotImplementedException();
            // TODO: Popular endpoint also has additional monetization option for cinema to know what titles are in theaters. Add to GetPopular API? Separate service?
        }

        public string GetNewestEpisodes()
        {
            throw new NotImplementedException();
        }
        */

        /// <summary>
        /// Returns list of titles by popularity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetPopular(GetPopularRequest)"/> method.</param>
        /// <returns>The response from the Popular API.</returns>
        public GetPopularResponse GetPopular(GetPopularRequest request)
        {
            return this.ApiRequest<GetPopularResponse>(request);
        }

        /// <summary>
        /// Returns list of titles by popularity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetPopularAsync(GetPopularRequest)"/> method.</param>
        /// <returns>The response from the Popular API.</returns>
        public async Task<GetPopularResponse> GetPopularAsync(GetPopularRequest request)
        {
            return await this.ApiRequestAsync<GetPopularResponse>(request);
        }

        /// <summary>
        /// Returns list of providers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetProviders(GetProvidersRequest)"/> method.</param>
        /// <returns>The response from the Providers API.</returns>
        public List<GetProviderResponse> GetProviders(GetProvidersRequest request)
        {
            return this.ApiRequest<List<GetProviderResponse>>(request);
        }

        /// <summary>
        /// Returns list of providers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetProvidersAsync(GetProvidersRequest)"/> method.</param>
        /// <returns>The response from the Providers API.</returns>
        public async Task<List<GetProviderResponse>> GetProvidersAsync(GetProvidersRequest request)
        {
            return await this.ApiRequestAsync<List<GetProviderResponse>>(request);
        }

        /// <summary>
        /// Returns show.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetShow(GetShowRequest)"/> method.</param>
        /// <returns>The response from the Show API.</returns>
        public GetShowResponse GetShow(GetShowRequest request)
        {
            return this.ApiRequest<GetShowResponse>(request);
        }

        /// <summary>
        /// Returns show.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetShowAsync(GetShowRequest)"/> method.</param>
        /// <returns>The response from the Show API.</returns>
        public async Task<GetShowResponse> GetShowAsync(GetShowRequest request)
        {
            return await this.ApiRequestAsync<GetShowResponse>(request);
        }

        /// <summary>
        /// Returns season.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetSeason(GetSeasonRequest)"/> method.</param>
        /// <returns>The response from the Season API.</returns>
        public GetSeasonResponse GetSeason(GetSeasonRequest request)
        {
            return this.ApiRequest<GetSeasonResponse>(request);
        }

        /// <summary>
        /// Returns season.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetSeasonAsync(GetSeasonRequest)"/> method.</param>
        /// <returns>The response from the Season API.</returns>
        public async Task<GetSeasonResponse> GetSeasonAsync(GetSeasonRequest request)
        {
            return await this.ApiRequestAsync<GetSeasonResponse>(request);
        }

        /// <summary>
        /// Returns list of requested movies and shows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetTitles(GetTitlesRequest)"/> method.</param>
        /// <returns>The response from the Title List API.</returns>
        public GetTitlesResponse GetTitles(GetTitlesRequest request)
        {
            return this.ApiRequest<GetTitlesResponse>(request);
        }

        /// <summary>
        /// Returns list of requested movies and shows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the <see cref="GetTitlesAsync(GetTitlesRequest)"/> method.</param>
        /// <returns>The response from the Title List API.</returns>
        public async Task<GetTitlesResponse> GetTitlesAsync(GetTitlesRequest request)
        {
            return await this.ApiRequestAsync<GetTitlesResponse>(request);
        }

        /*
        public string GetTitleUrls()
        {
            // https://apis.justwatch.com/content/urls?path=%2Fus%2Ftv-show%2Fthe-big-bang-theory
            throw new NotImplementedException();
        }
        */

        private T ApiRequest<T>(IApiRequest request)
        {
            string json;

            switch (request.HttpMethod)
            {
                case HttpMethod m when m == HttpMethod.Get:
                    json = this.httpClient.GetStringAsync(request.Url).Result;
                    break;
                case HttpMethod m when m == HttpMethod.Post:
                    var payload = new StringContent(JsonConvert.SerializeObject(request));
                    json = this.httpClient.PostAsync(request.Url, payload).Result.Content.ReadAsStringAsync().Result;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Parameter 'method' invalid. Allowed values: Get, Post");
            }

            return JsonConvert.DeserializeObject<T>(json);
        }

        private async Task<T> ApiRequestAsync<T>(IApiRequest request)
        {
            string json;

            switch (request.HttpMethod)
            {
                case HttpMethod m when m == HttpMethod.Get:
                    json = await this.httpClient.GetStringAsync(request.Url);
                    break;
                case HttpMethod m when m == HttpMethod.Post:
                    var payload = new StringContent(JsonConvert.SerializeObject(request));
                    var response = await this.httpClient.PostAsync(request.Url, payload);
                    json = await response.Content.ReadAsStringAsync();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Parameter 'method' invalid. Allowed values: Get, Post");
            }

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
