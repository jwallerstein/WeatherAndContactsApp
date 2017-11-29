using HockeyApp;
using System;
using Xamarin.Forms;

namespace WeatherAndContactsApp
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            this.Title = "Weather";
            getWeatherBtn.Clicked += GetWeatherBtn_Clicked;
            this.BindingContext = new Weather();
        }

        private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(zipCodeEntry.Text))
            {
                //Log event           
                DependencyService.Get<IEventTracker>().TrackEvent("User requsted weather data");
                Weather weather = await Core.GetWeather(zipCodeEntry.Text);
                if (weather != null)
                {
                    this.BindingContext = weather;
                    getWeatherBtn.Text = "Search Again";
                    //Log event                 
                    DependencyService.Get<IEventTracker>().TrackEvent("User received weather data");
                }
            }
        }
    }
}