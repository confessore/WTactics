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
        Task<Dictionary<Terrain, (Texture2D, Vector2)>> LoadTerrainsAsync(ContentManager contentManager);
        Task<Dictionary<Job, (Texture2D, Vector2)>> LoadJobsAsync(ContentManager contentManager);
    }
}
