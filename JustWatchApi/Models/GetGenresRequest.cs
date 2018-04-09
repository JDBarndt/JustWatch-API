namespace JustWatchApi.Models
{
    using System.Net.Http;
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;

    /// <summary>
    /// Represents a request for genres.
    /// </summary>
    [DataContract]
    public class GetGenresRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenresRequest"/> class.
        /// GetGenresRequest constructor.
        /// </summary>
        /// <param name="country">Required country to return results from.</param>
        public GetGenresRequest(Country country)
            : base($"content/genres/locale/{Utils.GetCulture(country)}", HttpMethod.Get)
        {
        }
    }
}
