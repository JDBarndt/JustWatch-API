namespace JustWatchApi.Models.Show
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a backdrop for a show.
    /// </summary>
    [DataContract]
    public class Backdrop
    {
        /// <summary>
        /// Gets or sets backdrop URL.
        /// </summary>
        [DataMember(Name = "backdrop_url")]
        public string BackdropUrl { get; set; }
    }
}
