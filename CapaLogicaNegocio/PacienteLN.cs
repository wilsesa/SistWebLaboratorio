﻿using CapaAcessoDatos;
using CapaEntidades;
using System;

namespace CapaLogicaNegocio
{
    public class PacienteLN
    {
        #region "PATRON SINGLETON"
        private static PacienteLN objEmpleado = null;
        private PacienteLN()
        {
        }
        public static PacienteLN getInstance()
        {
            if (objEmpleado == null)
            {
                objEmpleado = new PacienteLN();
            }
            return objEmpleado;
        }
        #endregion

        public bool RegistrarPaciente(Paciente objPaciente)
        {
            try
            {
                return PacienteDAO.getInstance().RegistrarPaciente(objPaciente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}