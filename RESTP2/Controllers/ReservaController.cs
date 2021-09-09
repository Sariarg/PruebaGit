using RESTP2.Models;
using RESTP2.RESOURCES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTP2.Controllers
{
    public class ReservaController : ApiController
    {

        [HttpPost]
        public IHttpActionResult Nuevo(Reserva modelo)
        {
            CONEXION con = new CONEXION();
            con.Conectaar();
            SqlCommand com = new SqlCommand(); // Create a object of SqlCommand class
            com.Connection = con.con; //Pass the connection object to Command
            com.CommandType = CommandType.StoredProcedure; // We will use stored procedure.
            com.CommandText = "ControlReserva"; //Stored Procedure Name

            com.Parameters.Add("@i_metodo", SqlDbType.Int).Value = 1;
            com.Parameters.Add("@i_fechainicio", SqlDbType.Date).Value = modelo.fechainicio;
            com.Parameters.Add("@i_fechafin", SqlDbType.Date).Value = modelo.fechafin;
            com.Parameters.Add("@i_total", SqlDbType.Money).Value = modelo.total;
            com.Parameters.Add("@i_costounitario", SqlDbType.Money).Value = modelo.precioUnitario;
            com.Parameters.Add("@i_vehiculo", SqlDbType.Int).Value = modelo.vehiculo;
            com.Parameters.Add("@i_cancelado", SqlDbType.Bit).Value = modelo.cancelado;

            com.ExecuteNonQuery();

            con.Desconectar();
            return Ok("Si pude");
        }
    }
}
