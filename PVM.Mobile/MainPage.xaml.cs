using PVM.Mobile.Pages;

namespace PVM.Mobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void BtnScanear_OnClicked(object? sender, EventArgs e)
        {
            App.Current.MainPage = new ScanQR();
        }
    }

}
