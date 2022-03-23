using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WeatherApp.Views
{
    public partial class ContoleWeatherview : UserControl
    {
        public ContoleWeatherview()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
