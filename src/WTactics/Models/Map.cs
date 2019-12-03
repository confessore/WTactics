using System;
using System.Collections.Generic;
using WTactics.Models.Interfaces;

namespace WTactics.Models
{
    public class Map : IDatedEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public List<Tile> Tiles { get; set; } = new List<Tile>();
    }
}
