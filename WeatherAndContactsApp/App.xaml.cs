using HockeyApp;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Skip)]
namespace WeatherAndContactsApp
{
    public partial class App : Application
    {
        static SQLHelper database;
        public App()
        {
          
            InitializeComponent();

            MainPage = new MainPage();
            
          
        }
        public static SQLHelper Database
        {
            get { if (database == null) { database = new SQLHelper(); }
                return database; }
        }
        protected override void OnStart()
        {
            //Log event
            DependencyService.Get<IEventTracker>().TrackEvent("App started");

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
