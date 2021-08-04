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
            if(txtNombre.Text != "" && txtApp.Text != "" && txtApm.Text != "" && txtcelular.Text != "" && txtTelOficina.Text != "" && txtCorreoPer.Text != "" && txtCorreoCorp.Text != "")
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
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msg1", "msbox('¡Insertado!','"+ms+ "','success')", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msg2", "msbox('¡Error!','Inserte todos los datos','error')", true);
            }

           
        }
    }
}