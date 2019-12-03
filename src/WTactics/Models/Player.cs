using System;
using System.Collections.Generic;
using WTactics.Models.Interfaces;

namespace WTactics.Models
{
    public class Player : IDatedEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public List<Unit> Party { get; set; } = new List<Unit>();
    }
}
