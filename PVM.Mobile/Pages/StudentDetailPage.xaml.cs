using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


    private void BtnSendEmail_OnClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}