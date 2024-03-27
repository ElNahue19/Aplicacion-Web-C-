using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creamos las variablse para que almacenen lo que se recibe.
            string nombre;
            string apellido;
            string zona;
            string tema;

            //Recibimos lo que se manda por la URL y lo asignamos a las variables.
            nombre = Request.QueryString["Nom"];
            apellido = Request.QueryString["Ape"];
            zona = Request.QueryString["Zona"];
            tema = Request.QueryString["Tema"];

            //Asignamos las variables al texto del label.
            lbl1.Text = nombre;
            lbl2.Text = apellido;
            lbl3.Text = zona;

            //Remplazamos lo que llega desde la otra pagina - , por saltos de linea.
            lbl4.Text = tema.Replace("-", "<br>");
            
        }
    }
}