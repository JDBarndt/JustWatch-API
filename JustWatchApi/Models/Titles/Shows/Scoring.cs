namespace JustWatchApi.Models.Titles.Shows
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents scoring for a show.
    /// </summary>
    [DataContract]
    public class Scoring
    {
        /// <summary>
        /// Gets or sets provider type.
        /// </summary>
        [DataMember(Name = "provider_type")]
        public string ProviderType { get; set; }

        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [DataMember(Name = "value")]
        public float Value { get; set; }
    }
}
