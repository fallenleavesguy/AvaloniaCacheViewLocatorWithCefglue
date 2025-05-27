using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaCacheViewLocator.Views;

public partial class WebView2 : UserControl
{
    public WebView2()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
