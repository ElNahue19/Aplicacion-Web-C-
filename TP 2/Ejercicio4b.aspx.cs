using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class Ejercicio4b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creamos la variable que recibe el dato de URL y recibimos el mismo
            string nombre;
            nombre = Request.QueryString["Nom"];
            //Cambiamos la primer letra del nombre a mayuscula y lo guardamos en resultado para mostrarlo.
            string resultado = char.ToUpper(nombre[0]) + nombre.Substring(1);
            lblNombre.Text = resultado;
        }
    }
}