using Microsoft.Extensions.DependencyInjection;
using System;
using WTactics.Enums;
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
                .AddSingleton<IRandomService, RandomService>()
                .AddSingleton<IContentService, ContentService>()
                .AddSingleton<IMenuService, MenuService>()
                .AddSingleton<ITileService, TileService>()
                .AddSingleton<IMapService, MapService>()
                .AddSingleton<IEventService, EventService>()
                .AddSingleton<EventHandlerService>()
                .AddSingleton<IRegistrationService, RegistrationService>()
                .AddSingleton<DawningMoon>()
                .BuildServiceProvider();
        }
    }
}
