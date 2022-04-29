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

            Button Ajaplaan_btn = new Button()
            {
                Text = "Ajaplaan",
                BackgroundColor = Color.LightGreen,
            };
            Ajaplaan_btn.Clicked += Ajaplaan_btn_Clicked;

            Button Horoskop_btn = new Button()
            {
                Text = "Horoskop",
                BackgroundColor = Color.LightGreen,
            };
            Horoskop_btn.Clicked += Horoskop_btn_Clicked;

            Button Maakonnad_btn = new Button()
            {
                Text = "Maakonnad",
                BackgroundColor = Color.LightGreen,
            };
            Maakonnad_btn.Clicked += Maakonnad_btn_Clicked;

            Button Picker_Page_btn = new Button()
            {
                Text = "Webilehed",
                BackgroundColor = Color.LightGreen,
            };
            Picker_Page_btn.Clicked += Picker_Page_btn_Clicked;

            Button Table_Page_btn = new Button()
            {
                Text = "TableView",
                BackgroundColor = Color.LightGreen,
            };
            Table_Page_btn.Clicked += Table_Page_btn_Clicked;

            Button ListView_Page_btn = new Button()
            {
                Text = "ListView",
                BackgroundColor = Color.LightGreen,
            };
            ListView_Page_btn.Clicked += ListView_Page_btn_Clicked;

            StackLayout st = new StackLayout()
            {
                Children = { Ent_btn, Cliker_btn, Valgusfoor_btn, Rgb_btn, Trips_btn, Ajaplaan_btn,
                    Horoskop_btn, Maakonnad_btn, Picker_Page_btn, Table_Page_btn, ListView_Page_btn }
            };

            st.BackgroundColor = Color.LightBlue;
            Content = st;

        }

        private async void ListView_Page_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ListView_Page()));
        }

        private async void Table_Page_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Table_Page()));
        }

        private async void Picker_Page_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Picker_Page()));
        }

        private async void Maakonnad_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Maakonnad()));
        }

        private async void Horoskop_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Horoskop()));
        }

        private async void Ajaplaan_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Ajaplaan()));
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
