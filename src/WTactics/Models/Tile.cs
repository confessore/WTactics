using Microsoft.Xna.Framework;
using WTactics.Enums;
using WTactics.Models.Abstractions;
using WTactics.Statics;

namespace WTactics.Models
{
    public class Tile : Drawable
    {
        public Tile(
            Terrain terrain,
            Vector2 position,
            float rotation = 0f,
            Unit unit = null,
            Item item = null) : base(position, 0)
        {
            Location = new Location(position.X, position.Y);
            position *= 16;
            Terrain = terrain;
            Position = position;
            Rotation = rotation;
            Unit = unit;
            Item = item;
            Sprite = Textures.TerrainTextures[Terrain];
        }

        public Location Location { get; set; }
        public Terrain Terrain { get; set; }
        public Unit Unit { get; set; }
        public bool Occupied =>
            Unit != null;
        public Item Item { get; set; }
        public bool Claimed =>
            Item == null;
    }
}
