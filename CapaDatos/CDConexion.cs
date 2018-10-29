using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    class CDConexion
    {

        //Objeto tipo SQLConnection
        private SqlConnection connection = new SqlConnection("Server=DESKTOP-04NJ866;DataBase=LoginData;Intregated Security=True");


        //Metodo Iniciar una conexion con la base de datos
        public SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;                    
        }

        //Metodo cerrar una conexion con la base de datos
        public SqlConnection CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            return connection;
        }
    }
}
