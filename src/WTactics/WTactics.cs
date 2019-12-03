using Microsoft.Extensions.DependencyInjection;
using System;
using WTactics.Services;
using WTactics.Services.Interfaces;

namespace WTactics
{
    public class WTactics
    {
        readonly IServiceProvider services;

        public WTactics()
        {
            services = ConfigureServices();
            services.GetRequiredService<DawningMoon>().Run();
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
