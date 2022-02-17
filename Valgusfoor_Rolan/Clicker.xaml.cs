using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Valgusfoor_Rolan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Clicker : ContentPage
    {
        Label lb;
        Frame frame;

        public Clicker()
        {
            this.BackgroundColor = Color.White;


            Button Buy_btn = new Button()
            {
                Text = "2x booster. Costs 100 points",
                BackgroundColor = Color.LightGreen,
            };
            Buy_btn.Clicked += Buy_btn_Clicked;


            lb = new Label()
            {
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Start

            };

            frame = new Frame()
            {
                BackgroundColor = Color.Red,
                CornerRadius = 1000,
                WidthRequest = 200,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            frame.GestureRecognizers.Add(tap);

            StackLayout st = new StackLayout { Children = { frame, Buy_btn } };
            Content = st;
            st.Children.Add(lb);
        }

        int i = 0;
        bool b = false;
        private void Buy_btn_Clicked(object sender, EventArgs e)
        {
            if (i >= 100)
            {
                i = i - 100;
                b = true;
            }
            else
            {
                b = false;
            }
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            i++;
            lb.Text = "Ты нажал " + i + " раз";

            if (b == true)
            {
                i += 1;
            }


            if (i >= 1)
            {
                try
                {
                    // Use default vibration length
                    Vibration.Vibrate();

                    // Or use specified time
                    var duration = TimeSpan.FromSeconds(0.2);
                    Vibration.Vibrate(duration);
                }
                catch (FeatureNotSupportedException ex)
                {
                    // Feature not supported on device
                }
                catch (Exception ex)
                {
                    // Other error has occurred.
                }
            }
        }
    }
}