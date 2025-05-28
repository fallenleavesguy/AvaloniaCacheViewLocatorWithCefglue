using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaCacheViewLocator.ViewModels;

public partial class WebViewModel2 : ViewModelBase
{
    private string _url = "https://www.google.com";
    
    public string Title => "Web Browser (Cached)";
    
    public string Url 
    { 
        get => _url; 
        set => SetProperty(ref _url, value); 
    }
    
    [RelayCommand]
    public void NavigateToGoogle()
    {
        Url = "https://www.qq.com";
    }
    
    [RelayCommand]
    public void NavigateToTwitter()
    {
        Url = "https://www.twitter.com";
    }
}
