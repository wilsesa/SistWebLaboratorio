using CapaEntidades;
using CapaLogicaNegocio;
using System;
using System.Web.UI;

namespace CapaPresentacion
{
    public partial class frmGestionarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private Paciente GetEntity()
        {
            Paciente objPaciente = new Paciente();
            objPaciente.IdPaciente = 0;
            objPaciente.Nombres = txtNombres.Text;
            objPaciente.ApPaterno = txtApPaterno.Text;
            objPaciente.ApMaterno = txtApMaterno.Text;
            objPaciente.Edad = Convert.ToInt32(txtEdad.Text);
            objPaciente.Sexo = (ddlSexo.SelectedValue == "Femenino") ? 'F' : 'M';    //Masculino ou Femenino
            objPaciente.NroDocumento = txtNroDocumento.Text;
            objPaciente.Direccion = txtDireccion.Text;
            objPaciente.Telefono = txtTelefono.Text;
            objPaciente.Estado = true;
            //objPaciente.Imagen = ;

            return objPaciente;

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Registro del paciente
                Paciente objPaciente = GetEntity();
                //Enviar a la capa de Logica de Negocio
                bool response = PacienteLN.getInstance().RegistrarPaciente(objPaciente);
                if (response == true)
                {
                    Response.Write("<script>alert('REGISTRO CORRECTO')</script>");
                }
                else
                {
                    Response.Write("<script>alert('REGISTRO INCORRECTO')</script>");
                }
            }
        }
    }
}