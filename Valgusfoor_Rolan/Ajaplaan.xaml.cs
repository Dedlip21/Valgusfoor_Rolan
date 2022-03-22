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
        Image image;
        public Ajaplaan()
        {
            var underlineLabel = new Label { Text = "This is underlined text.", TextDecorations = TextDecorations.Underline };

            var image = new Image { Source = "krestik.png" };



            TimePicker TPicker = new TimePicker
            {
                Time = new TimeSpan(12, 00, 00) // Time set to "04:15:26"
            };

            StackLayout st = new StackLayout()
            {
                Children = { underlineLabel, image, TPicker }
            };

            st.BackgroundColor = Color.LightBlue;
            Content = st;
        }
        /*private void Tpicker_PropertyChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                var time = tpicker.Time.Hours;
                if(time == 4)
                {
                    entry.Text = "Раннее утро!";
                }
            }
        }*/
    }
}