using MauiUppgift.ViewModels;

namespace MauiUppgift;

public partial class DogPage : ContentPage
{
	public DogPage(DogViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is DogViewModel viewModel)
        {
            viewModel.ResetState();
        }
    }
}