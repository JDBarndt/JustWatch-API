namespace JustWatchApi.Models.Seasons.Episodes
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a response for an episode.
    /// </summary>
    [DataContract]
    public class Episode
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
        /// Gets or sets content type (show_episode)
        /// </summary>
        [DataMember(Name = "object_type")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets available offers.
        /// </summary>
        [DataMember(Name = "offers")]
        public Offer[] Offers { get; set; }

        /// <summary>
        /// Gets or sets season number.
        /// </summary>
        [DataMember(Name = "season_number")]
        public int SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets episode number.
        /// </summary>
        [DataMember(Name = "episode_number")]
        public int EpisodeNumber { get; set; }

        /// <summary>
        /// Gets or sets runtime.
        /// </summary>
        [DataMember(Name = "runtime")]
        public int Runtime { get; set; }

        /// <summary>
        /// Gets or sets show title.
        /// </summary>
        [DataMember(Name = "show_title")]
        public string ShowTitle { get; set; }
    }
}
