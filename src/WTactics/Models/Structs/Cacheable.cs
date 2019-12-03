using System;
using WTactics.Models.Interfaces;

namespace WTactics.Models.Structs
{
    public struct Cacheable<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : IEquatable<TId>
    {
    }
}
