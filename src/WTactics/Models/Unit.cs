using Microsoft.Xna.Framework;
using WTactics.Enums;
using WTactics.Models.Abstractions;

namespace WTactics.Models
{
    public class Unit : Drawable
    {
        public Unit(Vector2 position) : base(position, 0) { }

        public string Name { get; set; }
        public Race Race { get; set; }
        public Job Job { get; set; }
    }
}
