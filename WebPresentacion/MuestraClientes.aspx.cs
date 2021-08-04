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
    public partial class MuestraClientes : System.Web.UI.Page
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
                oblog = (LogicaNegocios)Session["obj1"];
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string a = "";
            GridView1.DataSource = oblog.DevuelveClientesID(ref a);
            GridView1.DataBind();
        }
    }
}