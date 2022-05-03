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
        ListView list;

        TableView tableView;

        EntryCell nimetus;
        EntryCell pealinn;
        EntryCell rahvaarv;
        EntryCell lipp;

        public Euroopa_riigid()
        {
            
            //InitializeComponent();

            riigid = new ObservableCollection<Riigid>
            {
                new Riigid {Nimetus="Ukraina", Pealinn = "Kiev", Rahvaarv ="44130000", Lipp="ukraina.jpg"},
                new Riigid {Nimetus="Saksamaa", Pealinn = "Berlin", Rahvaarv ="83240000", Lipp="saksamaa.png"},
            };

            lbl_list = new Label
            {
                Text = "Riigid",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
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
                Placeholder = "Sisesta lipp pildi",
                Keyboard = Keyboard.Url

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
                        lipp
                    },
                },
            };

            //--------------------------------//

            Button lisa = new Button 
            {
                Text = "Lisa riik" 
            };
            lisa.Clicked += Lisa_Clicked;


            this.Content = new StackLayout { Children = { lbl_list, list, tableView, lisa } };
        }

        private async void Lisa_Clicked(object sender, EventArgs e)
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

        private async void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Riigid selectedRiik = e.Item as Riigid;
            if (selectedRiik != null)
            {
                await DisplayAlert("Valitud riik", $"{selectedRiik.Nimetus} - {selectedRiik.Pealinn}", "OK");
            }
        }
    }
}