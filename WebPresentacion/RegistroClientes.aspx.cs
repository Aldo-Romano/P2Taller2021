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
    public partial class RegistroClientes : System.Web.UI.Page
    {
        LogicaNegocios obj1 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==false)
            {
                obj1 = new LogicaNegocios();
                Session["obj1"] = obj1;

            }
            else
            {
                obj1 = (LogicaNegocios)Session["obj1"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Clientes temp = new Clientes()
            {
                nombre = txtNombre.Text,
                app = txtApp.Text,
                apm = txtApm.Text,
                celular = txtcelular.Text,
                telOficina = txtTelOficina.Text,
                correoPer = txtCorreoPer.Text,
                correoCorp = txtCorreoCorp.Text
            };

            string ms = "";
            obj1.InsertarClientes(temp, ref ms);
            txtApp.Text = ms;
        }
    }
}