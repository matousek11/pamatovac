using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pamatovac
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            name.Text = "Jméno";
        }

        public MainPage(string name)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.name.Text = name;
        }

        private async void Continue_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WritePage());
        }
    }
}
