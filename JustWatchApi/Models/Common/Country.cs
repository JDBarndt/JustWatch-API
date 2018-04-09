namespace JustWatchApi.Models.Common
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// JustWatch supported countries.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Country
    {
        /// <summary>
        /// Represents United States.
        /// </summary>
        [EnumMember(Value = "en_US")]
        UnitedStates,

        /// <summary>
        /// Represents Canada.
        /// </summary>
        [EnumMember(Value = "en_CA")]
        Canada,

        /// <summary>
        /// Represents Mexico.
        /// </summary>
        [EnumMember(Value = "es_MX")]
        Mexico,

        /// <summary>
        /// Represents Brazil.
        /// </summary>
        [EnumMember(Value = "pt_BR")]
        Brazil,

        /// <summary>
        /// Represents United Kingdom.
        /// </summary>
        [EnumMember(Value = "en_GB")]
        UnitedKingdom,

        /// <summary>
        /// Represents Germany.
        /// </summary>
        [EnumMember(Value = "de_DE")]
        Germany,

        /// <summary>
        /// Represents Austria.
        /// </summary>
        [EnumMember(Value = "de_AT")]
        Austria,

        /// <summary>
        /// Represents Switzerland.
        /// </summary>
        [EnumMember(Value = "de_CH")]
        Switzerland,

        /// <summary>
        /// Represents Ireland.
        /// </summary>
        [EnumMember(Value = "en_IE")]
        Ireland,

        /// <summary>
        /// Represents Russia.
        /// </summary>
        [EnumMember(Value = "ru_RU")]
        Russia,

        /// <summary>
        /// Represents Italy.
        /// </summary>
        [EnumMember(Value = "it_IT")]
        Italy,

        /// <summary>
        /// Represents France.
        /// </summary>
        [EnumMember(Value = "fr_FR")]
        France,

        /// <summary>
        /// Represents Spain.
        /// </summary>
        [EnumMember(Value = "es_ES")]
        Spain,

        /// <summary>
        /// Represents Netherlands.
        /// </summary>
        [EnumMember(Value = "en_NL")]
        Netherlands,

        /// <summary>
        /// Represents Norway.
        /// </summary>
        [EnumMember(Value = "en_NO")]
        Norway,

        /// <summary>
        /// Represents Sweden.
        /// </summary>
        [EnumMember(Value = "en_SE")]
        Sweden,

        /// <summary>
        /// Represents Denmark.
        /// </summary>
        [EnumMember(Value = "en_DK")]
        Denmark,

        /// <summary>
        /// Represents Finland.
        /// </summary>
        [EnumMember(Value = "en_FI")]
        Finland,

        /// <summary>
        /// Represents Lithuania.
        /// </summary>
        [EnumMember(Value = "en_LT")]
        Lithuania,

        /// <summary>
        /// Represents Latvia.
        /// </summary>
        [EnumMember(Value = "en_LV")]
        Latvia,

        /// <summary>
        /// Represents Estonia.
        /// </summary>
        [EnumMember(Value = "en_EE")]
        Estonia,

        /// <summary>
        /// Represents South Africa.
        /// </summary>
        [EnumMember(Value = "en_ZA")]
        SouthAfrica,

        /// <summary>
        /// Represents Australia.
        /// </summary>
        [EnumMember(Value = "en_AU")]
        Australia,

        /// <summary>
        /// Represents New Zealand.
        /// </summary>
        [EnumMember(Value = "en_NZ")]
        NewZealand,

        /// <summary>
        /// Represents India.
        /// </summary>
        [EnumMember(Value = "en_IN")]
        India,

        /// <summary>
        /// Represents Japan.
        /// </summary>
        [EnumMember(Value = "ja_JP")]
        Japan,

        /// <summary>
        /// Represents South Korea.
        /// </summary>
        [EnumMember(Value = "ko_KR")]
        SouthKorea,

        /// <summary>
        /// Represents Thailand.
        /// </summary>
        [EnumMember(Value = "en_TH")]
        Thailand,

        /// <summary>
        /// Represents Malaysia.
        /// </summary>
        [EnumMember(Value = "en_MY")]
        Malaysia,

        /// <summary>
        /// Represents Philippines.
        /// </summary>
        [EnumMember(Value = "en_PH")]
        Philippines,

        /// <summary>
        /// Represents Singapore.
        /// </summary>
        [EnumMember(Value = "en_SG")]
        Singapore,

        /// <summary>
        /// Represents Indonesia.
        /// </summary>4
        [EnumMember(Value = "en_ID")]
        Indonesia
    }
}
