namespace JustWatchApi
{
    using System;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Extension methods.
    /// </summary>
    internal static class Extensions
    {
        /// <summary>
        /// Returns attributes on enumerators to assist in translating typed objects to strings formatted for API.
        /// </summary>
        /// <typeparam name="TAttribute">Type of attribute to return.</typeparam>
        /// <param name="enumValue">Enum value.</param>
        /// <returns>The requested attribute type.</returns>
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
            where TAttribute : Attribute
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<TAttribute>();
        }
    }
}
