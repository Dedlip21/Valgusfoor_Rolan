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
    public partial class Horoskop : ContentPage
    {

        Image image;
        DatePicker DPicker;
        Label label;
        public Horoskop()
        {
            image = new Image()
            {
                Source = "none.png"
            };
            DPicker = new DatePicker()
            {

            };
            DPicker.DateSelected += DPicker_DateSelected;

            label = new Label()
            {
                Text = "По гороскопу ты..."
            };


            StackLayout st = new StackLayout()
            {
                Children = { image, DPicker, label}
            };

            st.BackgroundColor = Color.LightBlue;
            Content = st;
        }

        private void DPicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            label.TextColor = Color.Black;
            var m = e.NewDate.Month;
            var d = e.NewDate.Day;
            

            if (m == 3 && d >= 21 || m == 4 && d <= 20)
            {
                label.Text = "По гороскопу ты Овен";
                image.Source = "oven.jpg";
            }

            else if (m == 4 && d >= 21 || m == 5 && d <= 21)
            {
                label.Text = "По гороскопу ты Телец";
                image.Source = "telec.jpg";
            }

            else if (m == 5 && d >= 22 || m == 6 && d <= 21)
            {
                label.Text = "По гороскопу ты Близнецы";
                image.Source = "blizneci.jpg";
            }

            else if (m == 6 && d >= 22 || m == 7 && d <= 22)
            {
                label.Text = "По гороскопу ты Рак";
                image.Source = "rak.jpg";
            }

            else if (m == 7 && d >= 23 || m == 8 && d <= 23)
            {
                label.Text = "По гороскопу ты Лев";
                image.Source = "lev.jpg";
            }

            else if (m == 8 && d >= 24 || m == 9 && d <= 22)
            {
                label.Text = "По гороскопу ты Дева";
                image.Source = "deva.jpg";
            }

            else if (m == 9 && d >= 23 || m == 10 && d <= 23)
            {
                label.Text = "По гороскопу ты Весы";
                image.Source = "veso.jpg";
            }

            else if (m == 10 && d >= 24 || m == 11 && d <= 22)
            {
                label.Text = "По гороскопу ты Скорпион";
                image.Source = "skorpion.jpg";
            }

            else if (m == 11 && d >= 23 || m == 12 && d <= 21)
            {
                label.Text = "По гороскопу ты Стрелец";
                image.Source = "strelec.jpg";
            }

            if (m == 1 && d >= 1 && d <= 20 || m == 12 && d >= 22)
            {
                label.Text = "По гороскопу ты Козерог";
                image.Source = "kozerog.jpg";
            }

            else if (m == 1 && d >= 21 || m == 2 && d <= 18)
            {
                label.Text = "По гороскопу ты Водолей";
                image.Source = "vodolei.jpeg";
            }

            else if (m == 2 && d >= 19 || m == 3 && d <= 20)
            {
                label.Text = "По гороскопу ты Рыбы";
                image.Source = "ryby.jpg";
            }
        }
    }
}