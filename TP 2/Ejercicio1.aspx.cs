using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTabla_Click(object sender, EventArgs e)
        {
            int numCant1 = int.Parse(tbCantidad1.Text);
            int numCant2 = int.Parse(tbCantidad2.Text);

            //Creacion y manejo de la tabla
            string tabla = "<table border ='1'>";
            tabla += " <tr> <td>Producto</td> <td>Cantidad</td> </tr>";

            tabla += "<tr>";
            tabla += "<td>" + tbNombre1.Text + "</td>";
            tabla += "<td>" + numCant1 + "</td>";
            tabla += "</tr>";
            tabla += "<tr>";
            tabla += "<td>" + tbNombre2.Text + "</td>";
            tabla += "<td>" + numCant2 + "</td>";
            tabla += "</tr>";
            tabla += "<tr>";
            tabla += "<td>Total</td>";
            int total = numCant1 + numCant2;
            tabla += "<td>" + total + "</td>";
            tabla += "</tr>";

            lblTabla.Text = tabla;

        }
    }
}