using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(WeatherAndContactsApp.WinPhone8_1.EventTracker))]
namespace WeatherAndContactsApp.WinPhone8_1
{
    public class EventTracker : IEventTracker
    {
        public void TrackEvent(string eventName)
        {
            Microsoft.HockeyApp.HockeyClient.Current.TrackEvent(eventName);
        }
    }
}
