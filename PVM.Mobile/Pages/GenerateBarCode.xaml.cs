using PVM.Mobile.Models;

namespace PVM.Mobile.Pages;

public partial class GenerateBarCode : ContentPage
{

	public string textValue { get; set; }
	public GenerateBarCodeModel OGenerateBarCodeModel { get; set; }

	public GenerateBarCode()
	{
		InitializeComponent();
		OGenerateBarCodeModel = new GenerateBarCodeModel();
		BindingContext=this;
	}


    private void GenerateBarCode_OnClicked(object? sender, EventArgs e)
    {
        OGenerateBarCodeModel.valueBarCode = textValue;
    }

    private void BtnRegresar_OnClicked(object? sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }
}