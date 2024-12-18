using CommunityToolkit.Mvvm.ComponentModel;
using MauiUppgift.Models;
using MauiUppgift.Services;

namespace MauiUppgift.ViewModels
{
    [QueryProperty("Dog", "Dog")]
    public partial class DetailViewModel : BaseViewModel
    {
        private readonly DogService dogService;

        [ObservableProperty]
        Dog dog = new();

        public DetailViewModel(DogService dogService)
        {
            this.dogService = dogService;
        }

        
    }
}
