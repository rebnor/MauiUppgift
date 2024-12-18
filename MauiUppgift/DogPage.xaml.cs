using MauiUppgift.ViewModels;

namespace MauiUppgift;

public partial class DogPage : ContentPage
{
	public DogPage(DogViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}


    /**
     * Resets the properties Input, Message and Dog-list.
     */
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is DogViewModel viewModel)
        {
            viewModel.ResetState();
        }
    }
}