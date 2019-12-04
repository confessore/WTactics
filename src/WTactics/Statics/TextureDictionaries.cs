using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using WTactics.Enums;

namespace WTactics.Statics
{
    public static class TextureDictionaries
    {
        public static Dictionary<MenuOption, (Texture2D, Vector2)> MenuTextures { get; set; } = new Dictionary<MenuOption, (Texture2D, Vector2)>();
        public static Dictionary<MenuOption, (Texture2D, Vector2)> GMenuTextures { get; set; } = new Dictionary<MenuOption, (Texture2D, Vector2)>();
        public static Dictionary<Terrain, (Texture2D, Vector2)> TerrainTextures { get; set; } = new Dictionary<Terrain, (Texture2D, Vector2)>();
        public static Dictionary<Job, (Texture2D, Vector2)> JobTextures { get; set; } = new Dictionary<Job, (Texture2D, Vector2)>();
    }
}
