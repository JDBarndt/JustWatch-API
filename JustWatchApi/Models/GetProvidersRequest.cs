namespace JustWatchApi.Models
{
    using System.Net.Http;
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;

    /// <summary>
    /// Represents a request for providers.
    /// </summary>
    [DataContract]
    public class GetProvidersRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProvidersRequest"/> class.
        /// GetProvidersRequest constructor.
        /// </summary>
        /// <param name="country">Required country to return results from.</param>
        public GetProvidersRequest(Country country)
            : base($"content/providers/locale/{Utils.GetCulture(country)}", HttpMethod.Get)
        {
        }
    }
}
