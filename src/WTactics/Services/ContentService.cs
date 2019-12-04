using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Threading.Tasks;
using WTactics.Enums;
using WTactics.Services.Interfaces;

namespace WTactics.Services
{
    public class ContentService : IContentService
    {
        public Task<Dictionary<MenuOption, (Texture2D, Vector2)>> LoadMenuTexturesAsync(ContentManager contentManager)
        {
            var menu = contentManager.Load<Texture2D>("menu");
            return Task.FromResult(new Dictionary<MenuOption, (Texture2D, Vector2)>
            {
                { MenuOption.Play, (menu, new Vector2(0, 0)) },
                { MenuOption.Options, (menu, new Vector2(0, 1)) },
                { MenuOption.Exit, (menu, new Vector2(0, 2)) },
            });
        }

        public Task<Dictionary<MenuOption, (Texture2D, Vector2)>> LoadGMenuTexturesAsync(ContentManager contentManager)
        {
            var gmenu = contentManager.Load<Texture2D>("gmenu");
            return Task.FromResult(new Dictionary<MenuOption, (Texture2D, Vector2)>
            {
                { MenuOption.Play, (gmenu, new Vector2(0, 0)) },
                { MenuOption.Options, (gmenu, new Vector2(0, 1)) },
                { MenuOption.Exit, (gmenu, new Vector2(0, 2)) },
            });
        }

        public Task<Dictionary<Terrain, (Texture2D, Vector2)>> LoadTerrainTexturesAsync(ContentManager contentManager)
        {
            var terrain = contentManager.Load<Texture2D>("terrain");
            return Task.FromResult(new Dictionary<Terrain, (Texture2D, Vector2)>
            {
                { Terrain.Air, (terrain, new Vector2(0, 0)) },
                { Terrain.Earth, (terrain, new Vector2(1, 0)) },
                { Terrain.Fire, (terrain, new Vector2(2, 0)) },
                { Terrain.Life, (terrain, new Vector2(3, 0)) },
                { Terrain.Water, (terrain, new Vector2(0, 1)) },
            });
        }

        public Task<Dictionary<Job, (Texture2D, Vector2)>> LoadJobTexturesAsync(ContentManager contentManager)
        {
            var job = contentManager.Load<Texture2D>("job");
            return Task.FromResult(new Dictionary<Job, (Texture2D, Vector2)>
            {
                { Job.BlackMage, (job, new Vector2(0, 0)) },
                { Job.Chemist, (job, new Vector2(1, 0)) },
                { Job.Squire, (job, new Vector2(2, 0)) },
            });
        }
    }
}
