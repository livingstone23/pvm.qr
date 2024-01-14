using PVM.Mobile.Models;

namespace PVM.Mobile.Pages;

public partial class MenuPage : ContentPage
{

	    
	public List<MenuCLS> ListMenu { get; set; }
	public MenuCLS oMenuCls { get; set; }


    public MenuPage()
	{
		InitializeComponent();
		
        ListMenu = new List<MenuCLS>();
		
        ListMenu.Add(new MenuCLS
        {
			IdMenu = 1,
			NameOption = "Leer QR",
			NameIcon = "ic_phonereader"
        });
        
        ListMenu.Add(new MenuCLS
        {
            IdMenu = 2,
            NameOption = "Generar QR",
            NameIcon = "ic_generateqr"
        });

        ListMenu.Add(new MenuCLS
        {
            IdMenu = 3,
            NameOption = "Leer BarCode",
            NameIcon = "ic_readbarcode"
        });

        ListMenu.Add(new MenuCLS
        {
            IdMenu = 4,
            NameOption = "Generar BarCode",
            NameIcon = "ic_camera"
        });

        ListMenu.Add(new MenuCLS
        {
            IdMenu = 5, NameOption = "Alumnos", NameIcon = "ic_camera"
        });

        ListMenu.Add(new MenuCLS
        {
            IdMenu = 6,
            NameOption = "Asistencia",
            NameIcon = "ic_alumno"
        });

        ListMenu.Add(new MenuCLS
        {
            IdMenu = 7,
            NameOption = "Ver Marcaciones",
            NameIcon = "ic_asistencia"
        });

        ListMenu.Add(new MenuCLS
        {
            IdMenu = 1000,
            NameOption = "Cerrar Sesion",
            NameIcon = "ic_close"
        });

        BindingContext = this;



    }

    private void LstMenu_OnItemTapped(object? sender, ItemTappedEventArgs e)
    {
        if (oMenuCls.IdMenu == 1)
        {
            App.Current.MainPage = new ScanQR();
        }

        if (oMenuCls.IdMenu == 2)
        {
            //App.Current.MainPage = new GenerateQR();
            App.Navigate.PushAsync(new GenerateQR());
            App.Menu.IsPresented = false;
        }

        if (oMenuCls.IdMenu == 3)
        {
            //App.Current.MainPage = new ScanBarCode();
            App.Navigate.PushAsync(new ScanBarCode());
            App.Menu.IsPresented = false;
        }

        if (oMenuCls.IdMenu == 4)
        {
            App.Current.MainPage = new GenerateBarCode();
        }

        if (oMenuCls.IdMenu == 5)
        {
            //App.Current.MainPage = new StudentsPage();
            App.Navigate.PushAsync(new StudentsPage());
            App.Menu.IsPresented = false;
        }

        if (oMenuCls.IdMenu == 6)
        {
            App.Current.MainPage = new AssistencePage();
        }

        if (oMenuCls.IdMenu == 7)
        {
            App.Navigate.PushAsync(new WatchMarkPage());
            App.Menu.IsPresented = false;
        }

        if (oMenuCls.IdMenu == 1000)
        {
            App.Current.MainPage = new LoginPage();
            Preferences.Remove("iduser");
        }


    }
}