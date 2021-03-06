﻿namespace JustWatchApi.Models
{
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Movie;

    /// <summary>
    /// Represents a response for a movie.
    /// </summary>
    [DataContract]
    public class GetMovieResponse
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
        /// Gets or sets full path to movie.
        /// </summary>
        [DataMember(Name = "full_path")]
        public string FullPath { get; set; }

        /// <summary>
        /// Gets or sets full paths to movie.
        /// </summary>
        [DataMember(Name = "full_paths")]
        public FullPaths FullPaths { get; set; }

        /// <summary>
        /// Gets or sets path to poster.
        /// </summary>
        [DataMember(Name = "poster")]
        public string Poster { get; set; }

        /// <summary>
        /// Gets or sets list of backdrops.
        /// </summary>
        [DataMember(Name = "backdrops")]
        public Backdrop[] Backdrops { get; set; }

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
        /// Gets or sets object type (movie).
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
        public Offer[] Offers { get; set; }

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
        /// Gets or sets runtime.
        /// </summary>
        [DataMember(Name = "runtime")]
        public int Runtime { get; set; }

        /// <summary>
        /// Gets or sets age certification.
        /// </summary>
        [DataMember(Name = "age_certification")]
        public string AgeCertification { get; set; }
    }
}
