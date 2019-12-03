using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using WTactics.Services;
using WTactics.Services.Interfaces;

namespace WTactics.Debug
{
    class Program
    {
        readonly IServiceProvider services;

        Program()
        {
            services = ConfigureServices();
        }

        static void Main(string[] args) =>
            new Program().MainAsync().GetAwaiter().GetResult();

        async Task MainAsync()
        {
            services.GetRequiredService<DawningMoon>().Run();
            await Task.Delay(-1);
        }

        IServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddSingleton<DawningMoon>()
                .AddSingleton<IRandomService, RandomService>()
                .AddSingleton<IContentService, ContentService>()
                .AddSingleton<ITileService, TileService>()
                .AddSingleton<IMapService, MapService>()
                .AddSingleton<IEventService, EventService>()
                .AddSingleton<EventHandlerService>()
                .AddSingleton<IRegistrationService, RegistrationService>()
                .BuildServiceProvider();
        }
    }
}
