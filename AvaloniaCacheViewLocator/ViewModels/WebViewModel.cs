using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaCacheViewLocator.ViewModels;

public partial class WebViewModel : ViewModelBase
{
    private string _url = "https://www.bing.com";
    
    public string Title => "Web Browser (Cached)";
    
    public string Url 
    { 
        get => _url; 
        set => SetProperty(ref _url, value); 
    }
    
    [RelayCommand]
    public void NavigateToGoogle()
    {
        Url = "https://www.google.com";
    }
    
    [RelayCommand]
    public void NavigateToBing()
    {
        Url = "https://www.bing.com";
    }
    
    [RelayCommand]
    public void NavigateToBaidu()
    {
        Url = "https://www.baidu.com";
    }
}
