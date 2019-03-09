using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Navigator
/// </summary>
/// 
namespace Navigator.Clases
{


    public class Usuarios
    {
        public int ID { get; set; }

        public string User { get; set; }

        public string Pass { get; set; }

        public int Nivel { get; set; }
    }
    public class Meses
    {
        public string IdMes { get; set; }
        public string Mes { get; set; }
    }
}