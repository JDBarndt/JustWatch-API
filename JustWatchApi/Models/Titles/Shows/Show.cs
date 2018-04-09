namespace JustWatchApi.Models.Titles.Shows
{
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;

    /// <summary>
    /// Represents a response item for a show.
    /// </summary>
    [DataContract]
    public class Show
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
        /// Gets or sets full path to show.
        /// </summary>
        [DataMember(Name = "full_path")]
        public string FullPath { get; set; }

        /// <summary>
        /// Gets or sets file paths to show.
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
        /// Gets or sets content type.
        /// </summary>
        [DataMember(Name = "object_type")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets original title.
        /// </summary>
        [DataMember(Name = "original_title")]
        public string OriginalTitle { get; set; }

        /// <summary>
        /// Gets or sets available offers.
        /// </summary>
        [DataMember(Name = "offers")]
        public Offer[] Offers { get; set; }

        /// <summary>
        /// Gets or sets scoring.
        /// </summary>
        [DataMember(Name = "scoring")]
        public Scoring[] Scoring { get; set; }

        /// <summary>
        /// Gets or sets original language.
        /// </summary>
        [DataMember(Name = "original_language")]
        public string OriginalLanguage { get; set; }

        /// <summary>
        /// Gets or sets genre IDs.
        /// </summary>
        [DataMember(Name = "genre_ids")]
        public int[] GenreIds { get; set; }

        /// <summary>
        /// Gets or sets number of seasons.
        /// </summary>
        [DataMember(Name = "max_season_number")]
        public int MaxSeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets seasons.
        /// </summary>
        [DataMember(Name = "seasons")]
        public Season[] Seasons { get; set; }

        /// <summary>
        /// Gets or sets age certification.
        /// </summary>
        [DataMember(Name = "age_certification")]
        public string AgeCertification { get; set; }
    }
}
