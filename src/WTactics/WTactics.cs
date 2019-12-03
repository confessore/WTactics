using Microsoft.Extensions.DependencyInjection;
using System;
using WTactics.Services;
using WTactics.Services.Interfaces;

namespace WTactics
{
    public class WTactics
    {
        public WTactics()
        {
            Services = ConfigureServices();
        }

        public IServiceProvider Services { get; }

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
