using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace pamatovac.Services
{
    public static class PreferencesService
    {
        public static string LoadPreference(string preference)
        {
            return Preferences.Get(preference, null);
        }
        public static void SavePreference(string preference, string value)
        {
            Preferences.Set(preference, value);
        }
    }
}
