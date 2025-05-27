using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaCacheViewLocator.ViewModels;

public partial class FirstViewModel : ViewModelBase
{
    private int _counter = 0;
    
    public string Title => "First View - Grid with Mock Data";
    
    public int Counter
    {
        get => _counter;
        set => SetProperty(ref _counter, value);
    }

    public ObservableCollection<PersonData> People { get; } = new ObservableCollection<PersonData>();
    
    public FirstViewModel()
    {
        // Add mock data
        People.Add(new PersonData { Id = 1, Name = "John Doe", Age = 30, Email = "john.doe@example.com", Department = "Engineering" });
        People.Add(new PersonData { Id = 2, Name = "Jane Smith", Age = 28, Email = "jane.smith@example.com", Department = "Marketing" });
        People.Add(new PersonData { Id = 3, Name = "Bob Johnson", Age = 35, Email = "bob.johnson@example.com", Department = "Finance" });
        People.Add(new PersonData { Id = 4, Name = "Alice Brown", Age = 27, Email = "alice.brown@example.com", Department = "HR" });
        People.Add(new PersonData { Id = 5, Name = "Charlie Davis", Age = 42, Email = "charlie.davis@example.com", Department = "Engineering" });
        People.Add(new PersonData { Id = 6, Name = "Diana Wilson", Age = 31, Email = "diana.wilson@example.com", Department = "Sales" });
        People.Add(new PersonData { Id = 7, Name = "Edward Miller", Age = 25, Email = "edward.miller@example.com", Department = "Support" });
    }
    
    public void IncrementCounter()
    {
        Counter++;
    }

    [RelayCommand]
    public void AddNewPerson()
    {
        var rand = new Random();
        People.Add(new PersonData { 
            Id = People.Count + 1, 
            Name = $"New Person {People.Count + 1}", 
            Age = rand.Next(20, 60), 
            Email = $"person{People.Count + 1}@example.com", 
            Department = "New Hire" 
        });
    }
}

public class PersonData
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
}
