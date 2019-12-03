using System;

namespace WTactics.Extensions
{
    public static class RandomExtensions
    {
        public static long NextInt64(this Random random)
        {
            var buffer = new byte[sizeof(long)];
            random.NextBytes(buffer);
            return BitConverter.ToInt64(buffer, 0);
        }

        public static ulong NextUInt64(this Random random)
        {
            var buffer = new byte[sizeof(ulong)];
            random.NextBytes(buffer);
            return BitConverter.ToUInt64(buffer, 0);
        }
    }
}
