using System;
using WTactics.Models.Interfaces;

namespace WTactics.Models
{
    public class Item : IDatedEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
