namespace JustWatchApi.Models
{
    using System.Net.Http;

    /// <summary>
    /// Represents base contract for API requests.
    /// </summary>
    public interface IApiRequest
    {
        /// <summary>
        /// Gets method used to send request.
        /// </summary>
        HttpMethod HttpMethod { get; }

        /// <summary>
        /// Gets URL used to send request.
        /// </summary>
        string Url { get; }
    }
}