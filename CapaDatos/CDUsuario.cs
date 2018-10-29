using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDUsuario
    {
        private CDConexion connection = new CDConexion();
        private SqlDataReader leer;

        public SqlDataReader iniciarSesion(string user,string pass)
        {
            string sql = "select *from Usuarios where ID= '" + user + "'and Contraseña='" + pass + "'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection.OpenConnection();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();

            return leer;
        }
    }
}
