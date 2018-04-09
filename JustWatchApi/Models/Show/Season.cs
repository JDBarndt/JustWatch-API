namespace JustWatchApi.Models.Show
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a season.
    /// </summary>
    public class Season
    {
        /// <summary>
        /// Gets or sets ID.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets full path to season.
        /// </summary>
        [DataMember(Name = "full_path")]
        public string FullPath { get; set; }

        /// <summary>
        /// Gets or sets path to poster.
        /// </summary>
        [DataMember(Name = "poster")]
        public string Poster { get; set; }

        /// <summary>
        /// Gets or sets season number.
        /// </summary>
        [DataMember(Name = "season_number")]
        public int SeasonNumber { get; set; }
    }
}
