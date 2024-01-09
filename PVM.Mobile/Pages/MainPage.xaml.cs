namespace PVM.Mobile.Pages;

public partial class MainPage : FlyoutPage
{
	public MainPage()
	{
		InitializeComponent();
        App.Menu = this;
        App.Navigate = Navigate;
    }
}