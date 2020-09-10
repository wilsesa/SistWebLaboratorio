using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CapaAcessoDatos
{
    public class PacienteDAO
    {
        #region "PATRON SINGLETON"
        private static PacienteDAO daoEmpleado = null;
        private PacienteDAO()
        {
        }

        public static PacienteDAO getInstance()
        {
            if (daoEmpleado == null)
            {
                daoEmpleado = new PacienteDAO();
            }
            return daoEmpleado;
        }
        #endregion

        public bool RegistrarPaciente(Paciente objPaciente)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;

            try
            {
                con = Conexion.getInstance().ConexionBD();

                cmd = new SqlCommand("spInsRegistrarPaciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmNombres", objPaciente.Nombres);
                cmd.Parameters.AddWithValue("@prmApPaterno", objPaciente.ApPaterno);
                cmd.Parameters.AddWithValue("@prmApMaterno", objPaciente.ApMaterno);
                cmd.Parameters.AddWithValue("@prmEdad", objPaciente.Edad);
                cmd.Parameters.AddWithValue("@prmSexo", objPaciente.Sexo);
                cmd.Parameters.AddWithValue("@prmNroDoc", objPaciente.NroDocumento);
                cmd.Parameters.AddWithValue("@prmDireccion", objPaciente.Direccion);
                cmd.Parameters.AddWithValue("@prmTelefono", objPaciente.Telefono);
                cmd.Parameters.AddWithValue("@prmEstado", objPaciente.Estado);
                con.Open();

                //cmd.ExecuteNonQuery();
                int filas = cmd.ExecuteNonQuery();
                if (filas > 0) response = true;
            }
            catch (Exception ex)
            {
                response = false;
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return response;
        }

        public List<Paciente> ListarPaciente()
        {
            List<Paciente> Lista = new List<Paciente>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spSelListarPacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //Crear objetos de tipo Paciente
                    Paciente objPaciente = new Paciente();
                    objPaciente.IdPaciente = Convert.ToInt32(dr["idPaciente"].ToString());
                    objPaciente.Nombres = dr["Nombres"].ToString();
                    objPaciente.ApPaterno = dr["apPaterno"].ToString();
                    objPaciente.ApMaterno = dr["apMaterno"].ToString();
                    objPaciente.Edad = Convert.ToInt32(dr["edad"].ToString());
                    objPaciente.Sexo = Convert.ToChar(dr["sexo"].ToString());
                    objPaciente.NroDocumento = dr["nroDocumento"].ToString();
                    objPaciente.Direccion = dr["direccion"].ToString();
                    objPaciente.Estado = true;
                    //Anadir a la lista de objetos
                    Lista.Add(objPaciente);
                }

                //EL OTRO METODO ES USANDO USING
                //using(SqlDataReader dr1 = cmd.ExecuteReader())
                //{
                //    Paciente objPaciente = new Paciente();
                //    objPaciente.IdPaciente = Convert.ToInt32(dr["idPaciente"].ToString());
                //    objPaciente.Nombres = dr["Nombres"].ToString();
                //    objPaciente.ApPaterno = dr["apPaterno"].ToString();
                //    objPaciente.ApMaterno = dr["apMaterno"].ToString();
                //    objPaciente.Edad = Convert.ToInt32(dr["edad"].ToString());
                //    objPaciente.Sexo = Convert.ToChar(dr["sexo"].ToString());
                //    objPaciente.NroDocumento = dr["nroDocumento"].ToString();
                //    objPaciente.Direccion = dr["direccion"].ToString();
                //    objPaciente.Estado = true;
                //}

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }

            return Lista;
        }
    }
}
