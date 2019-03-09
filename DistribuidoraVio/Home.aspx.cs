using Navigator.Clases;
using Navigator.Ajax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var loggedUser = (Usuario)Session["LoggedUser"];

            if (loggedUser==null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
        } 
    }

    [WebMethod]
    public static RetornoAjax Prueba()
    {
        var ajax = new NavigatorAjax();
        var ret = new RetornoAjax();
        ret.ret = "OK";
        return ret;
    }

   

    [WebMethod]
    public static RetornoAjax llenarCombo()
    {
        var ajax = new NavigatorAjax();
        return ajax.LlenarCombo();
    }

    [WebMethod]
    public static RetornoAjax getCodigo(string codigo)
    {
        var ajax = new NavigatorAjax();
        return ajax.getCodigo(codigo);
    }
}