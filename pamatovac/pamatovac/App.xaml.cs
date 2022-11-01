using pamatovac.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pamatovac
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            string name = PreferencesService.LoadPreference(Constants.Constants.NAME_PREFERENCES);
            if(name == null)
                MainPage = new NavigationPage(new WritePage());
            else
                MainPage = new NavigationPage(new MainPage(name));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
