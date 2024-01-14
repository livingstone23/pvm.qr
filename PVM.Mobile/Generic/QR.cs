using QRCoder;

namespace PVM.Mobile.Generic;

public class QR
{
    public static byte[] generarQR(string texto)
    {
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(texto, QRCodeGenerator.ECCLevel.H);

        PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
        byte[] qrCodeBytes = qRCode.GetGraphic(15);
        return qrCodeBytes;
    }
}