namespace PVM.Mobile.Pages;

public partial class ScanQR : ContentPage
{
	public ScanQR()
	{
		InitializeComponent();
	}

    private void BtnRegrear_OnClicked(object? sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }
}