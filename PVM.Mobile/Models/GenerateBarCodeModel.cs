using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVM.Mobile.Generic;

namespace PVM.Mobile.Models
{
    public class GenerateBarCodeModel: BaseBinding
    {
        
        private string _valueBarCode;
        
        public string valueBarCode
        {
            get
            {
                return _valueBarCode;
            }
            set
            {
                SetValue(ref _valueBarCode, value);
            }
        }

    }



}
