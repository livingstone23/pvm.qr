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
        public string sendEmail([FromBody] EmailCLS oEmailCls)
        {
            return Email.EnviarCorreo(oEmailCls.correosAEnviar, oEmailCls.asunto, oEmailCls.contenido, oEmailCls.nombresArchivos, oEmailCls.listabyte);
        }

    }
}
