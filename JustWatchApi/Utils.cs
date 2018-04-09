namespace JustWatchApi
{
    using System.Runtime.Serialization;
    using JustWatchApi.Models.Common;

    /// <summary>
    /// Utility methods.
    /// </summary>
    internal static class Utils
    {
        /// <summary>
        /// Translates country into culture string.
        /// </summary>
        /// <param name="country">Required country.</param>
        /// <returns>Culture string.</returns>
        internal static string GetCulture(Country country)
        {
            return country.GetAttribute<EnumMemberAttribute>().Value;
        }

        /// <summary>
        /// Translates country into country code string.
        /// </summary>
        /// <param name="country">Required country.</param>
        /// <returns>Country code string.</returns>
        internal static string GetCountryCode(Country country)
        {
            var culture = country.GetAttribute<EnumMemberAttribute>().Value;
            return culture.Substring(culture.IndexOf("_") + 1);
        }

        /// <summary>
        /// Translates content type into API-friendly content type string.
        /// </summary>
        /// <param name="contentType">Required content type.</param>
        /// <returns>API-friendly content type string.</returns>
        internal static string GetContentTypeString(ContentType contentType)
        {
            return contentType.GetAttribute<EnumMemberAttribute>().Value;
        }
    }
}
