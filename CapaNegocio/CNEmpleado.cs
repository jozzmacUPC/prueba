using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNEmpleado
    {
        private CDUsuario objDato = new CDUsuario();

        
        private String _user;
        private String _pass;

        
        public String User
        {
            set { _user = value; }
            get { return _user; }
        }

        public String Pass
        {
            set { _pass = value; }
            get { return _pass; }
        }

        public CNEmpleado()
        {

        }

        public SqlDataReader IniciarSesion() {
            SqlDataReader logear;
            logear = objDato.iniciarSesion(User, Pass);

            return logear;
        }
             
    }
}
