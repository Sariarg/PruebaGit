using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTP2.Models
{
    public class Cliente
    {
        public string nombre { get; set; }
        public int telefono { get; set; }
        public  string dui {get; set; }
        public string nit { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}