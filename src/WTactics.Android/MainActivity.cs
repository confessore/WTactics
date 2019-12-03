using Android.App;
using Android.OS;
using Android.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Xna.Framework;

namespace WTactics.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AndroidGameActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var w = new WTactics().Services.GetRequiredService<DawningMoon>();
            SetContentView((View)w.Services.GetService<View>());
            w.Run();
        }
    }
}
