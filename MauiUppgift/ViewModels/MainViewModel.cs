using CommunityToolkit.Mvvm.Input;

namespace MauiUppgift.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        /**
         * Command to navigate to Dog page
         */
        [RelayCommand]
        async Task GotoDog()
        {
            await Shell.Current.GoToAsync($"{nameof(DogPage)}", true);
        }
    }
}
