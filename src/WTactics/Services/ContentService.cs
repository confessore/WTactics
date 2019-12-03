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
        public Task<Dictionary<Terrain, (Texture2D, Vector2)>> LoadTerrainsAsync(ContentManager contentManager)
        {
            var terrains = contentManager.Load<Texture2D>("terrains");
            return Task.FromResult(new Dictionary<Terrain, (Texture2D, Vector2)>
            {
                { Terrain.Air, (terrains, new Vector2(0, 0)) },
                { Terrain.Earth, (terrains, new Vector2(1, 0)) },
                { Terrain.Fire, (terrains, new Vector2(2, 0)) },
                { Terrain.Life, (terrains, new Vector2(3, 0)) },
                { Terrain.Water, (terrains, new Vector2(0, 1)) },
            });
        }

        public Task<Dictionary<Job, (Texture2D, Vector2)>> LoadJobsAsync(ContentManager contentManager)
        {
            var jobs = contentManager.Load<Texture2D>("jobs");
            return Task.FromResult(new Dictionary<Job, (Texture2D, Vector2)>
            {
                { Job.BlackMage, (jobs, new Vector2(0, 0)) },
                { Job.Chemist, (jobs, new Vector2(1, 0)) },
                { Job.Squire, (jobs, new Vector2(2, 0)) },
            });
        }
    }
}
