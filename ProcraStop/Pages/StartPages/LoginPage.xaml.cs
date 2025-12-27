namespace ProcraStop.Pages.StartPages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string usuario = "admin";
        string contraseña = "1234";

        string usuarioEntry = entryCorreo.Text;
        string contraseñaEntry = entryContraseña.Text;
        if (string.IsNullOrWhiteSpace(usuarioEntry) || string.IsNullOrWhiteSpace(contraseñaEntry))
        {
            await Shell.Current.DisplayAlertAsync("Aviso", "Completa los campos", "OK");
            return;
        }

        if (usuario == usuarioEntry && contraseña == contraseñaEntry)
        {
            await DisplayAlertAsync("Exito", "Usuario y contraseña Válidos", "OK");
            await Shell.Current.GoToAsync("VistaPrueba");
        }

        else
        {
            await DisplayAlertAsync("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}