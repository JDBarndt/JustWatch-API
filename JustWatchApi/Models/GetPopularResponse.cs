namespace JustWatchApi.Models
{
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Popular;

    /// <summary>
    /// Represents a response for popular titles.
    /// </summary>
    [DataContract]
    public class GetPopularResponse
    {
        /// <summary>
        /// Gets or sets the current page of results.
        /// </summary>
        [DataMember(Name = "page")]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the page size of results.
        /// </summary>
        [DataMember(Name = "page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the total number of pages in result set.
        /// </summary>
        [DataMember(Name = "total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or sets the total number of results in result set.
        /// </summary>
        [DataMember(Name = "total_results")]
        public int TotalResults { get; set; }

        /// <summary>
        /// Gets or sets the items in the current page of results.
        /// </summary>
        [DataMember(Name = "items")]
        public Item[] Items { get; set; }
    }
}
