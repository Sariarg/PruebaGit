using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTP2.RESOURCES;
using RESTP2.Models;

namespace RESTP2.Controllers
{
    public class ClienteController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Nuevo(Cliente modelo)
        {
            CONEXION con = new CONEXION();
            con.Conectaar();
            SqlCommand com = new SqlCommand(); // Create a object of SqlCommand class
            com.Connection = con.con; //Pass the connection object to Command
            com.CommandType = CommandType.StoredProcedure; // We will use stored procedure.
            com.CommandText = "ControlCliente"; //Stored Procedure Name

            com.Parameters.Add("@i_metodo", SqlDbType.Int).Value = 1;
            com.Parameters.Add("@i_nombre", SqlDbType.NVarChar).Value = modelo.nombre;
            com.Parameters.Add("@i_telefono", SqlDbType.Int).Value = modelo.telefono;
            com.Parameters.Add("@i_dui", SqlDbType.NVarChar).Value = modelo.dui;
            com.Parameters.Add("@i_nit", SqlDbType.NVarChar).Value = modelo.nit;
            com.Parameters.Add("@i_fechanacimiento", SqlDbType.Date).Value = Convert.ToDateTime(modelo.fechaNacimiento);

            com.ExecuteNonQuery();

            con.Desconectar();
            return Ok("Si pude");
        }
    }
}
