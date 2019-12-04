using Microsoft.Xna.Framework;
using WTactics.Enums;
using WTactics.Models.Abstractions;
using WTactics.Statics;

namespace WTactics.Models
{
    public class MenuItem : Drawable
    {
        public MenuItem(
            MenuOption menu,
            Vector2 position,
            float rotation = 0f) : base(position, 0)
        {
            position *= -32;
            Menu = menu;
            Position = position;
            Rotation = rotation;
            Sprite = TextureDictionaries.MenuTextures[Menu];
        }

        public MenuOption Menu { get; set; }
    }
}
