using Navigator.Clases;
using Navigator.Ajax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Net;
using System.Text.RegularExpressions;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Session.Clear();
            Context.Session.Abandon();

        }
    }


    protected void Login(object sender, EventArgs e)
    {
        var usuario = txtUser.Value.Trim().ToLower();
        var password = txtPass.Value.Trim();

        if (string.IsNullOrEmpty(usuario))
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "alertaErrorLogin('Debe ingresar un usuario');",true);
            txtUser.Focus();
            return;
        }

        if (string.IsNullOrEmpty(password))
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "alertaErrorLogin('Debe ingresar una contraseña.');", true);
            txtPass.Focus();
            return;
        }


        Usuarios users = new Usuarios();

        users.User = usuario;
        users.Pass = password;

        NavigatorAjax ajax = new NavigatorAjax();
        var data = ajax.Login(users);

        if (data.ret == "OK")
        {
            var loggedUser = (Usuario)data.values[0];
            Session.Add("LoggedUser", loggedUser);
            Response.Redirect("Home.aspx");
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "alertaErrorLogin('" + data.msg + "');", true);
            txtPass.Focus();
            return;
        }
        
        Response.Redirect("Home.aspx");
    }

    [WebMethod]
    public static RetornoAjax CrearUsuario (Usuarios nuevoRegistro)
    {  
        var ajax = new NavigatorAjax();
        return ajax.RegistroUsuario(nuevoRegistro);
    }
}