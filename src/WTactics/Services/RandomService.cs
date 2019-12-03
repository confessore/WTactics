using System;
using System.Threading.Tasks;
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

        public Task<ulong> GenerateULong()
        {
            var max = 99999999;
            var tmp = (long)Random.Next((max >> 32));
            tmp = (tmp << 32);
            tmp |= Random.Next(max);
            return Task.FromResult((ulong)tmp);
        }
    }
}
