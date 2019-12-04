using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Threading.Tasks;
using WTactics.Models.Interfaces;

namespace WTactics.Models.Abstractions
{
    public abstract class Drawable : IDatedEntity
    {
        public Drawable(Vector2 position, float rotation)
        {
            Position = position;
            Rotation = rotation;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public Vector2 Position { get; set; }
        public float Rotation { get; set; }
        public float Origin { get; set; } = 0f;
        public float Scale { get; set; } = 1f;
        protected (Texture2D texture,  Vector2 position) Sprite { get; set; }

        public Task Update()
        {

            return Task.CompletedTask;
        }

        public Task Draw16x16(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                Sprite.texture,
                Position,
                new Rectangle((16 * Sprite.position).ToPoint(),
                (Vector2.One * 16).ToPoint()),
                Color.White,
                Rotation,
                new Vector2(Origin) * 8,
                new Vector2(Scale),
                SpriteEffects.None,
                0);
            return Task.CompletedTask;
        }

        public Task Draw64x16(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                Sprite.texture,
                Position,
                new Rectangle((16 * Sprite.position).ToPoint(),
                (Vector2.One * 64).ToPoint()),
                Color.White,
                Rotation,
                new Vector2(Origin) * 8,
                new Vector2(Scale),
                SpriteEffects.None,
                0);
            return Task.CompletedTask;
        }
    }
}
