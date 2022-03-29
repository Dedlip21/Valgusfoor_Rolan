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
    public partial class Ajaplaan : ContentPage
    {
        Label underlineLabel;
        Image image;
        TimePicker TPicker;
        public Ajaplaan()
        {
            Label underlineLabel = new Label { Text = "This is underlined text.", TextDecorations = TextDecorations.Underline };

            Image image = new Image { Source = "night1.jpg" };



            TimePicker TPicker = new TimePicker
            {
                Time = new TimeSpan(00, 00, 00) // Time set to "00:00:00"
            };
            TPicker.PropertyChanged += TPicker_PropertyChanged;

            StackLayout st = new StackLayout()
            {
                Children = { underlineLabel, image, TPicker }
            };

            st.BackgroundColor = Color.LightBlue;
            Content = st;
        }

        private void TPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                int time = TPicker.Time.Hours;
                if (time >= 0  && time <= 1)
                {
                    underlineLabel.Text = "Глубокая ночь!";
                    image.Source = "night1.jpg";

                }
                else if (time >= 2 && time <= 3)
                {
                    underlineLabel.Text = "Глубокая ночь!";
                    image.Source = "night2.jpg";

                }
                else if (time >= 4 && time <= 5)
                {
                    underlineLabel.Text = "Ночь!";
                    image.Source = "night3.jpg";

                }
                else if (time >= 6 && time <= 7)
                {
                    underlineLabel.Text = "Раннее утро!";
                    image.Source = "sunrise.png";

                }
                else if (time >= 8 && time <= 9)
                {
                    underlineLabel.Text = "Раннее утро!";
                    image.Source = "sunrise2.png";

                }
                else if (time >= 10 && time <= 11)
                {
                    underlineLabel.Text = "Утро!";
                    image.Source = "sunrise3.png";

                }
                else if (time >= 12 && time <= 13)
                {
                    underlineLabel.Text = "Полдень!";
                    image.Source = "sun1.png";

                }
                else if (time >= 14 && time <= 15)
                {
                    underlineLabel.Text = "Полдень!";
                    image.Source = "sun2.png";

                }
                else if (time >= 16 && time <= 17)
                {
                    underlineLabel.Text = "Полдень!";
                    image.Source = "sun3.png";

                }
                else if (time >= 18 && time <= 19)
                {
                    underlineLabel.Text = "Вечер!";
                    image.Source = "sunset1.jpg";

                }
                else if (time >= 20 && time <= 21)
                {
                    underlineLabel.Text = "Вечер!";
                    image.Source = "sunset2.jpg";

                }
                else if (time >= 22 && time <= 23)
                {
                    underlineLabel.Text = "Вечер!";
                    image.Source = "sunset3.jpg";

                }
            }
        }
    }
}