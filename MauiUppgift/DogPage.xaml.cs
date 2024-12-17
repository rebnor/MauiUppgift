using MauiUppgift.ViewModels;

namespace MauiUppgift;

public partial class DogPage : ContentPage
{
	public DogPage(DogViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}