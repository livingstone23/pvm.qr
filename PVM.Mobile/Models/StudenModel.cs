using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVM.Mobile.Generic;


namespace PVM.Mobile.Models;


public class StudenModel:  BaseBinding
{

    private List<StudentCLS> _list;

    public List<StudentCLS> list
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


}

