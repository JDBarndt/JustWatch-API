namespace JustWatchApi.Models.Movie
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents location of movie details on JustWatch.
    /// </summary>
    [DataContract]
    public class FullPaths
    {
        /// <summary>
        /// Gets or sets location of movie detail page.
        /// </summary>
        [DataMember(Name = "MOVIE_DETAIL_OVERVIEW")]
        public string MovieDetailOverview { get; set; }
    }
}
