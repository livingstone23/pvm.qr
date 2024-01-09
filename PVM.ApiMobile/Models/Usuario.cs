using System;
using System.Collections.Generic;

namespace PVM.ApiMobile.Models;

public partial class Usuario
{
    public int Idusuario { get; set; }

    public string? Nombreusuario { get; set; }

    public string? Contra { get; set; }

    public int? Idtipousuario { get; set; }

    public int? Idpersona { get; set; }

    public int? Bhabilitado { get; set; }

    public virtual ICollection<Asistencium> Asistencia { get; set; } = new List<Asistencium>();

    public virtual Persona? IdpersonaNavigation { get; set; }

    public virtual TipoUsuario? IdtipousuarioNavigation { get; set; }
}
