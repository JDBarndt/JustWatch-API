namespace JustWatchApi.Models.Popular
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents IMDb score filtering for <see cref="GetPopularRequest"/> request.
    /// </summary>
    [DataContract]
    public class ImdbScore
    {
        /// <summary>
        /// Gets or sets minimum score value.
        /// </summary>
        [DataMember(Name = "min_scoring_value")]
        public float MinScoringValue { get; set; }

        /// <summary>
        /// Gets or sets maximum score value.
        /// </summary>
        [DataMember(Name = "max_scoring_value")]
        public int MaxScoringValue { get; set; }
    }
}
