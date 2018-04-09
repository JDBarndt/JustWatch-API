namespace JustWatchApi.Models
{
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Locales;

    /// <summary>
    /// Represents a response for locales.
    /// </summary>
    [DataContract]
    public class GetLocaleResponse
    {
        /// <summary>
        /// Gets or sets exposed URL part.
        /// </summary>
        [DataMember(Name = "exposed_url_part")]
        public string ExposedUrlPart { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether locale is standard.
        /// </summary>
        [DataMember(Name = "is_standard_locale")]
        public bool IsStandardLocale { get; set; }

        /// <summary>
        /// Gets or sets full locale.
        /// </summary>
        [DataMember(Name = "full_locale")]
        public string FullLocale { get; set; }

        /// <summary>
        /// Gets or sets status of country title availability.
        /// </summary>
        [DataMember(Name = "i18n_state")]
        public string I18nState { get; set; }

        /// <summary>
        /// Gets or sets ISO 3166-2 standard country code.
        /// </summary>
        [DataMember(Name = "iso_3166_2")]
        public string Iso31662 { get; set; }

        /// <summary>
        /// Gets or sets country.
        /// </summary>
        [DataMember(Name = "country")]
        public string CountryString { get; set; }

        /// <summary>
        /// Gets or sets currency code.
        /// </summary>
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets currency name.
        /// </summary>
        [DataMember(Name = "currency_name")]
        public string CurrencyName { get; set; }

        /// <summary>
        /// Gets or sets list of country name translations.
        /// </summary>
        [DataMember(Name = "country_names")]
        public CountryNames CountryNames { get; set; }
    }
}
