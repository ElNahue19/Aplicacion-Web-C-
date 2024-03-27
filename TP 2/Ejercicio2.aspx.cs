using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //Llenamos de datos el DropDownList y el CheckBoxList. Cuando el postBack es false.
                ddlCiudad.Items.Add("Gral. Pacheco");
                ddlCiudad.Items.Add("San Migel");
                ddlCiudad.Items.Add("Boedo");
                cblTemas.Items.Add("Ciencias");
                cblTemas.Items.Add("Literatura");
                cblTemas.Items.Add("Historia");
            }
        }

        //Determinamos la Zona
        string determinadorZona(string partido)
        {
            string zona;

            if (partido == "Gral. Pacheco")
            {
                zona = "Norte";
            }
            else if (partido == "San Migel")
            {
                zona = "Oeste";
            }
            else
            {
                zona = "Sur";
            }

            return zona;
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string zona;
            string temas = "";

            //Llamamos a la funcion.
            zona = determinadorZona(ddlCiudad.SelectedItem.Text);
            

            //Determina los items seleccionados, y los arma en el string separados por "-", para que cuando lleguen
            //A la otra pagina, los detecte y los tranforme en "<br>" que seria un salto de linea en html.
            int cant = cblTemas.Items.Count;
            for (int i = 0; i < cant; i++)
            {
                if (cblTemas.Items[i].Selected)
                {
                    temas += " - " + cblTemas.Items[i].Text;
                }
            }





            //Redirigue el codigo
            Response.Redirect("Ejercicio2b.aspx?Nom="+tbNombre.Text+"&Ape="+tbApellido.Text+"&Zona="+zona+"&Tema="+temas);


        }
    }
}