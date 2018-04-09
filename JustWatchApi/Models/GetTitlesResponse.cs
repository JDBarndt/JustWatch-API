namespace JustWatchApi.Models
{
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Titles;

    /// <summary>
    /// Represents a response for multiple titles.
    /// </summary>
    [DataContract]
    public class GetTitlesResponse
    {
        /// <summary>
        /// Gets or sets titles.
        /// </summary>
        [DataMember(Name = "titles")]
        public TitlesResponse Titles { get; set; }
    }
}
