using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAcessoDatos
{
    class Conexion
    {
        #region "PATRON SINGLETON" 
        private static Conexion conexion = null;

        private Conexion()
        {
        }

        public static Conexion getInstance()
        {
            if(conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
        #endregion

        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=PC\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True";
            return conexion;
        }
    }
}
