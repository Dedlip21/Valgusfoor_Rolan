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
    public partial class Euroopa_riigid : ContentPage
    {
        public ObservableCollection<Riigid> riigid { get; set; }

        Label lbl_list;
        Label lbl_kustutamine;
        Label lbl_muuda;

        ListView list;

        TableView tableView;

        EntryCell nimetus;
        EntryCell pealinn;
        EntryCell rahvaarv;
        EntryCell lipp;

        Switch sw;
        Switch sw2;

        Uri img;
        bool b;
        bool m;

        public Euroopa_riigid()
        {
            b = false;

            //img = new Uri("https://aka.ms/campus.jpg");

            riigid = new ObservableCollection<Riigid>
            {

                new Riigid {Nimetus="Ukraina", Pealinn = "Kiev", Rahvaarv ="44130000", Lipp="ukraina.jpg"},
                new Riigid {Nimetus="Saksamaa", Pealinn = "Berlin", Rahvaarv ="83240000", Lipp="saksamaa.png"},
                new Riigid {Nimetus="Saksamaa", Pealinn = "Berlin", Rahvaarv ="83240000", Lipp="https://maslennikov20.thkit.ee/htdocs/image/Spain.jpg"},
            };

            lbl_list = new Label
            {
                Text = "Riigid",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            lbl_kustutamine = new Label
            {
                Text = "Kustutamine: Off",
                HorizontalOptions = LayoutOptions.Start,
            };

            lbl_muuda = new Label
            {
                Text = "Muutmine: Off",
                HorizontalOptions = LayoutOptions.Start,
            };

            list = new ListView
            {
                Footer = DateTime.Now.ToString("T"),

                HasUnevenRows = true,
                ItemsSource = riigid,
                ItemTemplate = new DataTemplate(() =>
                {
                    ImageCell imageCell = new ImageCell { TextColor = Color.Red, DetailColor = Color.Green };
                    imageCell.SetBinding(ImageCell.TextProperty, "Nimetus");

                    /*Binding pealinnBinding = new Binding { Path = "Pealinn", StringFormat = "Pealinn on {0}" };
                    imageCell.SetBinding(ImageCell.DetailProperty, pealinnBinding);*/

                    Binding rahvaarvBinding = new Binding { Path = "Rahvaarv", StringFormat = "Inimeste arv on {0}" };
                    imageCell.SetBinding(ImageCell.DetailProperty, rahvaarvBinding);
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "Lipp");

                    return imageCell;


                    Label nimetus = new Label { FontSize = 20 };
                    nimetus.SetBinding(Label.TextProperty, "Nimetus");

                    Label pealinn = new Label();
                    pealinn.SetBinding(Label.TextProperty, "Pealinn");

                    Label rahvaarv = new Label();
                    rahvaarv.SetBinding(Label.TextProperty, "Rahvaarv");

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Vertical,
                            Children = { nimetus, pealinn, rahvaarv }
                        }
                    };
                })
            };
            list.ItemTapped += List_ItemTapped;

            //Tableview---------------//
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
                Keyboard = Keyboard.Default
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
                Keyboard = Keyboard.Url,

            };


            tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("Lisa riik")
                {
                    new TableSection("Sisesta riik:")
                    {
                        nimetus, 
                        pealinn,
                        rahvaarv,
                        lipp,
                    },
                },
            };

            //--------------------------------//

            Button lisa = new Button 
            {
                Text = "Lisa riik" 
            };
            lisa.Clicked += Lisa_Clicked;

            Button muuda = new Button
            {
                Text = "Muuda riik"
            };
            muuda.Clicked += Muuda_Clicked;

            sw = new Switch
            {
                IsToggled = false,
                OnColor = Color.Orange,
                ThumbColor = Color.Green,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.EndAndExpand,
            };
            sw.Toggled += Sw_Toggled;

            sw2 = new Switch
            {
                IsToggled = false,
                OnColor = Color.Orange,
                ThumbColor = Color.Green,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.EndAndExpand,
            };
            sw2.Toggled += Sw2_Toggled;



            this.Content = new StackLayout { Children = { lbl_list, lbl_kustutamine, sw, lbl_muuda, sw2, list, tableView, lisa, muuda} };
        }

        private async void Muuda_Clicked(object sender, EventArgs e)
        {
            Riigid riik = list.SelectedItem as Riigid;
            if (m == true)
            {
                await Navigation.PushAsync(new Euroopa_muuta());
            }
            else if (m == false)
            {
                await DisplayAlert("Muutmise viga", "Muutmisnupp pole lubatud", "OK");
            }
        }

        private void Sw2_Toggled(object sender, ToggledEventArgs e)
        {
            if (sw2.IsToggled == false)
            {
                m = false;
                lbl_muuda.Text = "Muutmine: Off";
            }

            if (sw2.IsToggled == true)
            {
                m = true;
                lbl_muuda.Text = "Muutmine: On";
            }
        }

        private async void Sw_Toggled(object sender, ToggledEventArgs e)
        {
            if (sw.IsToggled == true)
            {
                b = true;
                lbl_kustutamine.Text = "Kustutamine: On";
            }

            if (sw.IsToggled == false)
            {
                b = false;
                lbl_kustutamine.Text = "Kustutamine: Off";
            }
        }

        private async void Lisa_Clicked(object sender, EventArgs e)
        {
            /*if (nimetus.Text == null || pealinn.Text == null || rahvaarv.Text == null)
            {
                await DisplayAlert("Viga", "Sisesta väärtused", "OK");
            }
            else
            {
                riigid.Add(new Riigid { Nimetus = nimetus.Text, Pealinn = pealinn.Text, Rahvaarv = rahvaarv.Text, Lipp = lipp.Text });
            }*/

            if (m == false)
            {
                if (nimetus.Text == null || pealinn.Text == null || rahvaarv.Text == null)
                {
                    await DisplayAlert("Viga", "Sisesta väärtused", "OK");
                }
                else
                {
                    riigid.Add(new Riigid { Nimetus = nimetus.Text, Pealinn = pealinn.Text, Rahvaarv = rahvaarv.Text, Lipp = lipp.Text });
                }
            }
            else if(m == true)
            {
                await DisplayAlert("Viga", "Lülitage muutmisrežiim välja", "OK");
            }

        }

        private async void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Riigid selectedRiik = e.Item as Riigid;    
            if (b == false && m == false)
            {
                if (selectedRiik != null)
                {
                    await DisplayAlert("Valitud riik", $"{selectedRiik.Nimetus} - {selectedRiik.Pealinn}", "OK");
                }
            }

            Riigid riik = list.SelectedItem as Riigid;
            if (b == true && m == false)
            {

                if(riik != null)
                {
                    riigid.Remove(riik);
                    list.SelectedItem = null;
                }
            }

            if(m == true && b == false)
            {
                if (selectedRiik != null)
                {

                }
            }
        }
    }
}