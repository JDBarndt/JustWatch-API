namespace JustWatchApi.Models.Title
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents list of movie and show titles to return for <see cref="GetTitlesRequest"/> request.
    /// </summary>
    [DataContract]
    public class TitlesRequest
    {
        /// <summary>
        /// Gets or sets list of show IDs.
        /// </summary>
        [DataMember(Name = "show")]
        public int[] Show { get; set; }

        /// <summary>
        /// Gets or sets list of movie IDs.
        /// </summary>
        [DataMember(Name = "movie")]
        public int[] Movie { get; set; }
    }
}
