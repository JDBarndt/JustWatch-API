namespace JustWatchApi.Models.Titles
{
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Titles.Movies;
    using JustWatchApi.Models.Titles.Shows;

    /// <summary>
    /// Represents a response item for a collection of different types of titles.
    /// </summary>
    [DataContract]
    public class TitlesResponse
    {
        /// <summary>
        /// Gets or sets list of movies.
        /// </summary>
        [DataMember(Name = "movie")]
        public Movie[] Movie { get; set; }

        /// <summary>
        /// Gets or sets list of shows.
        /// </summary>
        [DataMember(Name = "show")]
        public Show[] Show { get; set; }
    }
}
