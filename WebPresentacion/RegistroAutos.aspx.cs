using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassEntidades;
using ClassLogicaNegocios;

namespace WebPresentacion
{
    public partial class RegistroAutos : System.Web.UI.Page
    {
        LogicaNegocios objlog = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                objlog = new LogicaNegocios();
                Session["objlog"] = objlog;
            }
            else
            {
                objlog = (LogicaNegocios)Session["objlog"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Autos temp = new Autos
            {
                f_marca = Convert.ToInt16(dlF_marca.SelectedItem.Value),
                modelo = txtModelo.Text,
                año = txtAño.Text,
                color = txtcolor.Text,
                placas = txtPlacas.Text,
                dueño = Convert.ToInt16(dlDueño.SelectedItem.Value)
            };
            string a = "";
            objlog.InsertarAutos(temp, ref a);
            txtModelo.Text = a;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}