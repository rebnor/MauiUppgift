using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiUppgift.Models.SunModel;
using MauiUppgift.Services;

namespace MauiUppgift.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private readonly SunService sunService;

        [ObservableProperty]
        private Sun sun;
        [ObservableProperty]
        private DateTime currentDate;
        [ObservableProperty]
        private string sunrise;
        [ObservableProperty]
        private string sunset;

        public MainViewModel(SunService sunService)
        {
            this.sunService = sunService;
            CurrentDate = DateTime.Now;
            InitializeData();
        }

        private async void InitializeData()
        {
            await GetSunInfo();
            ConvertToMilitaryTime();
        }

        async Task GetSunInfo()
        {
            Sun = await sunService.GetSunAsync();
        }

        private void ConvertToMilitaryTime()
        {
            if (Sun?.Results != null)
            {
                Sunrise = ConvertTime(Sun.Results.Sunrise);
                Sunset = ConvertTime(Sun.Results.Sunset);
            }
        }

        private string ConvertTime(string time)
        {
            if (DateTime.TryParse(time, out var parsedTime))
            {
                return parsedTime.ToString("HH:mm");
            }
            return time;
        }

        [RelayCommand]
        async Task GotoDog()
        {
            await Shell.Current.GoToAsync($"{nameof(DogPage)}", true);
        }
    }
}
