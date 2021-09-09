using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTP2.Models
{
    public class Reserva
    {
        public DateTime fechainicio { get; set; }
        public DateTime fechafin { get; set; }
        public double total { get; set; }
        public double precioUnitario { get; set; }
        public int vehiculo { get; set; }
        public bool cancelado { get; set; }

    }
}