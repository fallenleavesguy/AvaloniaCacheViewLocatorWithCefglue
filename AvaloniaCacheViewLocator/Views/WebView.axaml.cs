using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaCacheViewLocator.Views;

public partial class WebView : UserControl
{
    public WebView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
