using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PVM.ApiMobile.DTO;
using PVM.ApiMobile.Models;

namespace PVM.ApiMobile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsistencesController : ControllerBase
    {




        [HttpPost]
        public int SaveAsistence([FromBody] AsistenceDTO oAsistenceDto)
        {
            int rpta = 0;
            try
            {
                using (DbMovilContext bd = new DbMovilContext())
                {
                    Asistencium oAsistencium = new Asistencium();
                    oAsistencium.Idusuario = oAsistenceDto.IdUser;
                    oAsistencium.Fechaasistencia = oAsistenceDto.DateMark;
                    oAsistencium.Bhabilitado = 1;
                    bd.Asistencia.Add(oAsistencium);
                    bd.SaveChanges();
                    rpta= 1;
                }
                

            }
            catch (Exception e)
            {
                rpta = 0;
            }
            return rpta;
        }


        [HttpGet("{idusuario}")]
        public List<ListAsistenceDTO> ListarAsistencias(int idusuario)
        {

            List<ListAsistenceDTO> listAsistenceDtos = new List<ListAsistenceDTO>();

            using (DbMovilContext bd = new DbMovilContext())
            {
                
                List<ListAsistenceDTO> lista = (from asistencia in bd.Asistencia
                                                where asistencia.Bhabilitado == 1 
                                                && asistencia.Idusuario == idusuario
                                                orderby asistencia.Fechaasistencia descending
                                                select new ListAsistenceDTO
                                                {
                                                    FechaMarcacion = asistencia.Fechaasistencia.Value.ToString("dd/MM/yyyy"),
                                                    HoraMarcacion = asistencia.Fechaasistencia.Value.ToString("HH:mm")
                                      
                                                }).ToList();
                                                

                return lista;
            }


        }


    }
}
