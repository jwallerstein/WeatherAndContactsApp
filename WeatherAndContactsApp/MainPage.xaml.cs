using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherAndContactsApp
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            this.Children.Add(new WeatherPage());
            this.Children.Add(new ContactPage());
            InitializeComponent();
        }
    }
}
