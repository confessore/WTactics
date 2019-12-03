using Android.App;
using Android.OS;
using Android.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Xna.Framework;
using System;
using WTactics.Services;
using WTactics.Services.Interfaces;

namespace WTactics.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AndroidGameActivity
    {
        readonly IServiceProvider services;

        public MainActivity()
        {
            services = ConfigureServices();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var g = services.GetRequiredService<DawningMoon>();
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();
        }

        IServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddSingleton<DawningMoon>()
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