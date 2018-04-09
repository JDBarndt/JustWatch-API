namespace JustWatchApi.Models
{
    using System.Net.Http;
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;

    /// <summary>
    /// Represents a request for locales.
    /// </summary>
    [DataContract]
    public class GetLocalesRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLocalesRequest"/> class.
        /// GetLocalesRequest constructor.
        /// </summary>
        public GetLocalesRequest()
            : base($"content/locales/state", HttpMethod.Get)
        {
        }

        /// <summary>
        /// Gets or sets country.
        /// </summary>
        public Country? Country { get; set; }
    }
}
