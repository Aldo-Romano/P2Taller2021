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
    public partial class RevisionAutos : System.Web.UI.Page
    {
        LogicaNegocios obj1 = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                obj1 = new LogicaNegocios();
                Session["obj1"] = obj1;
               RepDrop();
            }
            else
            {
                obj1 = (LogicaNegocios)Session["obj1"];
            }
        }

        public void RepDrop()
        {
            List<Revisiones> listaA = null;
            string m = "";
            listaA = obj1.DevuelveRevisionID(ref m);

            //txtModelo.Text = m;
            if (listaA != null)
            {
                dlRevi.Items.Clear();
                foreach (Revisiones a in listaA)
                {
                    dlRevi.Items.Add(new ListItem(a.diagnostico, a.id_Revision.ToString()));
                }
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDetalles.Text != "" && txtGar.Text != "")
            {
                Reparaciones temp = new Reparaciones()
                {
                    detalles = txtDetalles.Text,
                    garantia = txtGar.Text,
                    salida = Calendar1.SelectedDate,
                   // Fk_revision = 1
                    Fk_revision = Convert.ToInt16(dlRevi.SelectedValue)
                
                };

                string ms = "";
                obj1.InsertarReparaciones(temp, ref ms);

                Page.ClientScript.RegisterStartupScript(this.GetType(), "msg1", "msbox('¡Insertado!','" + ms + "','success')", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msg2", "msbox('¡Error!','Inserte todos los datos','error')", true);
            }
        }
    }
}