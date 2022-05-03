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
        EntryCell tel;
        EntryCell email;
        EntryCell nimi;
        EntryCell text;

        Button Helista_btn;
        Button Email_btn;
        Button Sms_btn;
        Button venekeel_btn;
        Button eestikeel_btn;
        public bool b;

        public Table_Page()
        {
            //Var 1
            tel = new EntryCell
            {
                Label = "Telefon:",
                Placeholder = "Sisesta tel. number",
                Keyboard = Keyboard.Telephone
            };

            email = new EntryCell
            {
                Label = "Email:",
                Placeholder = "Sisesta email",
                Keyboard = Keyboard.Email
            };

            nimi = new EntryCell
            {
                Label = "Nimi:",
                Placeholder = "Sisesta oma sõbra nimi",
                Keyboard = Keyboard.Default
            };

            text = new EntryCell
            {
                Label = "Sms tekst:",
                Placeholder = "Sisesta teksti SMS jaoks",
                Keyboard = Keyboard.Default
            };

            tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("Andmete sisestamine/Введение данных")
                {
                    new TableSection("Põhiandmed/Основная информация:")
                    {
                        nimi,
                    },
                    new TableSection("Kontaktandmed/Контакты:")
                    {
                        tel,
                        email,
                    },
                    new TableSection("SMS jaoks/Для СМСа:")
                    {
                        text,
                    },
                },
            };

            Helista_btn = new Button()
            {
                Text = "Helista",
                BackgroundColor = Color.LightGreen,
            };
            Helista_btn.Clicked += Helista_btn_Clicked;

            Email_btn = new Button()
            {
                Text = "Email",
                BackgroundColor = Color.LightGreen,
            };
            Email_btn.Clicked += Email_btn_Clicked;

            Sms_btn = new Button()
            {
                Text = "Sms",
                BackgroundColor = Color.LightGreen,
            };
            Sms_btn.Clicked += Sms_btn_Clicked;

            venekeel_btn = new Button()
            {
                Text = "🇷🇺",
                BackgroundColor = Color.LightGreen,
            };
            venekeel_btn.Clicked += Venekeel_btn_Clicked;

            eestikeel_btn = new Button()
            {
                Text = "🇪🇪",
                BackgroundColor = Color.LightGreen,
            };
            eestikeel_btn.Clicked += Eestikeel_btn_Clicked;

            st = new StackLayout()
            {
                Children = { tableView, Helista_btn, Email_btn, Sms_btn, venekeel_btn, eestikeel_btn }
            };
            Content = st;

            /*if (b == true)
            {
                //tel
                tel.Label = "Телефон:";
                tel.Placeholder = "Введи номер телефона";
                tel.Keyboard = Keyboard.Telephone;

                //email
                email.Label = "Э-почта:";
                email.Placeholder = "Введи Э-почту";
                email.Keyboard = Keyboard.Email;

                //nimi
                nimi.Label = "Имя:";
                nimi.Placeholder = "Введи имя друга";
                nimi.Keyboard = Keyboard.Default;

                //text
                text.Label = "СМС текст:";
                text.Placeholder = "Введи текст для СМСа";
                text.Keyboard = Keyboard.Default;

                //Root
                tableView = new TableView
                {
                    Intent = TableIntent.Form,
                    Root = new TableRoot("Введение данных")
                    {
                        new TableSection("Основная информация:")
                        {
                            nimi,
                        },
                        new TableSection("Контакты:")
                        {
                            tel,
                            email,
                        },
                        new TableSection("Для СМСа:")
                        {
                            text,
                        },
                    },
                };

                //buttons
                Helista_btn.Text = "Позвонить";
                Helista_btn.BackgroundColor = Color.LightGreen;

                Email_btn.Text = "Э-почта";
                Email_btn.BackgroundColor = Color.LightGreen;

                Sms_btn.Text = "СМС";
                Sms_btn.BackgroundColor = Color.LightGreen;

                keel_btn.Text = "Eesti keel";
                keel_btn.BackgroundColor = Color.LightGreen;
            }*/
        }

        private void Eestikeel_btn_Clicked(object sender, EventArgs e)
        {
            b = false;
            //tel
            tel.Label = "Telefon:";
            tel.Placeholder = "Sisesta tel. number";
            tel.Keyboard = Keyboard.Telephone;

            //email
            email.Label = "Email:";
            email.Placeholder = "Sisesta email";
            email.Keyboard = Keyboard.Email;

            //nimi
            nimi.Label = "Nimi:";
            nimi.Placeholder = "Sisesta oma sõbra nimi";
            nimi.Keyboard = Keyboard.Default;

            //text
            text.Label = "SMS tekst:";
            text.Placeholder = "Sisesta teksti SMS jaoks";
            text.Keyboard = Keyboard.Default;

            //Root
            tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("Andmete sisestamine/Введение данных")
                    {
                        new TableSection("Põhiandmed/Основная информация:")
                        {
                            nimi,
                        },
                        new TableSection("Kontaktandmed/Контакты:")
                        {
                            tel,
                            email,
                        },
                        new TableSection("SMS jaoks/Для СМСа:")
                        {
                            text,
                        },
                    },
            };

            //buttons
            Helista_btn.Text = "Helista";
            Helista_btn.BackgroundColor = Color.LightGreen;

            Email_btn.Text = "Email";
            Email_btn.BackgroundColor = Color.LightGreen;

            Sms_btn.Text = "SMS";
            Sms_btn.BackgroundColor = Color.LightGreen;
        }

        private void Venekeel_btn_Clicked(object sender, EventArgs e)
        {
            b = true;
            if(b = true)
            {
                //tel
                tel.Label = "Телефон:";
                tel.Placeholder = "Введи номер телефона";
                tel.Keyboard = Keyboard.Telephone;

                //email
                email.Label = "Э-почта:";
                email.Placeholder = "Введи Э-почту";
                email.Keyboard = Keyboard.Email;

                //nimi
                nimi.Label = "Имя:";
                nimi.Placeholder = "Введи имя друга";
                nimi.Keyboard = Keyboard.Default;

                //text
                text.Label = "СМС текст:";
                text.Placeholder = "Введи текст для СМСа";
                text.Keyboard = Keyboard.Default;

                //Root
                tableView = new TableView
                {
                    Intent = TableIntent.Form,
                    Root = new TableRoot("Введение данных")
                    {
                        new TableSection("Основная информация:")
                        {
                            nimi,
                        },
                        new TableSection("Контакты:")
                        {
                            tel,
                            email,
                        },
                        new TableSection("Для СМСа:")
                        {
                            text,
                        },
                    },
                };

                //buttons
                Helista_btn.Text = "Позвонить";
                Helista_btn.BackgroundColor = Color.LightGreen;

                Email_btn.Text = "Э-почта";
                Email_btn.BackgroundColor = Color.LightGreen;

                Sms_btn.Text = "СМС";
                Sms_btn.BackgroundColor = Color.LightGreen;
            }
            else
            {
                b = false;
            }
        }

        //Eesti
        private void Sms_btn_Clicked(object sender, EventArgs e)
        {
            var smsMessenger = CrossMessaging.Current.SmsMessenger;
            if (b == true)
            {
                if (smsMessenger.CanSendSms)
                    smsMessenger.SendSms("+372" + tel.Text, "Привет, " + nimi.Text + "! " + text.Text);
            }
            else if (b == false)
            {
                if (smsMessenger.CanSendSms)
                    smsMessenger.SendSms("+372" + tel.Text, "Tere, " + nimi.Text + "! " + text.Text);
            }
        }

        private void Email_btn_Clicked(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (b== true)
            {
                if (emailMessenger.CanSendEmail)
                {
                    emailMessenger.SendEmail(email.Text, "Тема: TableView", "Текст..");
                }
            }
            else if(b == false)
            {
                if (emailMessenger.CanSendEmail)
                {
                    emailMessenger.SendEmail(email.Text, "Teema: TableView", "Text..");
                }
            }
        }

        private void Helista_btn_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if(b == true)
            {
                if (phoneDialer.CanMakePhoneCall)
                    phoneDialer.MakePhoneCall("+372" + tel.Text);
            }
            else if(b == false)
            {
                if (phoneDialer.CanMakePhoneCall)
                    phoneDialer.MakePhoneCall("+372" + tel.Text);
            }
        }
    }
}