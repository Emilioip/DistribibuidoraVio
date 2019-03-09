using Navigator.Base;
using Navigator.Clases;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static Navigator.Librerias.Utilidades;

namespace Navigator.Ajax
{
    public class NavigatorAjax : NavigatorBase
    {

        public RetornoAjax Login(Usuarios usuario)
        {
            RetornoAjax ret = new RetornoAjax();
            List<Usuario> usuarios = new List<Usuario>();
            var user = usuario.User;
            var pass = MD5.MD5Hash(usuario.Pass);
            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PROC_LOGIN", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@USER", user);
                    cmd.Parameters.AddWithValue("@PASS", pass);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    cn.Open();
                    da.Fill(dt);

                    cn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        var a = dt.Rows[0];

                        Usuario usu = new Usuario()
                        {
                            Id = a["id_usuario"].ToString(),
                            Usuarionombre = a["usuario"].ToString()
                        };
                        ret.ret = "OK";
                        ret.msg = "Logueado";
                        ret.debug = "Logueado";
                        ret.values = new List<object>();
                        ret.values.Add(usu);
                    }
                    else
                    {
                        ret.ret = "ERROR";
                        ret.msg = "Usuario o contraseña inválidos.";
                        ret.debug = "Error de validacion";
                    }
                }
            }
            catch (Exception ex)
            {
                ret.ret = "Error";
                ret.msg = "Ha ocurrudo un error, vuelva a intentar o intente mas tarde.";
                ret.debug = ex.Message;
            }

            return ret;
        }

        public RetornoAjax getCodigo(string codigo)
        {
            var ret = new RetornoAjax();

            if (codigo == "18070965")
            {
                ret.ret = "OK";
                ret.msg = "Nova Elite";
            }
            else
            {
                ret.ret = "error";
                ret.msg = "Producto no encontrado";
            }

            return ret;
        }

        public RetornoAjax LlenarCombo()
        {
            RetornoAjax ret = new RetornoAjax();
            List<object> meses = new List<object>();

            for (int i = 1; i < 13; i++)
            {
                Meses mes = new Meses()
                {
                    IdMes = i.ToString(),
                    Mes = "Mes " + i
                };
                meses.Add(mes);
            }
            ret.ret = "OK";
            ret.msg = "";
            ret.debug = "";

            ret.values = new List<object>();
            ret.values = meses;
            return ret;
        }

        public RetornoAjax TraerUsuarios()
        {
            RetornoAjax ret = new RetornoAjax();
            List<Usuarios> usuarios = new List<Usuarios>();

            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                {
                    SqlCommand cmd = new SqlCommand("PROC_TRAER_USUARIOS", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    cn.Open();
                    da.Fill(dt);
                    cn.Close();

                    if (dt.Rows.Count > 0)
                    {
                        var users = dt.Rows[0];


                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ret;
        }

        public RetornoAjax RegistroUsuario(Usuarios nuevoRegistro)
        {
            RetornoAjax ret = new RetornoAjax();
            var pass = MD5.MD5Hash(nuevoRegistro.Pass);
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
                {


                    SqlCommand cmd = new SqlCommand("SP_CREAR_USUARIO", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@user", nuevoRegistro.User);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@nivel", 2);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    ret.ret = "OK";
                }
            }
            catch (Exception ex)
            {
                ret.ret = "ERROR";
                ret.msg = "No se pudo completar la operación.";
                ret.debug = ex.Message;
            }

            return ret;
        }
    }
}
