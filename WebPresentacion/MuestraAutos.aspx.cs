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

        protected void Button2_Click(object sender, EventArgs e)
        {
            string a = "";
            GridView1.DataSource = objlog.DevuelveAutosID(ref a);
            GridView1.DataBind();
        }
    }
}