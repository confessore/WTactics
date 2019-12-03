using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WTactics.Services
{
    public class EventHandlerService
    {
        public EventHandlerService()
        {
            EventService.GameOver += OnGameOver;
        }

        Task OnGameOver()
        {
            Console.WriteLine("Game Over!");
            return Task.CompletedTask;
        }
    }
}
