namespace JustWatchApi.Models.Common
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// JustWatch supported content types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentType
    {
        /// <summary>
        /// Represents Movies.
        /// </summary>
        [EnumMember(Value = "movie")]
        Movie,

        /// <summary>
        /// Represents TV Shows.
        /// </summary>
        [EnumMember(Value = "show")]
        Show
    }
}
