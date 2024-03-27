using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cargamos el DropDownListBox y el CheckBoxList cuando postback es false(Una sola vez)
            if(IsPostBack == false)
            {
                ddlMemoria.Items.Add("2 GB");
                ddlMemoria.Items.Add("4 GB");
                ddlMemoria.Items.Add("6 GB");
                cblAccesorios.Items.Add("Monitor LCD");
                cblAccesorios.Items.Add("HD 500GB");
                cblAccesorios.Items.Add("Grabador DVD");
            }
        }


        double CalculadorPrecioFinal(int mem, int[] vec)
        {
            double precioFInal = 0;

            //Busca que selecciono el usuario y le asigna un monto al precio final
            if(mem == 0)
            {
                precioFInal += 200;
            }
            else if(mem == 1)
            {
                precioFInal += 375;
            }
            else
            {
                precioFInal += 500;
            }

            //Busca que opciones eligio el usuario y asigna el monto segun la eleccion.
            if(vec[0] == 1)
            {
                precioFInal += 2000.50;
                if(vec[1] == 1)
                {
                    precioFInal += 550.50;
                    if(vec[2] == 1)
                    {
                        precioFInal += 1200;
                    }
                }
            }
            else if(vec[1] == 1)
            {
                precioFInal += 550.50;
                if (vec[2] == 1)
                {
                    precioFInal += 1200;
                }
            }
            else if(vec[2] == 1)
            {
                precioFInal += 1200;
            }
            //Devuelve con la suma ya hecha, segun la selecciond el usuario
            return precioFInal;
        }

        protected void btnPrecio_Click(object sender, EventArgs e)
        {
            double precioFinal = 0;
            int cant = cblAccesorios.Items.Count;
            int[] vec = new int[3];

            //Usamos el vector como bandera, para determinar que selecciono y que no.
            for(int i = 0;i < cant; i++){
                if (cblAccesorios.Items[i].Selected)
                {
                    vec[i] = 1;
                }
                else
                {
                    vec[i] = 0;
                }
            }

            //Llamamos a la funcion que calcula, y devuelve el precio final para mostrarlo despues.
            precioFinal = CalculadorPrecioFinal(ddlMemoria.SelectedIndex, vec);
            
            lblFinal.Text = "El precio final es: " + precioFinal;
        }
    }
}