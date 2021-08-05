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
    public partial class RevisionEnAutos : System.Web.UI.Page
    {
        LogicaNegocios obj1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                obj1 = new LogicaNegocios();
                Session["obj1"] = obj1;
                AutoDrop();
                MecDrop();

            }
            else
            {
                obj1 = (LogicaNegocios)Session["obj1"];
            }
        }

        public void AutoDrop()
        {
            List<Autos> listaA = null;
            string m = "";
            listaA = obj1.DevuelveAutosID(ref m);

            //txtModelo.Text = m;
            if (listaA != null)
            {
                AutosId.Items.Clear();
                foreach (Autos a in listaA)
                {
                    AutosId.Items.Add(new ListItem(a.placas, a.id_Auto.ToString()));
                }
            }
        }
        public void MecDrop()
        {
            List<Mecanicos> listaA = null;
            string m = "";
            listaA = obj1.DevuelveMecanicoID(ref m);

            //txtModelo.Text = m;
            if (listaA != null)
            {
                MecanicosId.Items.Clear();
                foreach (Mecanicos a in listaA)
                {
                    MecanicosId.Items.Add(new ListItem(a.Nombre, a.id_Tecnico.ToString()));
                }
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Calendar1.ToString() != "" && txtFalla.Text != "" && txtDiag.Text != "")
            {
                Revisiones temp = new Revisiones()
                {
                    Entrada = Calendar1.SelectedDate,
                    Falla= txtFalla.Text,
                    diagnostico= txtDiag.Text,
                    Autorizacion = Convert.ToByte(dlAutori.SelectedValue),
                    Auto = Convert.ToInt16(AutosId.SelectedValue),
                    Mecanico= Convert.ToInt16(MecanicosId.SelectedValue)
                };

                string ms = "";
                obj1.InsertarRevisiones(temp, ref ms);

               Page.ClientScript.RegisterStartupScript(this.GetType(), "msg1", "msbox('¡Insertado!','" + ms + "','success')", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msg2", "msbox('¡Error!','Inserte todos los datos','error')", true);
            }
        }
    }
}