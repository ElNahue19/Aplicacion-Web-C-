using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Configuramos todos los clicks, para que se coloque el Label del color que se seleccione.
        protected void lbRojo_Click(object sender, EventArgs e)
        {
            lbColor.ForeColor = System.Drawing.Color.Red;
        }

        protected void lbVerde_Click(object sender, EventArgs e)
        {
            lbColor.ForeColor = System.Drawing.Color.Green;
        }

        protected void lbAzul_Click(object sender, EventArgs e)
        {
            lbColor.ForeColor = System.Drawing.Color.Blue;
        }
    }
}