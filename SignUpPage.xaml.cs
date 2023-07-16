using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace SignInAndSignUpUI
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        //Registro de usuario con la api mediante el boton que esta en la pantalla de Registro de usuario
        private async void OnSignUpClicked(object sender, EventArgs e)
        {
            string nombre = usernameEntry1.Text;
            string apellido = apellidoEntry1.Text;
            string correoElectronico = emailentry1.Text;
            string contrasena = passwordEntry1.Text;
            string nombreUsuario = UsuarioEntry1.Text;

            // Aquí puedes crear un objeto para representar los datos del nuevo usuario
            var newUser = new
            {
                nombre = nombre,
                apellido = apellido,
                correoElectronico = correoElectronico,
                contrasena = contrasena,
                nombreUsuario = nombreUsuario
            };

            // Convertir el objeto a formato JSON
            var json = JsonConvert.SerializeObject(newUser);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Realizar la solicitud POST al endpoint de creación de usuarios de tu API
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync("https://localhost:7256/api/Registro", content);

                if (response.IsSuccessStatusCode)
                {
                    // La solicitud fue exitosa, puedes mostrar un mensaje de éxito o realizar otras acciones necesarias
                    await DisplayAlert("Registro exitoso", "Usuario creado correctamente", "OK");
                }
                else
                {
                    // Mostrar mensaje de error si la creación falló
                    await DisplayAlert("Error", "Error al crear usuario", "OK");
                }
            }
        }

        private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SignIn");
        }
    }
}


