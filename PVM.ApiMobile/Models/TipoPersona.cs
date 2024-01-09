using System;
using System.Collections.Generic;

namespace PVM.ApiMobile.Models;

public partial class TipoPersona
{
    public int Idtipopersona { get; set; }

    public string? Nombretipopersona { get; set; }

    public int? Bhabilitado { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
