using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum.Models
{
    public partial class Settings : ObservableObject
    {
        private static Settings _instance = new Settings();
        public static Settings Instance => _instance ??= new Settings();

        [ObservableProperty]
        private ThemeOptions _CurrentTheme = ThemeOptions.Light;
    }

    public enum ThemeOptions
    {
        Light = 0,
        Dark = 1,
    }
}
