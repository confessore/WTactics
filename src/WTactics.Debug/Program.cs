using System.Threading.Tasks;

namespace WTactics.Debug
{
    class Program
    {
        static void Main(string[] args) =>
            new Program().MainAsync().GetAwaiter().GetResult();

        async Task MainAsync()
        {
            new WTactics();
            await Task.Delay(-1);
        }
    }
}
