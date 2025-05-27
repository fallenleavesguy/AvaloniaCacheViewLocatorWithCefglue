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
    }

    private void SetupCaching()
    {
        // Register FirstView for caching
        ViewLocator.RegisterViewForCaching<FirstViewModel>();
        
        // We can also register ThirdView for caching if desired
        // ViewLocator.RegisterViewForCaching<ThirdViewModel>();
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
}