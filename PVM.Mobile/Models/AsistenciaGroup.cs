using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVM.Mobile.Models
{
    public class AsistenciaGroup: List<ListAsistenciaCLS>
    {
        public string nombreGrupo { get; set; }

        public AsistenciaGroup(string NombreGrupo, List<ListAsistenciaCLS> lista): base(lista)
        {
            nombreGrupo = NombreGrupo;
        }

        




    }
}
