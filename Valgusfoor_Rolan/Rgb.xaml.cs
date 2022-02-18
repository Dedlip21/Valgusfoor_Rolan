using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Valgusfoor_Rolan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rgb : ContentPage
    {
        Frame frame;
        Slider redSlider;
        Slider greenSlider;
        Slider blueSlider;

        Label redLabel;
        Label greenLabel;
        Label blueLabel;

        Button rnd_btn;
        public Rgb()
        {
            frame = new Frame()
            {
                BackgroundColor = Color.Black,
                CornerRadius = 0,
                WidthRequest = 350,
                HeightRequest = 350,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            redSlider = new Slider()
            {
                Maximum = 255
            };
            redSlider.ValueChanged += OnSliderValueChanged;
            redLabel = new Label()
            {

            };

            greenSlider = new Slider()
            {
                Maximum = 255
            };
            greenSlider.ValueChanged += OnSliderValueChanged;
            greenLabel = new Label()
            {
                 
            };

            blueSlider = new Slider()
            {
                Maximum = 255
            };
            blueSlider.ValueChanged += OnSliderValueChanged;
            blueLabel = new Label()
            {

            };

            rnd_btn = new Button
            {
                Text = "Random color",
            };
            rnd_btn.Clicked += Rnd_btn_Clicked;


            StackLayout st = new StackLayout()
            {
                Children = { frame, redSlider, redLabel, greenSlider, greenLabel, blueSlider, blueLabel, rnd_btn }
            };

            /*st.Children.Add(frame);

            st.Children.Add(redSlider);
            st.Children.Add(redLabel);

            st.Children.Add(greenSlider);
            st.Children.Add(greenLabel);

            st.Children.Add(blueSlider);
            st.Children.Add(blueLabel);*/

            st.BackgroundColor = Color.LightBlue;
            Content = st;
        }

        private async void Rnd_btn_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();

            //frame.BackgroundColor = Color.FromRgba(255, random.Next(256), random.Next(256), random.Next(256));

            redSlider.Value = random.Next(255);
            greenSlider.Value = random.Next(255);
            blueSlider.Value = random.Next(255);
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            if (sender == redSlider)
            {
                redLabel.Text = String.Format("Red = {0:X2}", (int)args.NewValue);
            }
            else if (sender == greenSlider)
            {
                greenLabel.Text = String.Format("Green = {0:X2}", (int)args.NewValue);
            }
            else if (sender == blueSlider)
            {
                blueLabel.Text = String.Format("Blue = {0:X2}", (int)args.NewValue);
            }

            frame.BackgroundColor = Color.FromRgb((int)redSlider.Value,
                                          (int)greenSlider.Value,
                                          (int)blueSlider.Value);
        }
    }
}