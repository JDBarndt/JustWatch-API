namespace JustWatchApi.Models
{
    using System.Net.Http;
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;
    using JustWatchApi.Models.Title;

    /// <summary>
    /// Represents a request for multiple titles.
    /// </summary>
    [DataContract]
    public class GetTitlesRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTitlesRequest"/> class.
        /// GetTitlesRequest constructor.
        /// </summary>
        /// <param name="country">Required country to return results from.</param>
        public GetTitlesRequest(Country country)
            : base($"content/titles/{Utils.GetCulture(country)}/list", HttpMethod.Post)
        {
        }

        /// <summary>
        /// Gets or sets list of titles to return.
        /// </summary>
        [DataMember(Name = "titles")]
        public TitlesRequest Titles { get; set; }
    }
}
