using Microsoft.Xna.Framework.Input;
using System;
using System.Threading.Tasks;
using WTactics.Models;
using WTactics.Services.Interfaces;

namespace WTactics.Services
{
    public class TileService : ITileService
    {
        readonly IEventService eventService;

        public TileService(IEventService eventService)
        {
            this.eventService = eventService;
        }

        public Task DebugTiles(Map map)
        {
            foreach (var tile in map.Tiles)
                Console.WriteLine($"{tile.Position.X} {tile.Position.X} {tile.Occupied} {tile.Unit}");
            return Task.CompletedTask;
        }

        public async Task UpdateTile(MouseState mouseState, Player player)
        {
            /*
            var s2w = TTT.ScreenToWorld(mouseState.Position.ToVector2());
            var rect = new Rectangle((int)s2w.X, (int)s2w.Y, 1, 1);
            var tile = TTT.Map.Tiles.FirstOrDefault(x => rect.Intersects(x.SpriteRectangle));
            if (tile != null && tile.Player == Player.None)
            {
                TTT.Map.Tiles.Remove(tile);
                await tile.Update(player);
                TTT.Map.Tiles.Add(tile);
                await eventService.IsGameOver(TTT.Map);
            }*/
        }

        public async Task UpdateRandomTile(Player player)
        {
            /*var tiles = TTT.Map.Tiles.Where(x => x.Player == Player.None);
            var tile = tiles.ElementAtOrDefault(TTT.Random.Next(0, tiles.Count()));
            if (tile != null && tile.Player == Player.None)
            {
                TTT.Map.Tiles.Remove(tile);
                await tile.Update(player);
                TTT.Map.Tiles.Add(tile);
                await eventService.IsGameOver(TTT.Map);
            }*/
        }
    }
}
