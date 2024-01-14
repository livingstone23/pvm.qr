using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PVM.ApiMobile.DTO;
using PVM.ApiMobile.Generic;
using PVM.ApiMobile.Models;

namespace PVM.ApiMobile.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{

    [HttpGet("{usuario}/{contra}")]
    public UsuarioDTO login(string usuario, string contra)
    {

        UsuarioDTO oUsuarioDTO = new UsuarioDTO();
        string contraCifrada = Cifrado.cifrarCadena(contra);

        using (DbMovilContext bd = new DbMovilContext())
        {

            Usuario user =  bd.Usuarios.Where(p => p.Nombreusuario == usuario && p.Contra == contraCifrada).FirstOrDefault();
            if (user == null)
            {
              return oUsuarioDTO;
            }
            else
            {
                  Persona persona = bd.Personas.Where(p => p.Idpersona == user.Idpersona).First();
                  oUsuarioDTO.UserName = persona.Nombre + " " + persona.Appaterno + " " + persona.Apmaterno;
                  oUsuarioDTO.IdUser = user.Idusuario;
                  oUsuarioDTO.IdTipoUsuario = (int)user.Idtipousuario;
            }
        }
        return oUsuarioDTO;
    }


}

