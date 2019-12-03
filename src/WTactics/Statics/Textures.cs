using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using WTactics.Enums;

namespace WTactics.Statics
{
    public static class Textures
    {
        public static Dictionary<Terrain, (Texture2D, Vector2)> TerrainTextures { get; set; } = new Dictionary<Terrain, (Texture2D, Vector2)>();
        public static Dictionary<Job, (Texture2D, Vector2)> JobTextures { get; set; } = new Dictionary<Job, (Texture2D, Vector2)>();
    }
}
