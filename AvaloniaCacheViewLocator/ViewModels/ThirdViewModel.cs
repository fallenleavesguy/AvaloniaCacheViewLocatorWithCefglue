using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaCacheViewLocator.ViewModels;

public class ThirdViewModel : ViewModelBase
{
    private DateTime _currentTime;
    
    public string Title => "Third View";
    
    public DateTime CurrentTime
    {
        get => _currentTime;
        set => SetProperty(ref _currentTime, value);
    }
    
    public ThirdViewModel()
    {
        CurrentTime = DateTime.Now;
    }
    
    public void UpdateTime()
    {
        CurrentTime = DateTime.Now;
    }
}
