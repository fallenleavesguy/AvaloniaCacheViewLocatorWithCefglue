using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaCacheViewLocator.Views;

public partial class SecondView : UserControl
{
    public SecondView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
