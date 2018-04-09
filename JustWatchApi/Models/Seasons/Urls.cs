namespace JustWatchApi.Models.Seasons
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents URLs for a season.
    /// </summary>
    [DataContract]
    public class Urls
    {
        /// <summary>
        /// Gets or sets standard web address.
        /// </summary>
        [DataMember(Name = "standard_web")]
        public string StandardWeb { get; set; }

        /// <summary>
        /// Gets or sets iOS link.
        /// </summary>
        [DataMember(Name = "deeplink_ios")]
        public string DeeplinkIos { get; set; }

        /// <summary>
        /// Gets or sets android link.
        /// </summary>
        [DataMember(Name = "deeplink_android")]
        public string DeeplinkAndroid { get; set; }
    }
}
