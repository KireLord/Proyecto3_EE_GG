using Newtonsoft.Json;
using SignInAndSignUpUI;
using SignInAndSignUpUI.Views;

namespace Proyecto2_EE_GG.Views;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();

		NavigationPage.SetHasNavigationBar(this, false);
    }
    private async void AdopcionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AdopcionesApi());
    }
}