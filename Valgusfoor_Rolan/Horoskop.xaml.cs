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
            Image image = new Image()
            {
                Source = "none.png"
            };
            DatePicker DPicker = new DatePicker()
            {

            };
            DPicker.DateSelected += DPicker_DateSelected;

            Label label = new Label()
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
            var m = e.NewDate.Month;
            var d = e.NewDate.Day;

            if (m == 1 && d>=1 && d<=20 || m==12 && d>=22)
            {
                label.Text = "По гороскопу ты Козерог";
            }
        }
    }
}