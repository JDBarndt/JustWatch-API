namespace JustWatchApi.Models
{
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Provider;

    /// <summary>
    /// Represents a response for providers.
    /// </summary>
    public class GetProviderResponse
    {
        /// <summary>
        /// Gets or sets ID.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets profile ID.
        /// </summary>
        [DataMember(Name = "profile_id")]
        public int ProfileId { get; set; }

        /// <summary>
        /// Gets or sets technical name.
        /// </summary>
        [DataMember(Name = "technical_name")]
        public string TechnicalName { get; set; }

        /// <summary>
        /// Gets or sets short name.
        /// </summary>
        [DataMember(Name = "short_name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets clear name.
        /// </summary>
        [DataMember(Name = "clear_name")]
        public string ClearName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether provider has global account.
        /// </summary>
        [DataMember(Name = "has_global_account")]
        public bool HasGlobalAccount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether provider can create title.
        /// </summary>
        [DataMember(Name = "can_create_title")]
        public bool CanCreateTitle { get; set; }

        /// <summary>
        /// Gets or sets data.
        /// </summary>
        [DataMember(Name = "data")]
        public Data Data { get; set; }

        /// <summary>
        /// Gets or sets priority.
        /// </summary>
        [DataMember(Name = "priority")]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets display priority.
        /// </summary>
        [DataMember(Name = "display_priority")]
        public int DisplayPriority { get; set; }

        /// <summary>
        /// Gets or sets domains.
        /// </summary>
        [DataMember(Name = "domains")]
        public object[] Domains { get; set; }

        /// <summary>
        /// Gets or sets monetization types.
        /// </summary>
        [DataMember(Name = "monetization_types")]
        public string[] MonetizationTypes { get; set; }

        /// <summary>
        /// Gets or sets icon URL.
        /// </summary>
        [DataMember(Name = "icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or sets slug.
        /// </summary>
        [DataMember(Name = "slug")]
        public string Slug { get; set; }
    }
}
