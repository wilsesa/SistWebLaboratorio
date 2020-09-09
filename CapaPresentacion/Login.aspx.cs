using CapaEntidades;
using CapaLogicaNegocio;
using System;


namespace CapaPresentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //METODO ESTATICO
            //string user     = txtUsuario.Text;
            //string password = txtPasswword.Text;

            //string userName = "wilson";
            //string passName = "wilson";
            //if(user.Equals(userName) && password.Equals(passName))
            //{
            //    Response.Write("<script>alert('USUARIO CORRECTO')</script>");
            //    txtUsuario.Text = "";
            //    txtPasswword.Text = "";
            //}
            //else
            //{
            //    Response.Write("<script>alert('USUARIO INCORRECTO')</script>");
            //    txtUsuario.Text = "";
            //    txtPasswword.Text = "";
            //}

            Empleado objEmpleado = EmpleadoLN.getInstance().AccesoSistema(txtUsuario.Text, txtPasswword.Text);

            if (objEmpleado != null)
            {
                //Response.Write("<script>alert('USUARIO CORRECTO!...')</script>");
                Response.Redirect("PanelGeneral.aspx");
            }
            else
            {
                Response.Write("<script>alert('USUARIO INCORRECTO!!!')</script>");
                txtUsuario.Text = "";
                txtPasswword.Text = "";
            }
        }
    }
}