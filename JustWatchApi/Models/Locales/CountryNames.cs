namespace JustWatchApi.Models.Locales
{
    using System.Runtime.Serialization;

    /// <summary>
    /// References country translations for other languages.
    /// </summary>
    [DataContract]
    public class CountryNames
    {
        /// <summary>
        /// Gets or sets German translation.
        /// </summary>
        [DataMember(Name = "de")]
        public string DE { get; set; }

        /// <summary>
        /// Gets or sets Spanish translation.
        /// </summary>
        [DataMember(Name = "es")]
        public string ES { get; set; }

        /// <summary>
        /// Gets or sets French translation.
        /// </summary>
        [DataMember(Name = "fr")]
        public string FR { get; set; }

        /// <summary>
        /// Gets or sets Croatian translation.
        /// </summary>
        [DataMember(Name = "hr")]
        public string HR { get; set; }

        /// <summary>
        /// Gets or sets Italian translation.
        /// </summary>
        [DataMember(Name = "it")]
        public string IT { get; set; }

        /// <summary>
        /// Gets or sets Japanese translation.
        /// </summary>
        [DataMember(Name = "ja")]
        public string JA { get; set; }

        /// <summary>
        /// Gets or sets Dutch translation.
        /// </summary>
        [DataMember(Name = "nl")]
        public string NL { get; set; }

        /// <summary>
        /// Gets or sets Russian translation.
        /// </summary>
        [DataMember(Name = "ru")]
        public string RU { get; set; }

        /// <summary>
        /// Gets or sets Welsh translation.
        /// </summary>
        [DataMember(Name = "cy")]
        public string CY { get; set; }
    }
}
