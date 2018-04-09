namespace JustWatchApi.Models
{
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Seasons;
    using JustWatchApi.Models.Seasons.Episodes;

    /// <summary>
    /// Represents a response for a season.
    /// </summary>
    [DataContract]
    public class GetSeasonResponse
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
        /// Gets or sets full paths to season.
        /// </summary>
        [DataMember(Name = "full_paths")]
        public FullPaths FullPaths { get; set; }

        /// <summary>
        /// Gets or sets path to poster.
        /// </summary>
        [DataMember(Name = "poster")]
        public string Poster { get; set; }

        /// <summary>
        /// Gets or sets short description.
        /// </summary>
        [DataMember(Name = "short_description")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets original release year.
        /// </summary>
        [DataMember(Name = "original_release_year")]
        public int OriginalReleaseYear { get; set; }

        /// <summary>
        /// Gets or sets TMDb popularity.
        /// </summary>
        [DataMember(Name = "tmdb_popularity")]
        public float TmdbPopularity { get; set; }

        /// <summary>
        /// Gets or sets object type (show_season).
        /// </summary>
        [DataMember(Name = "object_type")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets original title.
        /// </summary>
        [DataMember(Name = "original_title")]
        public string OriginalTitle { get; set; }

        /// <summary>
        /// Gets or sets all titles.
        /// </summary>
        [DataMember(Name = "all_titles")]
        public string[] AllTitles { get; set; }

        /// <summary>
        /// Gets or sets available offers.
        /// </summary>
        [DataMember(Name = "offers")]
        public Seasons.Offer[] Offers { get; set; }

        /// <summary>
        /// Gets or sets list of clips.
        /// </summary>
        [DataMember(Name = "clips")]
        public Clip[] Clips { get; set; }

        /// <summary>
        /// Gets or sets scoring.
        /// </summary>
        [DataMember(Name = "scoring")]
        public Scoring[] Scoring { get; set; }

        /// <summary>
        /// Gets or sets list of credits.
        /// </summary>
        [DataMember(Name = "credits")]
        public Credit[] Credits { get; set; }

        /// <summary>
        /// Gets or sets show ID.
        /// </summary>
        [DataMember(Name = "show_id")]
        public int ShowId { get; set; }

        /// <summary>
        /// Gets or sets show title.
        /// </summary>
        [DataMember(Name = "show_title")]
        public string ShowTitle { get; set; }

        /// <summary>
        /// Gets or sets season number.
        /// </summary>
        [DataMember(Name = "season_number")]
        public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets number of episodes.
        /// </summary>
        [DataMember(Name = "max_episode_number")]
        public int MaxEpisodeNumber { get; set; }

        /// <summary>
        /// Gets or sets list of episodes.
        /// </summary>
        [DataMember(Name = "episodes")]
        public Episode[] Episodes { get; set; }
    }
}
