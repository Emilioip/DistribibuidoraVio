using Navigator.Clases;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de NavigatorBase
/// </summary>
/// 
namespace Navigator.Base
{
    public class NavigatorBase
    {
        public string MsgError { get; set; }
        public string Usuario { get; set; }

        public Aplicacion BaseUtilApp { get; set; }
        //public UtilVariables BaseUtilVariables { get; set; }
        //public UtilAsp BaseUtilAsp { get; set; }

        //public ServicioWebCliente WebServiceConsultas { get; set; }
        //public ServicioWebCliente WebServiceExecutor { get; set; }

        public NavigatorBase()
        {

            //this.BaseUtilVariables = new UtilVariables();
            //this.BaseUtilAsp = new UtilAsp();
            this.BaseUtilApp = new Aplicacion();

            //this.WebServiceConsultas = new ServicioWebCliente();
            //this.WebServiceExecutor = new ServicioWebCliente();

            //this.BaseUtilApp.IdAplicacion = ConfigurationManager.AppSettings.Get("IDAPLICACION");
            //this.BaseUtilApp.Instancia = ConfigurationManager.AppSettings.Get("INSTANCIA");
            //this.BaseUtilApp.Package = ConfigurationManager.AppSettings.Get("PACKAGE");
            //this.BaseUtilApp.IdLogin = ConfigurationManager.AppSettings.Get("IDLOGIN");
        }
    }

}