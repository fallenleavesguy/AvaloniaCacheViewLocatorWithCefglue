using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaCacheViewLocator.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _currentViewModel;
    
    public ViewModelBase CurrentViewModel 
    { 
        get => _currentViewModel; 
        set => SetProperty(ref _currentViewModel, value); 
    }
    
    public MainWindowViewModel()
    {
        // Initialize with First View by default
        CurrentViewModel = new FirstViewModel();
        
        // Initialize commands
        ShowFirstViewCommand = new RelayCommand(() => CurrentViewModel = new FirstViewModel());
        ShowSecondViewCommand = new RelayCommand(() => CurrentViewModel = new SecondViewModel());
        ShowThirdViewCommand = new RelayCommand(() => CurrentViewModel = new ThirdViewModel());
    }
    
    public RelayCommand ShowFirstViewCommand { get; }
    public RelayCommand ShowSecondViewCommand { get; }
    public RelayCommand ShowThirdViewCommand { get; }
}
