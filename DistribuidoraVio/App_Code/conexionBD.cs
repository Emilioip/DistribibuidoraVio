using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de conexionBD
/// </summary>
public class conexionBD
{
    private string cn = ConfigurationManager.ConnectionStrings["default"].ToString();
    public SqlConnection conectarBd = new SqlConnection();
    public conexionBD()
    {
        conectarBd.ConnectionString = cn;
    }

    public void abrir()
    {
        try
        {
            conectarBd.Open();
        }
        catch (Exception ex)
        {
            throw new Exception();
        }
    }
}