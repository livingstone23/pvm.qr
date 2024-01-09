namespace PVM.Mobile.Pages;

public partial class LoginPage : ContentPage
{

    public string nameuser { get; set; }
    public string password { get; set; }

	public LoginPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    private void BtnIngresar_OnClicked(object? sender, EventArgs e)
    {
        
        if (nameuser == "lcano" && password=="1234")
        {
            App.Current.MainPage = new MainPage();
            Preferences.Set("iduser",1);
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrecta", "Cancelar");
        }

    }
}