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
                    Console.Write($"-------> No dogs found for input: {Input}");
                }
                Console.WriteLine($"---------> Dogs count: {Dogs.Count}");
                Input = null;
            }
            else {
                Message = "You have to write something...";
            }
        }

        [RelayCommand]
        async Task GotoDetail(Dog dog) {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}", true, new Dictionary<string, object> { { "Dog", dog } });
        }

        public void ResetState()
        {
            Input = null;
            Dogs.Clear();
            Message = null;
            Console.WriteLine("----> ResetState called: Input & Message cleared, Dogs-list emptied.");
        }

    }
}
