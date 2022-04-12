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
           
            Picker1 = new Picker()
            {
                Title = "Уезд"
            };
            Picker1.Items.Add("Harjumaa");
            Picker1.Items.Add("Ida-Virumaa");
            Picker1.Items.Add("Lääne-Virumaa");

            Picker1.Items.Add("Valgamaa");
            Picker1.Items.Add("Viljandimaa");
            Picker1.Items.Add("Võrumaa");
            Picker1.Items.Add("Jõgevamaa");
            Picker1.Items.Add("Läänemaa");
            Picker1.Items.Add("Põlvamaa");
            Picker1.Items.Add("Pärnumaa");
            Picker1.Items.Add("Raplamaa");
            Picker1.Items.Add("Saaremaa");
            Picker1.Items.Add("Tartumaa");
            Picker1.Items.Add("Hiiumaa");
            Picker1.Items.Add("Järvamaa");
            Picker1.SelectedIndexChanged += Picker1_SelectedIndexChanged;



            Picker2 = new Picker()
            {
                Title = "Столица"
            };
            Picker2.Items.Add("Tallinn");
            Picker2.Items.Add("Narva");
            Picker2.Items.Add("Rakvere");

            Picker2.Items.Add("Valga");
            Picker2.Items.Add("Viljandi");
            Picker2.Items.Add("Võru");
            Picker2.Items.Add("Jõgeva");
            Picker2.Items.Add("Haapsalu");
            Picker2.Items.Add("Põlva");
            Picker2.Items.Add("Pärnu");
            Picker2.Items.Add("Rapla");
            Picker2.Items.Add("Kuressaare");
            Picker2.Items.Add("Tartu");
            Picker2.Items.Add("Kärdla");
            Picker2.Items.Add("Paide");
            Picker2.SelectedIndexChanged += Picker2_SelectedIndexChanged;




            image = new Image()
            {
                Source = "none.png"
            };

            label = new Label()
            {
                TextColor = Color.Black,
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

            if (Picker2.SelectedIndex == 0)
            {
                image.Source = "tallinn.jpg";
            }

            else if (Picker2.SelectedIndex == 1)
            {
                image.Source = "narva.jpg";
            }

            else if (Picker2.SelectedIndex == 2)
            {
                image.Source = "rakvere.jpg";
            }

            else if (Picker2.SelectedIndex == 3)
            {
                image.Source = "valga.jpg";
            }

            else if (Picker2.SelectedIndex == 4)
            {
                image.Source = "viljandi.jpg";
            }

            else if (Picker2.SelectedIndex == 5)
            {
                image.Source = "vyru.jpg";
            }

            else if (Picker2.SelectedIndex == 6)
            {
                image.Source = "jygeva.jpg";
            }

            else if (Picker2.SelectedIndex == 7)
            {
                image.Source = "haapsalu.jpg";
            }

            else if (Picker2.SelectedIndex == 8)
            {
                image.Source = "pylva.jpg";
            }

            else if (Picker2.SelectedIndex == 9)
            {
                image.Source = "parnu.jpg";
            }

            else if (Picker2.SelectedIndex == 10)
            {
                image.Source = "rapla.jpg";
            }

            else if (Picker2.SelectedIndex == 11)
            {
                image.Source = "kuressaare.jpg";
            }

            else if (Picker2.SelectedIndex == 12)
            {
                image.Source = "Tartu.jpg";
            }

            else if (Picker2.SelectedIndex == 13)
            {
                image.Source = "kardla.jpg";
            }

            else if (Picker2.SelectedIndex == 14)
            {
                image.Source = "paide.jpg";
            }

        }

        private void Picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker2.SelectedIndex = Picker1.SelectedIndex;
        }
    }
}