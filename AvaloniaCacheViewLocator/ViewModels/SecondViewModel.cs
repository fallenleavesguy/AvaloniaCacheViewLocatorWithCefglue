using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaCacheViewLocator.ViewModels;

public class SecondViewModel : ViewModelBase
{
    private string _inputText = string.Empty;
    
    public string Title => "Second View";
    
    public string InputText
    {
        get => _inputText;
        set => SetProperty(ref _inputText, value);
    }
}
