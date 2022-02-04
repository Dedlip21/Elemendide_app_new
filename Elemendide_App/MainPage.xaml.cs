using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendide_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button Ent_btn = new Button
            {
                Text = "Entry",
                BackgroundColor = Color.Fuchsia
            };

            Button Timer_btn = new Button
            {
                Text = "Timer",
                BackgroundColor = Color.Fuchsia
            };

            StackLayout st = new StackLayout
            {
                Children = { Ent_btn, Timer_btn }
            };


            Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;

            st.BackgroundColor = Color.Aqua;
            Content = st;
        }

        private void Timer_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Page());
        }
    }
}
