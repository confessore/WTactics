using System;

namespace WTactics.Models.Interfaces
{
    /// <summary>
    ///     represents an entity.
    /// </summary>
    /// <typeparam name="T">
    ///     typically a ulong but could also be something else like a guid.
    /// </typeparam>
    public interface IEntity<T>
        where T : IEquatable<T>
    {
        /// <summary>
        ///     gets or sets the unique identifier for this object.
        /// </summary>
        T Id { get; set; }
    }
}
