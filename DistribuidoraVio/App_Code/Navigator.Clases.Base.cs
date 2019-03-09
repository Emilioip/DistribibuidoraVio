using System.Collections.Generic;

namespace Navigator.Clases
{
    /// <summary>
    /// Aplicacion
    /// </summary>
    public class Aplicacion
    {

        public string IdAplicacion { get; set; }
        public string Instancia { get; set; }
        public string Package { get; set; }
        public string IdLogin { get; set; }

        public Aplicacion()
        {

        }
    }

    /// <summary>
    /// Usuario
    /// </summary>
    public class Usuario
    {
        public string Id { get; set; }
        public string Mail { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Nivel { get; set; }
        public string Rutcliente { get; set; }
        public string Gruporesolutor { get; set; }
        public string Usuarionombre { get; set; }

        public Usuario()
        {

        }
    }

    public class RetornoAjax
    {
        public string ret { get; set; }
        public string msg { get; set; }
        public string debug { get; set; }
        public List<object> values { get; set; }
    }

    public class Retorno
    {
        public string ret { get; set; }
        public string msg { get; set; }
        public string debug { get; set; }
        public string Numero { get; set; }
        public List<object> values { get; set; }
    }

    public class SaveAjax
    {
        public string ret { get; set; }
        public string debug { get; set; }
        public string msg { get; set; }
    }

    public class Script
    {
        public string Url { get; set; }
        public string Detalle { get; set; }
    }
}
