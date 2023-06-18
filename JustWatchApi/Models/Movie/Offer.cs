namespace JustWatchApi.Models.Movie
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents available offers for a movie.
    /// </summary>
    [DataContract]
    public class Offer
    {
        /// <summary>
        /// Gets or sets monetization type.
        /// </summary>
        [DataMember(Name = "monetization_type")]
        public string MonetizationType { get; set; }

        /// <summary>
        /// Gets or sets provider ID.
        /// </summary>
        [DataMember(Name = "provider_id")]
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or sets retail price.
        /// </summary>
        [DataMember(Name = "retail_price")]
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// Gets or sets last change retail price.
        /// </summary>
        [DataMember(Name = "last_change_retail_price")]
        public decimal LastChangeRetailPrice { get; set; }

        /// <summary>
        /// Gets or sets last change difference.
        /// </summary>
        [DataMember(Name = "last_change_difference")]
        public decimal LastChangeDifference { get; set; }

        /// <summary>
        /// Gets or sets last change percent.
        /// </summary>
        [DataMember(Name = "last_change_percent")]
        public float LastChangePercent { get; set; }

        /// <summary>
        /// Gets or sets last change date.
        /// </summary>
        [DataMember(Name = "last_change_date")]
        public string LastChangeDate { get; set; }

        /// <summary>
        /// Gets or sets last change date provider ID.
        /// </summary>
        [DataMember(Name = "last_change_date_provider_id")]
        public string LastChangeDateProviderId { get; set; }

        /// <summary>
        /// Gets or sets currency.
        /// </summary>
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets URLs.
        /// </summary>
        [DataMember(Name = "urls")]
        public Urls Urls { get; set; }

        /// <summary>
        /// Gets or sets subtitle languages.
        /// </summary>
        [DataMember(Name = "subtitle_languages")]
        public string[] SubtitleLanguages { get; set; }

        /// <summary>
        /// Gets or sets audio languages.
        /// </summary>
        [DataMember(Name = "audio_languages")]
        public object[] AudioLanguages { get; set; }

        /// <summary>
        /// Gets or sets presentation type.
        /// </summary>
        [DataMember(Name = "presentation_type")]
        public string PresentationType { get; set; }

        /// <summary>
        /// Gets or sets date provider ID.
        /// </summary>
        [DataMember(Name = "date_provider_id")]
        public string DateProviderId { get; set; }

        /// <summary>
        /// Gets or sets date created.
        /// </summary>
        [DataMember(Name = "date_created")]
        public string DateCreated { get; set; }
    }
}
