namespace JustWatchApi.Models
{
    using System.Net.Http;
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;

    /// <summary>
    /// Represents a request for age certifications.
    /// </summary>
    [DataContract]
    public class GetAgeCertificationsRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgeCertificationsRequest"/> class.
        /// GetAgeCertificationsRequest constructor.
        /// </summary>
        public GetAgeCertificationsRequest()
            : base($"content/age_certifications", HttpMethod.Get)
        {
        }

        /// <summary>
        /// Gets or sets country.
        /// </summary>
        public Country? Country { get; set; }

        /// <summary>
        /// Gets or sets content type.
        /// </summary>
        public ContentType? ContentType { get; set; }
    }
}
