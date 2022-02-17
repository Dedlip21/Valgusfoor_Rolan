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
    public partial class Entry : ContentPage
    {
        Editor editor;
        Label lb;
        public Entry()
        {
            //InitializeComponent();
            //StackLayout st = new StackLayout();
            editor = new Editor()
            {
                Placeholder = "Sisesta siis teksti",
                BackgroundColor = Color.Gray,
                TextColor = Color.Blue
            };

            editor.TextChanged += Ed_TextChanged;

            lb = new Label()
            {
                Text = "Mingi tekst",
                TextColor = Color.Orange
            };

            StackLayout st = new StackLayout()
            {
                Children = { editor, lb }
            };

            st.Children.Add(editor);
            st.Children.Add(lb);

            st.BackgroundColor = Color.LightBlue;
            Content = st;
        }
        int i = 0;
        int a = 0;
        private void Ed_TextChanged(object sender, TextChangedEventArgs e)
        {
            editor.TextChanged -= Ed_TextChanged;
            char key = e.NewTextValue?.LastOrDefault() ?? ' ';

            if (key == 'A')
            {
                i++;
                lb.Text = key.ToString() + ": " + i;
            }
            /*else if (lb.Text == )
            {
                a++;
                lb.Text = lb.ToString() + ": " + a;
            }
            ed.TextChanged += Ed_TextChanged;*/

        }
    }
}