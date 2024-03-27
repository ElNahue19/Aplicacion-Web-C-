using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Validamos que el nombre y contrase sean las que deben ser.
        protected void btnValidar_Click(object sender, EventArgs e)
        {
            if(tbNombre.Text == "claudio" && tbApellido.Text == "casas")
            {
                //Si cumple, redirecciona a la pagina donde da la bienvenida, llevado el nombre en la URL.
                Response.Redirect("Ejercicio4b.aspx?Nom=" + tbNombre.Text);
            }
            else
            {
                //Si no, redirecciona a otra pagina donde dice que el usuario es incorrecto.
                Response.Redirect("Ejercicio4c.aspx");
            }
        }
    }
}