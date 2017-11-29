using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HockeyApp;

namespace WeatherAndContactsApp.Droid
{
    [Activity(Label = "WeatherContactsApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        private string appId = "2060d1a94d6e43579e9f5ba44680cf09";
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            HockeyApp.Android.CrashManager.Register(this, appId);
            HockeyApp.Android.Metrics.MetricsManager.Register(Application, appId);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

