using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HockeyApp;

[assembly: Xamarin.Forms.Dependency(typeof(WeatherAndContactsApp.Droid.EventTracker))]

namespace WeatherAndContactsApp.Droid
{
    public class EventTracker : IEventTracker
    {
        public void TrackEvent(string eventName)
        {
            MetricsManager.TrackEvent(eventName);
        }
    }
}