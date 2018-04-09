namespace JustWatchApi.Models
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;
    using JustWatchApi.Models.Popular;

    // TODO: Add support for query/searching

    /// <summary>
    /// Represents a request for popular titles.
    /// </summary>
    [DataContract]
    public class GetPopularRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPopularRequest"/> class.
        /// GetPopularRequest constructor.
        /// </summary>
        /// <param name="country">Required country to return results from.</param>
        public GetPopularRequest(Country country)
            : base($"content/titles/{Utils.GetCulture(country)}/popular", HttpMethod.Post)
        {
        }

        /// <summary>
        /// Gets or sets list of age certifications.
        /// <para>Use <see cref="GetAgeCertificationResponse.TechnicalName"/> values from
        /// <see cref="JustWatchClient.GetAgeCertifications(GetAgeCertificationsRequest)"/>.</para>
        /// </summary>
        [DataMember(Name = "age_certifications")]
        public List<string> AgeCertifications { get; set; }

        /// <summary>
        /// Gets or sets list of content types.
        /// </summary>
        [DataMember(Name = "content_types")]
        public List<ContentType> ContentTypes { get; set; }

        /// <summary>
        /// Gets or sets list of genres.
        /// <para>Use <see cref="GetGenreResponse.ShortName"/> values from
        /// <see cref="JustWatchClient.GetGenres(GetGenresRequest)"/>.</para>
        /// </summary>
        [DataMember(Name = "genres")]
        public List<string> Genres { get; set; }

        /// <summary>
        /// Gets list of languages. Currently unused.
        /// </summary>
        [DataMember(Name = "languages")]
        public string Languages { get; }

        /// <summary>
        /// Gets or sets maximum price.
        /// </summary>
        [DataMember(Name = "max_price")]
        public decimal? MaxPrice { get; set; }

        /// <summary>
        /// Gets or sets minimum price.
        /// </summary>
        [DataMember(Name = "min_price")]
        public decimal? MinPrice { get; set; }

        /// <summary>
        /// Gets or sets monetization types.
        /// </summary>
        [DataMember(Name = "monetization_types")]
        public List<MonetizationType> MonetizationTypes { get; set; } =
            new List<MonetizationType>() { MonetizationType.Subscription, MonetizationType.Ads, MonetizationType.Buy, MonetizationType.Rent, MonetizationType.Free };

        /// <summary>
        /// Gets or sets page number of results.
        /// </summary>
        [DataMember(Name = "page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// Gets or sets page size of results.
        /// </summary>
        [DataMember(Name = "page_size")]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// Gets or sets list of presentation types.
        /// </summary>
        [DataMember(Name = "presentation_types")]
        public List<PresentationType> PresentationTypes { get; set; }

        /// <summary>
        /// Gets or sets list of providers.
        /// <para>Use <see cref="GetProviderResponse.ShortName"/> values from
        /// <see cref="JustWatchClient.GetProviders(GetProvidersRequest)"/>.</para>
        /// </summary>
        [DataMember(Name = "providers")]
        public List<string> Providers { get; set; }

        /// <summary>
        /// Gets or sets minimum release year. Set to null for no minimum.
        /// </summary>
        [DataMember(Name = "release_year_from")]
        public int? ReleaseYearFrom { get; set; }

        /// <summary>
        /// Gets or sets maximum release year. Set to null for no maximum.
        /// </summary>
        [DataMember(Name = "release_year_until")]
        public int? ReleaseYearUntil { get; set; }

        /// <summary>
        /// Gets or sets scoring filters.
        /// </summary>
        [DataMember(Name = "scoring_filter_types")]
        public ScoringFilterTypes ScoringFilterTypes { get; set; }

        /// <summary>
        /// Gets timeline type. Currently unused.
        /// </summary>
        [DataMember(Name = "timeline_type")]
        public string TimelineType { get; private set; }
    }
}
