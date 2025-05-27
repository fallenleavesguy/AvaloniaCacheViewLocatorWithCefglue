using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using AvaloniaCacheViewLocator.ViewModels;

namespace AvaloniaCacheViewLocator;

public class ViewLocator : IDataTemplate
{
    // Dictionary to cache views 
    private static Dictionary<string, Control> _cachedViews = new Dictionary<string, Control>();
    
    // List of view types that should be cached
    private static HashSet<string> _viewTypesToCache = new HashSet<string>();
    
    // Register a view type to be cached
    public static void RegisterViewForCaching<TViewModel>() where TViewModel : ViewModelBase
    {
        var viewModelName = typeof(TViewModel).FullName!;
        _viewTypesToCache.Add(viewModelName);
    }
    
    public Control? Build(object? data)
    {
        if (data is null)
            return null;

        var viewModelName = data.GetType().FullName!;
        var viewName = viewModelName.Replace("ViewModel", "View", StringComparison.Ordinal);
        var viewType = Type.GetType(viewName);

        // If the view type is registered for caching and we have a cached instance, use it
        if (_viewTypesToCache.Contains(viewModelName) && _cachedViews.ContainsKey(viewModelName))
        {
            var cachedControl = _cachedViews[viewModelName];
            // cachedControl.DataContext = data;
            return cachedControl;
        }
        
        // Otherwise create a new view
        if (viewType != null)
        {
            var control = (Control)Activator.CreateInstance(viewType)!;
            control.DataContext = data;
            
            // If this view type should be cached, add it to the cache
            if (_viewTypesToCache.Contains(viewModelName))
            {
                _cachedViews[viewModelName] = control;
            }
            
            return control;
        }

        return new TextBlock { Text = "Not Found: " + viewName };
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}