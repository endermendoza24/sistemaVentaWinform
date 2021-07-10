using Facturacion.Formularios;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados clientes = new frmEmpleados();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();
            marcas.MdiParent = this;
            marcas.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClientes client = new frmClientes();
            client.MdiParent = this;
            client.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores prov = new frmProveedores();
            prov.MdiParent = this;
            prov.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos arti = new frmArticulos();
            arti.MdiParent = this;
            arti.Show();

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas ven = new frmVentas();
            ven.MdiParent = this;
            ven.Show();
        }

        private void cerrarSesiònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmFacturacion fact = new frmFacturacion();
            //fact.MdiParent = this;
            //fact.Show();
        }
    }
}
