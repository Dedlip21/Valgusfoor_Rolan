﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Valgusfoor_Rolan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView_Page : ContentPage
    {
        public List<Telefon> telefons { get; set; }
        public List<Telefon> pilt { get; set; }
        Label lbl_list;
        ListView list;

        public ListView_Page()
        {
            //InitializeComponent();
            //Telefonid = new string[] { "iPhone 13", "Samsung Glaxy S9", "Huawei P10", "LG G6" };

            telefons = new List<Telefon>
            {
                new Telefon {Nimetus="Samsung Galaxy 22 Ultra", Tootja = "Samsung", Hind =1349},
                new Telefon {Nimetus="Xiaomi M1 11 Lite 5G NE", Tootja = "Xiaomi", Hind =399},
                new Telefon {Nimetus="Xiaomi M1 11 Lite 5G", Tootja = "Xiaomi", Hind =399},
                new Telefon {Nimetus="iPhone 13", Tootja = "Apple", Hind =1179}
            };

            pilt = new List<Telefon>
            {

            };

            lbl_list = new Label
            {
                Text = "Telefonide loetelu",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            list = new ListView
            {
                HasUnevenRows = true,
                ItemsSource = telefons,
                ItemTemplate = new DataTemplate(() =>
                {
                    ImageCell imageCell = new ImageCell { TextColor = Color.Red, DetailColor = Color.Green };
                    imageCell.SetBinding(ImageCell.TextProperty, "Nimetus");
                    Binding companyBinding = new Binding { Path = "Tootja", StringFormat = "Tore telefon" };
                    imageCell.SetBinding(ImageCell.DetailProperty, companyBinding);
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "Pilt");
                    return imageCell;


                    Label nimetus = new Label { FontSize = 20 };
                    nimetus.SetBinding(Label.TextProperty, "Nimetus");

                    Label tootja = new Label();
                    tootja.SetBinding(Label.TextProperty, "Tootja");

                    Label hind = new Label();
                    hind.SetBinding(Label.TextProperty, "Hind");

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Vertical,
                            Children = { nimetus, tootja, hind }
                        }
                    };
                })
            };

            list.ItemTapped += List_ItemTapped;

            this.Content = new StackLayout { Children = { lbl_list, list } };
        }

        private async void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Telefon selectedPhone = e.Item as Telefon;
            if (selectedPhone != null)
            {
                await DisplayAlert("Выбранная модель", $"{selectedPhone.Tootja} - {selectedPhone.Nimetus}", "OK");
            }
        }
    }
}