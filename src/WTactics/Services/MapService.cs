using Microsoft.Xna.Framework;
using System;
using System.Threading.Tasks;
using WTactics.Enums;
using WTactics.Models;
using WTactics.Services.Interfaces;

namespace WTactics.Services
{
    public class MapService : IMapService
    {
        readonly IRandomService randomService;

        public MapService(IRandomService randomService)
        {
            this.randomService = randomService;
        }

        public Task<Map> GenerateNewMapAsync()
        {
            var map = new Map();
            for (int i = -5; i < 5; i++)
            {
                for (int j = -5; j < 5; j++)
                {
                    var tile = new Tile((Terrain)randomService.Random.Next(5), new Vector2(i, j), 0f)
                    {
                        Id = Guid.NewGuid(),
                        CreatedAt = DateTimeOffset.UtcNow
                    };
                    map.Tiles.Add(tile);
                }
            }
            return Task.FromResult(map);
        }
    }
}
