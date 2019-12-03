using System;

namespace WTactics.Extensions
{
    /// <summary>
    ///     provides a series of helper methods for handling snowflake identifiers.
    /// </summary>
    public static class SnowflakeExtensions
    {
        /// <summary>
        ///     resolves the time at which the snowflake is generated.
        /// </summary>
        /// <param name="value">
        ///     the snowflake identifier to resolve.
        /// </param>
        /// <returns>
        ///     a <see cref="DateTimeOffset" /> representing the time for when the object was generated.
        /// </returns>
        public static DateTimeOffset FromSnowflake(this ulong value)
            => DateTimeOffset.FromUnixTimeMilliseconds((long)((value >> 22) + 1420070400000UL));

        /// <summary>
        ///     generates a pseudo-snowflake identifier with a <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="value">
        ///     the time to be used in the new snowflake.
        /// </param>
        /// <returns>
        ///     a <see cref="UInt64" /> representing the newly generated snowflake identifier.
        /// </returns>
        public static ulong ToSnowflake(this DateTimeOffset value)
            => ((ulong)value.ToUnixTimeMilliseconds() - 1420070400000UL) << 22;
    }
}
