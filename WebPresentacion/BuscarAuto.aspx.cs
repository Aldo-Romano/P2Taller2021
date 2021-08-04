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
    public partial class MuestraAutoDelCliente : System.Web.UI.Page
    {
        LogicaNegocios oblog = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                oblog = new LogicaNegocios();
                Session["oblog"] = oblog;
            }
            else
            {
                oblog = (LogicaNegocios)Session["oblog"];
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string a = "";
            GridView1.DataSource = oblog.DatosGridNom(txtNombre.Text, txtApp.Text, txtApm.Text, ref a);
            GridView1.DataBind();
            // Response.Redirect(a);
        }
    }
}