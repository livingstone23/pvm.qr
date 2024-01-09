using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PVM.ApiMobile.DTO;
using PVM.ApiMobile.Models;

namespace PVM.ApiMobile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        [HttpGet]
        public List<StudentCLS> GetStudents()
        {
            List<StudentCLS> StudentList = new List<StudentCLS>();

            using (DbMovilContext bd = new DbMovilContext())
            {
                StudentList = (from student in bd.Personas
                        where student.Bhabilitado == 1
                        select new StudentCLS
                        {
                            IdStudent = student.Idpersona,
                            FullName =$"{student.Nombre} {student.Appaterno} {student.Apmaterno}",
                            Email = student.Correo
                        }).ToList();
            }

            return StudentList;


        }

    }
}
