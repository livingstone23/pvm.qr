using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVM.Mobile.Generic;
using PVM.Mobile.Models;

namespace PVM.Mobile.Pages;

public partial class StudentDetailPage : ContentPage
{

    public StudentCLS obj { get; set; }
    
    public StudentDetailPage(StudentCLS student)
    {
        InitializeComponent();
        obj = student;
        BindingContext = this;
    }


    private async void BtnSendEmail_OnClicked(object? sender, EventArgs e)
    {
        EmailCLS objEmail = new EmailCLS();

        byte[] buffer = QR.generarQR(obj.IdStudent.ToString());
        objEmail.correosAEnviar = new List<string> { obj.Email };
        objEmail.asunto = "Envio del Código QR";
        objEmail.contenido = $"Hola Estimado: {obj.FullName} se envia su código QR";

        objEmail.listabyte = new List<byte[]>{ buffer };
        objEmail.nombresArchivos = new List<string> { obj.FullName + ".png" };

        string answer =  await Http.PostString<EmailCLS>("http://rodolfocanobravo-002-site1.atempurl.com/api/Email", objEmail);
        DisplayAlert("Atención", answer, "Aceptar");




    }
}