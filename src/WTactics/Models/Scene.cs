using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WTactics.Models
{
    public class Scene
    {
        public Scene(Vector2 position, Texture2D texture)
        {
            Position = position;
            Texture = texture;
        }

        public Vector2 Position { get; set; }
        public Texture2D Texture { get; }

        public void Draw(SpriteBatch renderer, Vector2 drawPosition)
        {
            renderer.Draw(Texture, drawPosition, Color.White);
        }
    }
}
