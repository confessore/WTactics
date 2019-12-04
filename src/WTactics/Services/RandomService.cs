using System;
using WTactics.Services.Interfaces;

namespace WTactics.Services
{
    public class RandomService : IRandomService
    {
        public RandomService()
        {
            Random = new Random();
        }

        public Random Random { get; set; }
    }
}
