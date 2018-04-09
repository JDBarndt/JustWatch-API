namespace JustWatchApi.Models
{
    using System.Net.Http;
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;

    /// <summary>
    /// Represents a request for a movie.
    /// </summary>
    [DataContract]
    public class GetMovieRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMovieRequest"/> class.
        /// GetMovieRequest constructor.
        /// </summary>
        /// <param name="country">Required country to return results from.</param>
        /// <param name="id">Required movie ID.</param>
        public GetMovieRequest(Country country, int id)
            : base($"content/titles/movie/{id}/locale/{Utils.GetCulture(country)}", HttpMethod.Get)
        {
        }
    }
}
