using System;

namespace WTactics.Models.Interfaces
{
    /// <summary>
    ///     represents a snowflake entity.
    /// </summary>
    public interface IDatedEntity : IEntity<Guid>
    {
        /// <summary>
        ///     gets or sets when the snowflake was created.
        /// </summary>
        /// <returns>
        ///     a <see cref="DateTimeOffset"/> representing when the entity was first created.
        /// </returns>
        DateTimeOffset CreatedAt { get; set; }
    }
}
