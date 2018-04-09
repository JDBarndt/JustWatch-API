namespace JustWatchApi.Models.Popular
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents score filtering for <see cref="GetPopularRequest"/> request.
    /// </summary>
    [DataContract]
    public class ScoringFilterTypes
    {
        /// <summary>
        /// Gets or sets IMDb score filtering.
        /// </summary>
        [DataMember(Name = "imdb:score")]
        public ImdbScore ImdbScore { get; set; }

        /// <summary>
        /// Gets or sets Tomatometer score filtering.
        /// </summary>
        [DataMember(Name = "tomato:meter")]
        public Tomatometer Tomatometer { get; set; }
    }
}
