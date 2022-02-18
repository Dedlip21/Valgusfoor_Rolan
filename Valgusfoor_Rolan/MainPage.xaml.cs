using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Valgusfoor_Rolan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();

            Button Ent_btn = new Button()
            {
                Text = "Entry",
                BackgroundColor = Color.LightGreen,
            };
            Ent_btn.Clicked += Ent_btn_Clicked;

            Button Cliker_btn = new Button()
            {
                Text = "Clicker",
                BackgroundColor = Color.LightGreen,
            };
            Cliker_btn.Clicked += Clicker_Clicked;


            Button Valgusfoor_btn = new Button()
            {
                Text = "Valgusfoor",
                BackgroundColor = Color.LightGreen,
            };
            Valgusfoor_btn.Clicked += Valgusfoor_btn_Clicked;

            Button Rgb_btn = new Button()
            {
                Text = "Rgb line",
                BackgroundColor = Color.LightGreen,
            };
            Rgb_btn.Clicked += Rgb_btn_Clicked;

            Button Trips_btn = new Button()
            {
                Text = "Trip traps trull",
                BackgroundColor = Color.LightGreen,
            };
            Trips_btn.Clicked += Trips_btn_Clicked;

            StackLayout st = new StackLayout()
            {
                Children = { Ent_btn, Cliker_btn, Valgusfoor_btn, Rgb_btn, Trips_btn }
            };

            st.BackgroundColor = Color.LightBlue;
            Content = st;

        }

        private async void Trips_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new TripsTrapsTrull()));
        }

        private async void Rgb_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Rgb()));
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Entry()));
        }

        private async void Valgusfoor_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Valgusfoor()));
        }

        private async void Clicker_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage (new Clicker()));
        }
    }
}
