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
    public partial class Maakonnad : ContentPage
    {
        Picker Picker1;
        Picker Picker2;

        Image image;
        Label label;
        public Maakonnad()
        {
            Picker Picker1 = new Picker()
            {
                Title = "Уезд"
            };
            Picker1.Items.Add("Harjumaa");
            Picker1.SelectedIndexChanged += Picker1_SelectedIndexChanged;



            Picker Picker2 = new Picker()
            {
                Title = "Столица"
            };
            Picker2.Items.Add("Tallinn");
            Picker2.SelectedIndexChanged += Picker2_SelectedIndexChanged;




            Image image = new Image()
            {
                Source = "none.png"
            };

            Label label = new Label()
            {
                Text = ": )"
            };

            StackLayout st = new StackLayout()
            {
                Children = { Picker1, Picker2, image, label }
            };

            st.BackgroundColor = Color.LightBlue;
            Content = st;
        }

        private void Picker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker1.SelectedIndex = Picker2.SelectedIndex;
        }

        private void Picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker2.SelectedIndex = Picker1.SelectedIndex;
        }
    }
}