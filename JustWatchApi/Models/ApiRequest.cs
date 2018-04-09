namespace JustWatchApi.Models
{
    using System.Net.Http;

    /// <summary>
    /// Represents an API request.
    /// </summary>
    public class ApiRequest : IApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiRequest"/> class.
        /// </summary>
        /// <param name="url">A valid HTTP or HTTPs URL string.</param>
        /// <param name="method">Method to send request.</param>
        public ApiRequest(string url, HttpMethod method)
        {
            this.Url = url;
            this.HttpMethod = method;
        }

        /// <summary>
        /// Gets method used to send request.
        /// </summary>
        public HttpMethod HttpMethod { get; private set; }

        /// <summary>
        /// Gets URL used to send request.
        /// </summary>
        public string Url { get; private set; }
    }
}
