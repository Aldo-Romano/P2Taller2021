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
    public partial class MuestraAutos : System.Web.UI.Page
    {
        LogicaNegocios oblog = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                oblog = new LogicaNegocios();
                Session["oblog"] = oblog;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = "";
            GridView1.DataSource = oblog.DatosGrid(ref a);
            GridView1.DataBind();
            Response.Redirect(a);

        }
    }
}