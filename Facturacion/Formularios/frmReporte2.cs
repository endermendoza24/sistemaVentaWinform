using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion.Formularios;

namespace Facturacion
{
    public partial class frmReporte2 : Form
    {
        public frmReporte2()
        {
            InitializeComponent();
        }

        private void frmReporte2_Load(object sender, EventArgs e)
        {
            btnFact.Enabled = false;
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = 1;
                valor = Convert.ToInt32(txtFact.Text);

                // TODO: esta línea de código carga datos en la tabla 'Ds.tblFac' Puede moverla o quitarla según sea necesario.
                this.tblFacTableAdapter.Fill(this.Ds.tblFac, valor);

                this.rptFacturar.RefreshReport();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un valor valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtFact_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFact.Text))
            {
                btnFact.Enabled = false;
            }
            else
            {
                btnFact.Enabled = true;
            }
        }
    }
}
