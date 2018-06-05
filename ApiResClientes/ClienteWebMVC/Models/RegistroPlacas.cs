using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteWebMVC.Models
{
    public partial class RegistroPlacas
    {
        public int IdRegistro { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Modelo { get; set; }
        public string Correo { get; set; }
        public string Placas { get; set; }
    }
}