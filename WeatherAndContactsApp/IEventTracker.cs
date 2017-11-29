using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAndContactsApp
{
    public interface IEventTracker
    {
        void TrackEvent(string eventName);
    }
}
