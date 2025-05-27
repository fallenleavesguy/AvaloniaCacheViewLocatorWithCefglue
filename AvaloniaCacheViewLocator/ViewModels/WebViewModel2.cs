using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaCacheViewLocator.ViewModels;

public partial class WebViewModel2 : ViewModelBase
{
    private string _url = "https://www.qq.com";
    
    public string Title => "Chinese Web Browser (Cached)";
    
    public string Url 
    { 
        get => _url; 
        set => SetProperty(ref _url, value); 
    }
    
    [RelayCommand]
    public void NavigateToQQ()
    {
        Url = "https://www.qq.com";
    }
    
    [RelayCommand]
    public void NavigateTo163()
    {
        Url = "https://www.163.com";
    }
    
    [RelayCommand]
    public void NavigateToSina()
    {
        Url = "https://www.sina.com.cn";
    }
}
