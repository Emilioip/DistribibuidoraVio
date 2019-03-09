using Navigator.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //var loggedUser = (Usuario)Session["LoggedUser"];
        //var fecha = DateTime.Now;
        //if (fecha.Hour > 0 && fecha.Hour < 12)
        //{
        //    nombreusuario.InnerHtml = "Buenos días " + loggedUser.Usuarionombre + ". Bienvenido al Sistema.";
        //}
        //else if (fecha.Hour >= 12 && fecha.Hour < 20)
        //{
        //    nombreusuario.InnerHtml = "Buenas tardes " + loggedUser.Usuarionombre + ". Bienvenido al Sistema.";
        //}
        //else
        //{
        //    nombreusuario.InnerHtml = "Buenas noches " + loggedUser.Usuarionombre + ". Bienvenido al Sistema.";
        //}
    }
}
