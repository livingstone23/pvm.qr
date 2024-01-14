using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVM.Mobile.Generic;
using PVM.Mobile.Models;

namespace PVM.Mobile.Pages;

public partial class WatchMarkPage : ContentPage
{

    public AsistenciaModels oAsistenciaModels { get; set; } 

    public WatchMarkPage()
    {
        InitializeComponent();
        oAsistenciaModels = new AsistenciaModels();
        oAsistenciaModels.list = new List<ListAsistenciaCLS>();
        BindingContext = this;
        listarMarcacionesUsuario();
    }

    private async void listarMarcacionesUsuario()
    {
        int idUsuario = Preferences.Get("iduser", 0);
        var data = await Http.GetAll<ListAsistenciaCLS>("http://rodolfocanobravo-002-site1.atempurl.com/api/Asistences/"+ idUsuario);
        oAsistenciaModels.list = data;

        var dataagrupada = (from asis in data
                                            group asis by asis.FechaMarcacion
                                            into grupo
                                            select new AsistenciaGroup(grupo.Key, grupo.ToList())).ToList();

        oAsistenciaModels.listag = dataagrupada;
    }
}