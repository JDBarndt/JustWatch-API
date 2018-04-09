namespace JustWatchApi.Models.Common
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// JustWatch supported monetization types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MonetizationType
    {
        /// <summary>
        /// Represents content that requires a subscription.
        /// </summary>
        [EnumMember(Value = "flatrate")]
        Subscription,

        /// <summary>
        /// Represents ad-supported content.
        /// </summary>
        [EnumMember(Value = "ads")]
        Ads,

        /// <summary>
        /// Represents content available to rent.
        /// </summary>
        [EnumMember(Value = "rent")]
        Rent,

        /// <summary>
        /// Represents content available to purchase.
        /// </summary>
        [EnumMember(Value = "buy")]
        Buy,

        /// <summary>
        /// Represents content available for free.
        /// </summary>
        [EnumMember(Value = "free")]
        Free
    }
}
