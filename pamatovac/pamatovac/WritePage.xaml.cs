using pamatovac.Constants;
using pamatovac.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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
            string savedName = PreferencesService.LoadPreference(Constants.Constants.NAME_PREFERENCES);
            if (savedName != null)
                nameEntry.Text = savedName;
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            PreferencesService.SavePreference(Constants.Constants.NAME_PREFERENCES, name);
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = e.NewTextValue;
            PreferencesService.SavePreference(Constants.Constants.NAME_PREFERENCES, name);
        }
    }
}