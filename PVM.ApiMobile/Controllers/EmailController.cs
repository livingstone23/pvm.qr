using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PVM.ApiMobile.DTO;
using PVM.ApiMobile.Generic;

namespace PVM.ApiMobile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {


        [HttpPost]
        public string sendEmail([FromBody] EmailDTO oEmailDto)
        {
            return Email.EnviarCorreo(oEmailDto.correosAEnviar, oEmailDto.asunto, oEmailDto.contenido, oEmailDto.nombresArchivos, oEmailDto.listabyte);
        }

    }
}
