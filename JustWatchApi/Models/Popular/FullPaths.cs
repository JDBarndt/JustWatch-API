namespace JustWatchApi.Models.Popular
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents location of title details on JustWatch.
    /// </summary>
    [DataContract]
    public class FullPaths
    {
        /// <summary>
        /// Gets or sets location of show detail page.
        /// </summary>
        [DataMember(Name = "SHOW_DETAIL_OVERVIEW")]
        public string ShowDetailOverview { get; set; }

        /// <summary>
        /// Gets or sets location of movie detail page.
        /// </summary>
        [DataMember(Name = "MOVIE_DETAIL_OVERVIEW")]
        public string MovieDetailOverview { get; set; }
    }
}
