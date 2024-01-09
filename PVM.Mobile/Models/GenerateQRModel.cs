using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVM.Mobile.Generic;


namespace PVM.Mobile.Models;


public class GenerateQRModel: BaseBinding
{

    private string _valueQR;
    
    public string valueQR
    {
        get
        {
            return _valueQR;
        }
        set
        {
            SetValue(ref _valueQR,value);
        }
    }
    
}

