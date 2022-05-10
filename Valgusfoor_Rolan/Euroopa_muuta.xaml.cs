using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Valgusfoor_Rolan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Euroopa_muuta : ContentPage
    {
        public ObservableCollection<Riigid> riigid { get; set; }
        Label lbl_muuta;

        EntryCell nimetus;
        EntryCell pealinn;
        EntryCell rahvaarv;
        EntryCell lipp;

        TableView tableView_muuta;


        public Euroopa_muuta()
        {
            riigid = new ObservableCollection<Riigid>
            {
                new Riigid {Nimetus="Ukraina", Pealinn = "Kiev", Rahvaarv ="44130000", Lipp="ukraina.jpg"},
                new Riigid {Nimetus="Saksamaa", Pealinn = "Berlin", Rahvaarv ="83240000", Lipp="saksamaa.png"},
                new Riigid {Nimetus="Saksamaa", Pealinn = "Berlin", Rahvaarv ="83240000", Lipp="https://maslennikov20.thkit.ee/htdocs/image/Spain.jpg"},
            };



            lbl_muuta = new Label
            {
                Text = "Muuta riik",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            nimetus = new EntryCell
            {
                Label = "Nimetus:",
                Placeholder = "Sisesta nimetus",
                Keyboard = Keyboard.Default
                
            };

            pealinn = new EntryCell
            {
                Label = "Pealinn:",
                Placeholder = "Sisesta pealinn",
                Keyboard = Keyboard.Default,
                Text = Euroopa_riigid.
            };

            rahvaarv = new EntryCell
            {
                Label = "Rahvaarv:",
                Placeholder = "Sisesta rahvaarv",
                Keyboard = Keyboard.Numeric
            };

            lipp = new EntryCell
            {
                Label = "Lipp:",
                Placeholder = "Sisesta lipp kujutise address",
                Keyboard = Keyboard.Url

            };



            tableView_muuta = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("Muuta riik riik")
                {
                    new TableSection("Muuta riik:")
                    {
                        nimetus,
                        pealinn,
                        rahvaarv,
                        lipp,
                    },
                },
            };

            Button muuda = new Button
            {
                Text = "Muuda riik"
            };
            muuda.Clicked += Muuda_Clicked;


            this.Content = new StackLayout { Children = { lbl_muuta, tableView_muuta, muuda } };
        }

        private async void Muuda_Clicked(object sender, EventArgs e)
        {
            if (nimetus.Text == null || pealinn.Text == null || rahvaarv.Text == null /*|| lipp.Text == null*/)
            {
                await DisplayAlert("Viga", "Sisesta väärtused", "OK");
            }
            else
            {
                await DisplayAlert("Nice", "Nice", "OK");
            }
        }
    }
}