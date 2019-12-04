using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Threading.Tasks;
using WTactics.Enums;

namespace WTactics.Services.Interfaces
{
    public interface IContentService
    {
        Task<Dictionary<MenuOption, (Texture2D, Vector2)>> LoadMenuTexturesAsync(ContentManager contentManager);
        Task<Dictionary<MenuOption, (Texture2D, Vector2)>> LoadGMenuTexturesAsync(ContentManager contentManager);
        Task<Dictionary<Terrain, (Texture2D, Vector2)>> LoadTerrainTexturesAsync(ContentManager contentManager);
        Task<Dictionary<Job, (Texture2D, Vector2)>> LoadJobTexturesAsync(ContentManager contentManager);
    }
}
