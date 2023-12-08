using Avalonia.Controls;
using Quantum.Models;

namespace Quantum.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Add version to application name
            Title = $"{AppProperties.AppName} - {AppProperties.AppVersion}";

            // Set default width/height
            Width = AppProperties.kDefaultWidth;
            Height = AppProperties.kDefaultHeight;

            InitializeComponent();
        }
    }
}