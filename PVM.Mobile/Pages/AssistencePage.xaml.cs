using PVM.Mobile.Generic;
using PVM.Mobile.Models;
using ZXing.Net.Maui;

namespace PVM.Mobile.Pages;

public partial class AssistencePage : ContentPage
{
	public AssistencePage()
	{
		InitializeComponent();
        ImagenDetector.Options = new ZXing.Net.Maui.BarcodeReaderOptions
        {
            Formats = ZXing.Net.Maui.BarcodeFormat.QrCode
        };
    }

    private void BtnRegrear_OnClicked(object? sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }

    private async void ImagenDetector_OnBarcodesDetected(object? sender, BarcodeDetectionEventArgs e)
    {
        ImagenDetector.IsDetecting = false;
        if (e.Results.Any())
        {
            var result = e.Results.FirstOrDefault();
            Dispatcher.Dispatch(async () =>
            {
                
                App.Current.MainPage = new MainPage();
                ASistenceCLS oASistenceClS = new ASistenceCLS();
                oASistenceClS.iduser = int.Parse(result.Value);
                oASistenceClS.DateMark = DateTime.Now;

                int rpta = await Http.Post<ASistenceCLS>("http://rodolfocanobravo-002-site1.atempurl.com/api/asistences", oASistenceClS);

                if (rpta == 1)
                {
                    DisplayAlert("Atención", "Asistencia almacenada.","Aceptar");
                }


            });
        }
    }
}