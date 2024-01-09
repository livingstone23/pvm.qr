using System;
using System.Collections.Generic;

namespace PVM.ApiMobile.Models;

public partial class Persona
{
    public int Idpersona { get; set; }

    public string? Nombre { get; set; }

    public string? Appaterno { get; set; }

    public string? Apmaterno { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public DateOnly? Fechanacimiento { get; set; }

    public int? Idtipopersona { get; set; }

    public int? Btieneusuario { get; set; }

    public int? Bhabilitado { get; set; }

    public virtual TipoPersona? IdtipopersonaNavigation { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
