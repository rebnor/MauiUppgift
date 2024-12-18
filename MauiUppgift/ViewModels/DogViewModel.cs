using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiUppgift.Models;
using MauiUppgift.Services;
using System.Collections.ObjectModel;

namespace MauiUppgift.ViewModels
{
    public partial class DogViewModel : BaseViewModel
    {
        private readonly DogService dogService;

        [ObservableProperty]
        Dog dog = new();

        [ObservableProperty]
        ObservableCollection<Dog> dogs = new ObservableCollection<Dog>();

        [ObservableProperty]
        public string? input;

        [ObservableProperty]
        public string? message;

        public DogViewModel(DogService dogService)
        {
            this.dogService = dogService;
        }

        /**
         * Command to get the Dogs that contains the 'input' in its Name.
         * The API contains some doubles.
         * Uses Message to write out fail-messages to user.
         */
        [RelayCommand]
        async Task GetDog(string? input)
        {
            if (!string.IsNullOrEmpty(Input))
            {
                Dogs.Clear();
                var fetchedDogs = await dogService.GetDogAsync(Input);
                if (fetchedDogs != null)
                {
                    Dogs.Add(fetchedDogs[0]);
                    foreach (var dog in fetchedDogs)
                    {
                        if (!Dogs.Contains(dog)) // ej dubblett
                        {
                            Dogs.Add(dog);
                        }
                    }
                }
                else
                {
                    Message = $"Couldn't find race '{Input}'. Check spelling and try again!";
                }
                Input = null;
            }
            else {
                Message = "You have to write something...";
            }
        }

        /**
         * Command to navigate to DetailPage for the chosen object/dog
         */
        [RelayCommand]
        async Task GotoDetail(Dog dog) {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}", true, new Dictionary<string, object> { { "Dog", dog } });
        }

        /**
         * Resets the properties Input, Message and Dogs-list.
         */
        public void ResetState()
        {
            Input = null;
            Dogs.Clear();
            Message = null;
        }

    }
}
