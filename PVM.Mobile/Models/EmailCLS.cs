using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PVM.Mobile.Models;



public class EmailCLS
{

    public List<string> correosAEnviar { get; set; }

    public string asunto { get; set; }

    public string contenido { get; set; }

    public List<string>? nombresArchivos { get; set; } = null;

    public List<byte[]>? listabyte { get; set; } = null;

}

