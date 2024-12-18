using CommunityToolkit.Mvvm.ComponentModel;
using MauiUppgift.Models;
using MauiUppgift.Services;

namespace MauiUppgift.ViewModels
{
    [QueryProperty("Dog", "Dog")]
    public partial class DetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        Dog dog = new();
    }
}
