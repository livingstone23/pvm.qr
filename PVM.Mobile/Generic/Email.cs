using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;



namespace PVM.Mobile.Generic;

public class Email
{

    public static string EnviarCorreo(List<string> correosAEnviar, string asunto,
        string contenido, List<string> nombresArchivos = null, List<byte[]> listabyte = null)
    {
        string str;
        try
        {
            string Host = "Smtp.Gmail.com";
            string appSetting2 = "587";
            string appSetting3 = "livingstone23@gmail.com";
            string password = "wtizdzxsyhybdhsn";
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = (ICredentialsByHost)new NetworkCredential(appSetting3, password);
            smtpClient.Port = int.Parse(appSetting2);
            smtpClient.Host = Host;
            smtpClient.EnableSsl = true;
            MailMessage message = new MailMessage();
            message.From = new MailAddress(appSetting3);
            foreach (string address in correosAEnviar)
                message.To.Add(new MailAddress(address));
            if (nombresArchivos != null && listabyte != null)
            {
                for (int i = 0; i < nombresArchivos.Count; i++)
                {
                    MemoryStream memoryStream = new MemoryStream(listabyte[i]);
                    message.Attachments.Add(new Attachment(memoryStream, nombresArchivos[i],
                        MediaTypeNames.Application.Octet));
                }
            }
            message.Subject = asunto;
            message.IsBodyHtml = true;
            message.Body = contenido;
            smtpClient.Send(message);
            str = "Se envio el Correo satisfactoriamente";
        }
        catch (Exception ex)
        {
            str = "Error al Enviar Correo: " + ex.Message;
        }
        return str;
    }

}

