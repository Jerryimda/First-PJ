using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace Jerrybaring1.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {

        [RelayCommand]
        private void hamsoo()
        {
            Hamsoo3 = "Winner";
        }
        [RelayCommand]
        private void hamsoo2() 
        {
            Hamsoo3 = "Loser";
        }
        [ObservableProperty]
        string _hamsoo3;
       
    }
}
