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
                MarcasDrop();
                DueDrop();

            }
            else
            {
                objlog = (LogicaNegocios)Session["objlog"];

            }
        }

        public void MarcasDrop()
        {
            List<Marcas> listaA = null;
            string m = "";
            listaA = objlog.DevuelveMarcasID(ref m);

            //txtModelo.Text = m;
            if(listaA != null)
            {
                dlF_marca.Items.Clear();
                foreach(Marcas a in listaA)
                {
                    dlF_marca.Items.Add(new ListItem(a.marca, a.id_marca.ToString()));
                }
            }
        }

        public void DueDrop()
        {
            List<Clientes> listaA = null;
            string m = "";
            listaA = objlog.DevuelveClientesID(ref m);

            //txtModelo.Text = m;
            if (listaA != null)
            {
                dlDueño.Items.Clear();
                foreach (Clientes a in listaA)
                {
                    dlDueño.Items.Add(new ListItem(a.nombre, a.id_cliente.ToString()));
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Autos temp = new Autos
            {
                f_marca = Convert.ToInt16(dlF_marca.SelectedValue),
                modelo = txtModelo.Text,
                año = txtAño.Text,
                color = txtcolor.Text,
                placas = txtPlacas.Text,
                dueño = Convert.ToInt16(dlDueño.SelectedValue)
            };
            string a = "";
            objlog.InsertarAutos(temp, ref a);
            txtModelo.Text = a;
        }
    }
}