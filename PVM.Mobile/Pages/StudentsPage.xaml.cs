using PVM.Mobile.Generic;
using PVM.Mobile.Models;

namespace PVM.Mobile.Pages;

public partial class StudentsPage : ContentPage
{

	public StudenModel oStudentModel { get; set; }

	public StudentsPage()
	{
        oStudentModel = new StudenModel();
        oStudentModel.list = new List<StudentCLS>();
        InitializeComponent();
        ListStudents();
        BindingContext = this;
    }

    private async void ListStudents()
    {
       List<StudentCLS> list = await Http.GetAll<StudentCLS>("http://rodolfocanobravo-002-site1.atempurl.com/api/Student");
       oStudentModel.list = list;
    }

    private void BtnRegresar_OnClicked(object? sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }
}