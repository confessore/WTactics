using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace WTactics.Debug
{
    class Program
    {
        static void Main(string[] args) =>
            new Program().MainAsync().GetAwaiter().GetResult();

        async Task MainAsync()
        {
            new WTactics().Services.GetRequiredService<DawningMoon>().Run();
            await Task.Delay(-1);
        }
    }
}
