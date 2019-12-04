using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using WTactics.Services.Interfaces;

namespace WTactics.Services
{
    public class RegistrationService : IRegistrationService
    {
        readonly IServiceProvider services;

        public RegistrationService(IServiceProvider services)
        {
            this.services = services;
        }

        public async Task InitializeAsync()
        {
            await RegisterServices();
        }

        Task RegisterServices()
        {
            services.GetRequiredService<IRandomService>();
            services.GetRequiredService<IContentService>();
            services.GetRequiredService<IMenuService>();
            services.GetRequiredService<ITileService>();
            services.GetRequiredService<IMapService>();
            services.GetRequiredService<IEventService>();
            services.GetRequiredService<EventHandlerService>();
            services.GetRequiredService<IRegistrationService>();
            return Task.CompletedTask;
        }
    }
}
