using System;
using System.Collections.Generic;

namespace PVM.ApiMobile.Models;

public partial class TipoUsuario
{
    public int Idtipousuario { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? Bhabilitado { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
