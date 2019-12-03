using System;
using System.Threading.Tasks;
using WTactics.Models;
using WTactics.Services.Interfaces;

namespace WTactics.Services
{
    public class EventService : IEventService
    {
        public static event Func<Task> GameOver;

        public Task<bool> IsGameOver(Map map)
        {
            return Task.FromResult(true);
        }
    }
}
