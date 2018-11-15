using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
            txtTipoCultivo.Text = "";
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            var parcela = new Parcela();

            var odb = OdbFactory.Open("C:\\Users\\PC08\\Documents\\GitHub\\Agricultores.db");

            odb.Store(parcela);
            odb.Close();
        }
    }
}