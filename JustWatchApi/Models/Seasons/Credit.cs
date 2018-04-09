namespace JustWatchApi.Models.Seasons
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a credit.
    /// </summary>
    [DataContract]
    public class Credit
    {
        /// <summary>
        /// Gets or sets role.
        /// </summary>
        [DataMember(Name = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets character name.
        /// </summary>
        [DataMember(Name = "character_name")]
        public string CharacterName { get; set; }

        /// <summary>
        /// Gets or sets person ID.
        /// </summary>
        [DataMember(Name = "person_id")]
        public int PersonId { get; set; }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
