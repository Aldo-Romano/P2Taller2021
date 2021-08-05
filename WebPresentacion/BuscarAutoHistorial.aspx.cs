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
    public partial class BuscarAutoHistorial : System.Web.UI.Page
    {
        LogicaNegocios obj1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                obj1 = new LogicaNegocios();
                Session["obj1"] = obj1;

            }
            else
            {
                obj1 = (LogicaNegocios)Session["obj1"];
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string a = "";
            gvHAut.DataSource = obj1.GridHistAuto(txtPlacas.Text, ref a);
            gvHAut.DataBind();
        }
    }
}