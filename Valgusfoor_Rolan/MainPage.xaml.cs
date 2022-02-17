﻿using System;
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

            StackLayout st = new StackLayout()
            {
                Children = { Ent_btn, Cliker_btn, Valgusfoor_btn }
            };

            st.BackgroundColor = Color.LightBlue;
            Content = st;

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