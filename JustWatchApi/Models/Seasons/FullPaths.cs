namespace JustWatchApi.Models.Seasons
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents location of season details on JustWatch.
    /// </summary>
    [DataContract]
    public class FullPaths
    {
        /// <summary>
        /// Gets or sets location of season detail page.
        /// </summary>
        [DataMember(Name = "SEASON_DETAIL_OVERVIEW")]
        public string SeasonDetailOverview { get; set; }
    }
}
