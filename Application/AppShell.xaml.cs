namespace Glossa_App;

public partial class AppShell : Shell
{
	public AppShell()
	{
        Routing.RegisterRoute(nameof(Views.AuthPage), typeof(Views.AuthPage));
        Routing.RegisterRoute(nameof(Views.SignupPage), typeof(Views.SignupPage));

        InitializeComponent();
	}
}
