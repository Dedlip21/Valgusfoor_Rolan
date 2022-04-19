using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Messaging;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Valgusfoor_Rolan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Table_Page : ContentPage
    {
        TableView tableView;
        SwitchCell sc;
        ImageCell ic;
        TableSection fotosection;
        StackLayout st;

        public Table_Page()
        {
            //Var 1
            tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("Andmete sisestamine")
                {
                    new TableSection("Põhiandmed:")
                    {
                        new EntryCell
                        {
                            Label = "Nimi:",
                            Placeholder = "Sisesta oma sõbra nimi",
                            Keyboard = Keyboard.Default
                        }
                    },
                    new TableSection("Kontaktandmed:")
                    {
                        new EntryCell
                        {
                            Label = "Telefon:",
                            Placeholder = "Sisesta tel. number",
                            Keyboard = Keyboard.Telephone
                        },
                        new EntryCell
                        {
                            Label = "Email:",
                            Placeholder = "Sisesta email",
                            Keyboard = Keyboard.Email
                        },
                    },
                },
            };

            Button Helista_btn = new Button()
            {
                Text = "Helista",
                BackgroundColor = Color.LightGreen,
            };
            Helista_btn.Clicked += Helista_btn_Clicked;

            Button Email_btn = new Button()
            {
                Text = "Email",
                BackgroundColor = Color.LightGreen,
            };
            Email_btn.Clicked += Email_btn_Clicked;

            Button Sms_btn = new Button()
            {
                Text = "Sms",
                BackgroundColor = Color.LightGreen,
            };
            Sms_btn.Clicked += Sms_btn_Clicked;

            st = new StackLayout()
            {
                Children = { tableView, Helista_btn, Email_btn, Sms_btn }
            };
            Content = st;


            //-----------------------------------------





            //Var 2------------------------------------------------------------------------------------------
            /*sc = new SwitchCell { Text = "Näita veel" };
            sc.OnChanged += Sc_OnChanged;

            ic = new ImageCell
            {
                ImageSource = ImageSource.FromFile("krestik.png"),
                Text = "Foto nimetus",
                Detail = "Foto kirjeldus"
            };
            fotosection = new TableSection();

            new TableSection("Kontaktandmed:")
            {
                new EntryCell
                {
                    Label="Telefon:",
                    Placeholder="Sisesta tel. number",
                    Keyboard=Keyboard.Telephone
                },
                new EntryCell
                {
                    Label="Email:",
                    Placeholder="Sisesta email",
                    Keyboard=Keyboard.Email
                },
                sc
            };*/
            //fotosection
            //-------------------------------------------------

        }

        private void Sms_btn_Clicked(object sender, EventArgs e)
        {
            var smsMessenger = CrossMessaging.Current.SmsMessenger;
            if (smsMessenger.CanSendSms)
                smsMessenger.SendSms("+37258370785", "Hello World!");
        }

        private void Email_btn_Clicked(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail("rolik2109@gmail.com", "Theme: TableView", "Text..");
            }
        }

        private void Helista_btn_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall("+37258370785");
        }

        /*private void Sc_OnChanged(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                fotosection.Title = "Foto:";
                fotosection.Add(ic);
                sc.Text = "Peida";
            }
            else
            {
                fotosection.Title = "";
                fotosection.Remove(ic);
                sc.Text = "Näita veel";
            }
        }*/
    }
}