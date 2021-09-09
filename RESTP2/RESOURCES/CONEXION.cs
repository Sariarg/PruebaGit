using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace RESTP2.RESOURCES
{
    public class CONEXION
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-TQ5UTAN\\SQLEXPRESS;Initial Catalog=PRUEBA;Persist Security Info=True;User ID=sa;Password=123456-" +"");
    
        public void Conectaar()
        {
            con.Open();
        }


        public void Desconectar()
        {
            con.Close();
        }
    }
}