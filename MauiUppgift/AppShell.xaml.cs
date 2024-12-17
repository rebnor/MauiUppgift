namespace MauiUppgift
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DogPage), typeof(DogPage));

        }
    }
}
