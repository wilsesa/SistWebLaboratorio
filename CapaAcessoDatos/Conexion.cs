using System.Data.SqlClient;

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
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
        #endregion

        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=PC\SQLEXPRESS;Initial Catalog=DBClinica_test;Integrated Security=True";
            return conexion;
        }
    }
}
