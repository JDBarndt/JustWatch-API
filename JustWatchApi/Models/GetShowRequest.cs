namespace JustWatchApi.Models
{
    using System.Net.Http;
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;

    /// <summary>
    /// Represents a request for a show.
    /// </summary>
    [DataContract]
    public class GetShowRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetShowRequest"/> class.
        /// GetShowRequest constructor.
        /// </summary>
        /// <param name="country">Required country to return results from.</param>
        /// <param name="id">Required show ID.</param>
        public GetShowRequest(Country country, int id)
            : base($"content/titles/show/{id}/locale/{Utils.GetCulture(country)}", HttpMethod.Get)
        {
        }
    }
}
