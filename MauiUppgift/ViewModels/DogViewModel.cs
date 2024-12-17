using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiUppgift.Models;
using MauiUppgift.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiUppgift.ViewModels
{
    public partial class DogViewModel : BaseViewModel
    {
        private readonly DogService dogService;

        [ObservableProperty]
        Dog dog = new();

        [ObservableProperty]
        public string? input;

        public DogViewModel(DogService dogService)
        {
            this.dogService = dogService;
        }

        // TODO: Se över om man ska ha dog-details som popup? och sen en ComparePage?

        [RelayCommand]
        async Task GetDog(string? input)
        {
            if (!string.IsNullOrEmpty(Input))
            {
                var fetchedDog = await dogService.GetDogAsync(Input);
                if (fetchedDog != null)
                {
                    Dog = fetchedDog;
                }
            }
        }

    }
}
