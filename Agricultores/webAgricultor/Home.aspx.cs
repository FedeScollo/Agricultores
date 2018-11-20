using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agricultores;
using NDatabase;

namespace webAgricultor
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCapataz.Text = "";
            txtHCultivadas.Text = "";
            txtHLibres.Text = "";
            txtNroParcela.Text = "";
            txtSilo.Text = "";
            txtTamanio.Text = "";
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            var capataz = new Capataz(txtCapataz.Text);
            var cultivo = Convert.ToString(ddlTipoCultivo.SelectedValue);
            var silo = new Silo(Convert.ToInt32(txtSilo.Text));

            var parcela = new Parcela(capataz, Convert.ToInt32(txtHCultivadas.Text), Convert.ToInt32(txtHLibres.Text), Convert.ToInt32(txtNroParcela.Text), silo, Convert.ToInt32(txtTamanio.Text), cultivo);
            using (var odb = OdbFactory.Open("D:\\Agricultores\\Agricultores.db")) 
            {
                odb.Store(parcela);
            }
        }
    }
}