namespace JustWatchApi.Models
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a response for genres.
    /// </summary>
    [DataContract]
    public class GetGenreResponse
    {
        /// <summary>
        /// Gets or sets ID.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets translation.
        /// </summary>
        [DataMember(Name = "translation")]
        public string Translation { get; set; }

        /// <summary>
        /// Gets or sets short name.
        /// </summary>
        [DataMember(Name = "short_name")]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets technical name.
        /// </summary>
        [DataMember(Name = "technical_name")]
        public string TechnicalName { get; set; }

        /// <summary>
        /// Gets or sets slug.
        /// </summary>
        [DataMember(Name = "slug")]
        public string Slug { get; set; }
    }
}
