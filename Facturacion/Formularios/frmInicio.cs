using Facturacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion.Datos;
using System.Windows.Forms;
using Facturacion.Logica;

namespace Facturacion
{
    public partial class frmInicio : Form
    {

       
        public frmInicio()
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
            //frmReporteGeneral rep = new frmReporteGeneral();
            //rep.MdiParent = this;
            //rep.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            tmrHora.Enabled = true;            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmArticulos arti = new frmArticulos();
            arti.Show();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void ptbCliente_Click(object sender, EventArgs e)
        {
            frmClientes cl = new frmClientes();
            cl.Show();
        }

        private void ptbEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados empl = new frmEmpleados();
            empl.Show();
        }

        private void ptbMarca_Click(object sender, EventArgs e)
        {
            frmMarcas ma = new frmMarcas();
            ma.Show();
        }

        private void ptbProveedor_Click(object sender, EventArgs e)
        {
            frmProveedores pro = new frmProveedores();
            pro.Show();
        }

        private void ptbVenta_Click(object sender, EventArgs e)
        {
            frmVentas vent = new frmVentas();
            vent.Show();
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
