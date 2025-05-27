using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaCacheViewLocator.ViewModels;

public class FirstViewModel : ViewModelBase
{
    private int _counter = 0;
    
    public string Title => "First View";
    
    public int Counter
    {
        get => _counter;
        set => SetProperty(ref _counter, value);
    }
    
    public void IncrementCounter()
    {
        Counter++;
    }
}
