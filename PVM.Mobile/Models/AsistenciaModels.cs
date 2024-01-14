using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVM.Mobile.Generic;

namespace PVM.Mobile.Models
{
    public class AsistenciaModels: BaseBinding
    {
        private List<ListAsistenciaCLS> _list;

        public List<ListAsistenciaCLS> list
        {
            get
            {
                return _list;
            }
            set
            {
                SetValue(ref _list, value);
            }
        }

        private List<AsistenciaGroup> _listag;

        public List<AsistenciaGroup> listag
        {
            get
            {
                return _listag;
            }
            set
            {
                SetValue(ref _listag, value);
            }
        }
    }
}
