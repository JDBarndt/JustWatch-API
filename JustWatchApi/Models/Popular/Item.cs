namespace JustWatchApi.Models.Popular
{
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;

    /// <summary>
    /// Represents a response item for popular titles.
    /// </summary>
    [DataContract]
    public class Item
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
        /// Gets or sets full path to title.
        /// </summary>
        [DataMember(Name = "full_path")]
        public string FullPath { get; set; }

        /// <summary>
        /// Gets or sets full paths to title.
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
        /// Gets or sets content type (movie/show).
        /// </summary>
        [DataMember(Name = "object_type")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets original title.
        /// </summary>
        [DataMember(Name = "original_title")]
        public string OriginalTitle { get; set; }

        /// <summary>
        /// Gets or sets original language.
        /// </summary>
        [DataMember(Name = "original_language")]
        public string OriginalLanguage { get; set; }

        /// <summary>
        /// Gets or sets number of seasons.
        /// </summary>
        [DataMember(Name = "max_season_number")]
        public int MaxSeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets age certification.
        /// </summary>
        [DataMember(Name = "age_certification")]
        public string AgeCertification { get; set; }

        /// <summary>
        /// Gets or sets runtime.
        /// </summary>
        [DataMember(Name = "runtime")]
        public int Runtime { get; set; }

        /// <summary>
        /// Gets or sets localized release date.
        /// </summary>
        [DataMember(Name = "localized_release_date")]
        public string LocalizedReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets cinema release date.
        /// </summary>
        [DataMember(Name = "cinema_release_date")]
        public string CinemaReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets cinema release week.
        /// </summary>
        [DataMember(Name = "cinema_release_week")]
        public string CinemaReleaseWeek { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether cinema release date is nationwide.
        /// </summary>
        [DataMember(Name = "is_nationwide_cinema_release_date")]
        public bool IsNationwideCinemaReleaseDate { get; set; }
    }
}
