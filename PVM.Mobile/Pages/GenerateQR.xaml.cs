using PVM.Mobile.Models;

namespace PVM.Mobile.Pages;

public partial class GenerateQR : ContentPage
{
    public GenerateQRModel oGenerateQRModel { get; set; }
    public String textValue { get; set; } = "";
    //public string valueQR { get; set; }


	public GenerateQR()
	{
		InitializeComponent();
        oGenerateQRModel = new GenerateQRModel();
        BindingContext = this;
    }

    private void BtnRegresar_OnClicked(object? sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        //valueQR = textValue;
        oGenerateQRModel.valueQR = textValue;
    }
}