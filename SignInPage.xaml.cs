using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;


namespace SignInAndSignUpUI
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        //Conexion con la api mediante el boton que esta en la pantalla de inicio de sesion
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            // Aqu� puedes crear un objeto para representar los datos de inicio de sesi�n
            var loginData = new { Username = username, Password = password };

            // Convertir el objeto a formato JSON
            var json = JsonConvert.SerializeObject(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Realizar la solicitud POST al endpoint de inicio de sesi�n de tu API
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync("https://localhost:7256/api/Registro", content);

                if (response.IsSuccessStatusCode)
                {

                    // La solicitud fue exitosa, puedes redirigir a la p�gina de inicio o realizar otras acciones necesarias
                    await DisplayAlert("Inicio de Sesi�n Exitoso", "Bienvenido!", "OK");
                    // Redirige a la p�gina de inicio (HomePage)
                    await Navigation.PushAsync(new Proyecto2_EE_GG.Views.HomeView());
                }
                else
                {
                    // Mostrar mensaje de error si el inicio de sesi�n fue inv�lido
                    await DisplayAlert("Error", "Credenciales inv�lidas", "OK");
                }
            }
        }

        private async void TapGestureRecognizer_Tapped_For_SignUP(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SignUp");
        }
    }
}
