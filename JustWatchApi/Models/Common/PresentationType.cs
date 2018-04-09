namespace JustWatchApi.Models.Common
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// JustWatch supported presentation types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PresentationType
    {
        /// <summary>
        /// Represents standard definition content.
        /// </summary>
        [EnumMember(Value = "sd")]
        SD,

        /// <summary>
        /// Represents high definition content.
        /// </summary>
        [EnumMember(Value = "hd")]
        HD,

        /// <summary>
        /// Represents ultra-high definition (4K) content.
        /// </summary>
        [EnumMember(Value = "4k")]
        UHD
    }
}
