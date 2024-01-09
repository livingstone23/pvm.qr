using ZXing.Net.Maui;

namespace PVM.Mobile.Pages;

public partial class ScanBarCode : ContentPage
{
	public ScanBarCode()
	{
		InitializeComponent();
        ImagenDetector.Options = new ZXing.Net.Maui.BarcodeReaderOptions
        {
            Formats = ZXing.Net.Maui.BarcodeFormat.Code128
        };
    }

    private void BtnRegrear_OnClicked(object? sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }

    private void ImagenDetector_OnBarcodesDetected(object? sender, BarcodeDetectionEventArgs e)
    {
        ImagenDetector.IsDetecting = false;
        if (e.Results.Any())
        {
            var result = e.Results.FirstOrDefault();
            Dispatcher.Dispatch(async () =>
            {
                DisplayAlert("Valor", result.Value, "Cancelar");
                App.Current.MainPage = new MainPage();
            });
        }
    }
}