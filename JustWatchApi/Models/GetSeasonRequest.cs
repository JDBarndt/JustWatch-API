namespace JustWatchApi.Models
{
    using System.Net.Http;
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;

    /// <summary>
    /// Represents a request for a show.
    /// </summary>
    [DataContract]
    public class GetSeasonRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSeasonRequest"/> class.
        /// GetSeasonRequest constructor.
        /// </summary>
        /// <param name="country">Required country to return results from.</param>
        /// <param name="id">Required season ID.</param>
        public GetSeasonRequest(Country country, int id)
            : base($"content/titles/show_season/{id}/locale/{Utils.GetCulture(country)}", HttpMethod.Get)
        {
        }
    }
}
