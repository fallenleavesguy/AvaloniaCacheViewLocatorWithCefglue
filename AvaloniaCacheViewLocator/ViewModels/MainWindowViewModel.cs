using CommunityToolkit.Mvvm.Input;

namespace AvaloniaCacheViewLocator.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _currentView;

    public ViewModelBase CurrentView
    {
        get => _currentView;
        private set => SetProperty(ref _currentView, value);
    }

    public MainWindowViewModel()
    {
        // Initialize with the first view
        _currentView = new FirstViewModel();
        
        // Register views for caching
        SetupCaching();
    }    private void SetupCaching()
    {
        // Register FirstView for caching
        ViewLocator.RegisterViewForCaching<FirstViewModel>();
        
        // ViewLocator.RegisterViewForCaching<SecondViewModel>();
        // We can also register ThirdView for caching if desired
        // ViewLocator.RegisterViewForCaching<ThirdViewModel>();
        
        // Register WebView for caching to maintain browser state
        ViewLocator.RegisterViewForCaching<WebViewModel>();
        
        ViewLocator.RegisterViewForCaching<WebViewModel2>();
    }

    [RelayCommand]
    public void NavigateToFirst()
    {
        CurrentView = new FirstViewModel();
    }

    [RelayCommand]
    public void NavigateToSecond()
    {
        CurrentView = new SecondViewModel();
    }

    [RelayCommand]
    public void NavigateToThird()
    {
        CurrentView = new ThirdViewModel();
    }
    
    [RelayCommand]
    public void NavigateToWeb()
    {
        CurrentView = new WebViewModel();
    }
    
    [RelayCommand]
    public void NavigateToWeb2()
    {
        CurrentView = new WebViewModel2();
    }
}