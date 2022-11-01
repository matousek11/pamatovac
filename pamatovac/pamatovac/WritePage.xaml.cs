using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pamatovac
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WritePage : ContentPage
    {
        public WritePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;

        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = e.NewTextValue;
        }
    }
}