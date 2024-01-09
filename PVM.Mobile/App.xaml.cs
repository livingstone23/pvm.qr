using PVM.Mobile.Pages;

namespace PVM.Mobile
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();
            if(Preferences.Get("iduser",0)==0)
                MainPage = new LoginPage();
            else
                MainPage = new MainPage();







        }

        public static MainPage Menu { get; internal set; }
        public static NavigationPage Navigate { get; internal set; }
    }
}
