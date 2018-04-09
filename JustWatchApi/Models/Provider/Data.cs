namespace JustWatchApi.Models.Provider
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents data for providers.
    /// </summary>
    [DataContract]
    public class Data
    {
        /// <summary>
        /// Gets or sets a value indicating whether provider is public.
        /// </summary>
        [DataMember(Name = "public_info")]
        public bool PublicInfo { get; set; }
    }
}
