namespace JustWatchApi.Models.Titles.Shows
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a response item for a season.
    /// </summary>
    [DataContract]
    public class Season
    {
        /// <summary>
        /// Gets or sets ID.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets show ID.
        /// </summary>
        [DataMember(Name = "show_id")]
        public int ShowId { get; set; }

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
    }
}
