namespace JustWatchApi.Models
{
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;

    /// <summary>
    /// Represents a response for age certifications.
    /// </summary>
    [DataContract]
    public class GetAgeCertificationResponse
    {
        /// <summary>
        /// Gets or sets ID.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets technical name for age certification.
        /// </summary>
        [DataMember(Name = "technical_name")]
        public string TechnicalName { get; set; }

        /// <summary>
        /// Gets or sets age certification description.
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets content type (movie/show).
        /// </summary>
        [DataMember(Name = "object_type")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets country code.
        /// </summary>
        [DataMember(Name = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets order certification should be presented in.
        /// </summary>
        [DataMember(Name = "order")]
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets certification authority.
        /// </summary>
        [DataMember(Name = "organization")]
        public string Organization { get; set; }
    }
}
