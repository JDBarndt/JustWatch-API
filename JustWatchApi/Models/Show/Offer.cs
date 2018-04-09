namespace JustWatchApi.Models.Show
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents available offers for a show.
    /// </summary>
    [DataContract]
    public class Offer
    {
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

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
        /// Gets or sets element count.
        /// </summary>
        [DataMember(Name = "element_count")]
        public int ElementCount { get; set; }

        /// <summary>
        /// Gets or sets new element count.
        /// </summary>
        [DataMember(Name = "new_element_count")]
        public int NewElementCount { get; set; }

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
