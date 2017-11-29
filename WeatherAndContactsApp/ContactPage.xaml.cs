using HockeyApp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using WeatherAndContactsApp;

namespace WeatherAndContactsApp
{
    public partial class ContactPage : ContentPage
    {
        
        public ContactPage()
        {          
            InitializeComponent();
            Title = "Contacts";
        }


        async void Click_Add(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Name = nameTxt.Text;
            c.Phonenumber = phoneTxt.Text;
            StackLayout s = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            Label nameLbl = new Label()
            {
                Text = nameTxt.Text,
                FontSize = 20
            };
            Label phoneLbl = new Label()
            {
                Text = phoneTxt.Text,
                FontSize = 20
            };
            s.Children.Add(nameLbl);
            s.Children.Add(phoneLbl);
            stackList.Children.Add(s);
            int i = App.Database.SaveItem(c);
                await DisplayAlert("Added", "Contact was added ...", "OK");
                nameTxt.Text = "";
                phoneTxt.Text = "";

                
                //Log Event
                DependencyService.Get<IEventTracker>().TrackEvent("A new contact was added");
            }
        }


        }

    
