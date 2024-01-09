using System;
using System.Collections.Generic;

namespace PVM.ApiMobile.Models;

public partial class Asistencium
{
    public int Idasistencia { get; set; }

    public int? Idusuario { get; set; }

    public DateTime? Fechaasistencia { get; set; }

    public int? Bhabilitado { get; set; }

    public virtual Usuario? IdusuarioNavigation { get; set; }
}
