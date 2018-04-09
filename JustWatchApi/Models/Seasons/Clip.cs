namespace JustWatchApi.Models.Seasons
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a clip.
    /// </summary>
    [DataContract]
    public class Clip
    {
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets clip source.
        /// </summary>
        [DataMember(Name = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets external ID from source.
        /// </summary>
        [DataMember(Name = "external_id")]
        public string External_Id { get; set; }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets height.
        /// </summary>
        [DataMember(Name = "height")]
        public int Height { get; set; }
    }
}
