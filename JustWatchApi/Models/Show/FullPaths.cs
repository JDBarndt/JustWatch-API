namespace JustWatchApi.Models.Show
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents location of show details on JustWatch.
    /// </summary>
    [DataContract]
    public class FullPaths
    {
        /// <summary>
        /// Gets or sets location of show detail page.
        /// </summary>
        [DataMember(Name = "SHOW_DETAIL_OVERVIEW")]
        public string ShowDetailOverview { get; set; }
    }
}
