using PVM.Mobile.Generic;
using PVM.Mobile.Models;

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

    private async void BtnIngresar_OnClicked(object? sender, EventArgs e)
    {
        UsuarioCLS oUsuarioCls = await Http.Get<UsuarioCLS>("http://rodolfocanobravo-002-site1.atempurl.com/api/Login/"+ nameuser+"/"+password);

        if (oUsuarioCls.IdUser == 0)
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrecta", "Cancelar");
        }
        else
        {
            App.Current.MainPage = new MainPage();
            Preferences.Set("iduser", oUsuarioCls.IdUser);
        }
        //if (nameuser == "lcano" && password=="1234")
        //{
        //    App.Current.MainPage = new MainPage();
        //    Preferences.Set("iduser",1);
        //}
        //else
        //{
        //    DisplayAlert("Error", "Usuario o contraseña incorrecta", "Cancelar");
        //}

    }
}