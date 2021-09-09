using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTP2.RESOURCES;
using RESTP2.Models;
using System.Data.SqlClient;
using System.Data;

namespace RESTP2.Controllers
{
    public class VehiculoController : ApiController
    {

        [HttpPost]
        public IHttpActionResult Nuevo(Vehiculo modelo)
        {
            CONEXION con = new CONEXION();
            con.Conectaar();
            SqlCommand com = new SqlCommand(); // Create a object of SqlCommand class
            com.Connection = con.con; //Pass the connection object to Command
            com.CommandType = CommandType.StoredProcedure; // We will use stored procedure.
            com.CommandText = "ControlVehiculo"; //Stored Procedure Name

            com.Parameters.Add("@i_metodo", SqlDbType.Int).Value = 1;
            com.Parameters.Add("@i_placa", SqlDbType.NVarChar).Value = modelo.placa;
            com.Parameters.Add("@i_color", SqlDbType.NVarChar).Value = modelo.color;
            com.Parameters.Add("@i_anio", SqlDbType.Int).Value = modelo.anio;
            com.Parameters.Add("@i_marca", SqlDbType.Int).Value = modelo.marca;
            com.Parameters.Add("@i_tiporeserva", SqlDbType.Int).Value = modelo.tiooreserva;

            com.ExecuteNonQuery();

            con.Desconectar();
            return Ok("Si pude");
        }
    }
}
