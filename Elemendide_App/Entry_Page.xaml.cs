using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendide_App
{
    public partial class Entry_Page : ContentPage
    {
        Label lb;
        public Entry_Page()
        {
            lb = new Label
            {
                Text = "Mingi tekst",
                TextColor = Color.Orange
            };


            Editor ed = new Editor
            {
                Placeholder = "Sisesta siia teksti",
                BackgroundColor = Color.White,
                TextColor = Color.Blue
            };

            Button tagasi = new Button
            {
                Text = "Tagasi"
            };
            tagasi.Clicked += Tagasi_Clicked;


            StackLayout st = new StackLayout();
            {
                Children = { ed, lb, tagasi }
            };

            st.BackgroundColor = Color.Aqua;
            Content = st;
        }

        private async void Tagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
