using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion.Datos;
using Facturacion.Formularios;

namespace Facturacion
{
    public partial class frmProveedores : Form
    {
        private string idProveedor = null;
        clsCRUD_Proveedores prov = new clsCRUD_Proveedores();
        clsConexionSQL conex = new clsConexionSQL();
        private BindingSource bindingsource1 = new BindingSource();
        private SqlDataAdapter dataatpter = new SqlDataAdapter();

        private void ACtu(string consulta)
        {
            string datasource = @"Data source=.; Initial catalog=AlmacenTecno; Integrated security=True";
            dataatpter = new SqlDataAdapter(consulta, datasource);
            SqlCommandBuilder comando = new SqlCommandBuilder(dataatpter);
            DataTable tabla = new DataTable();
            dataatpter.Fill(tabla);
            bindingsource1.DataSource = tabla;
        }
            
        
        int id, posicion;
        public frmProveedores()
        {
            InitializeComponent();
        }

        public void Agregar()
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea guardar?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string nombreProveedor, correo, telefono, ciudad;
                    nombreProveedor = txtNombre.Text;
                    correo = txtCorreo.Text;
                    telefono = txtTelefono.Text;
                    ciudad = txtCiudad.Text;
                    prov.InsertarProveedor(nombreProveedor, correo, telefono, ciudad);
                    btnEditar.Enabled = true;
                    btnBorrar.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        //  editar los proveedores

        public void Editar()
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea modificar este elemento?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string nombreProveedor, correo, telefono, ciudad;
                    nombreProveedor = txtNombre.Text;
                    correo = txtCorreo.Text;
                    telefono = txtTelefono.Text;
                    ciudad = txtCiudad.Text;
                    prov.EditarProveedor(id, nombreProveedor, correo, telefono, ciudad);
                    //MostrarProveedor();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        //  eliminar
        public void Borrar()
        {
            try
            {
                if (dtgProveedores.SelectedRows.Count > 0)
                {
                    idProveedor = dtgProveedores.CurrentRow.Cells["idProveedor"].Value.ToString();
                    prov.Eliminar(idProveedor);
                    MessageBox.Show("Eliminado correctamente");

                }
                else
                    MessageBox.Show("seleccione una fila por favor");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }

       

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
            
        }

        private void dtgProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgProveedores.CurrentRow.Index;
            id = Convert.ToInt32(dtgProveedores[0, posicion].Value.ToString());
            txtNombre.Text = dtgProveedores[1, posicion].Value.ToString();
            txtCorreo.Text = dtgProveedores[2, posicion].Value.ToString();
            txtTelefono.Text = dtgProveedores[3, posicion].Value.ToString();
            txtCiudad.Text = dtgProveedores[4, posicion].Value.ToString();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'almacenTecnoDataSet.catProveedores' Puede moverla o quitarla según sea necesario.
            this.catProveedoresTableAdapter.Fill(this.almacenTecnoDataSet.catProveedores);
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
            txtNombre.SelectionStart = txtNombre.Text.Length;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {                
                e.Handled = true;
                return;
            }
        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {
            txtCiudad.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtCiudad.Text);
            txtCiudad.SelectionStart = txtCiudad.Text.Length;


            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtCorreo.Text) || String.IsNullOrEmpty(txtTelefono.Text) || String.IsNullOrEmpty(txtCiudad.Text))
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }

        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Agregar();
           
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            ValidarEmail(txtCorreo.Text);
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos art = new frmArticulos();
            art.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClientes cl = new frmClientes();
            cl.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados em = new frmEmpleados();
            em.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas ma = new frmMarcas();
            ma.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores pr = new frmProveedores();
            pr.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas ve = new frmVentas();
            ve.Show();
        }

        private void cerrarSesiònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmInicio ini = new frmInicio();
            ini.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void clientesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmClientes cl = new frmClientes();
            cl.Show();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEmpleados em = new frmEmpleados();
            em.Show();

        }

        private void marcasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMarcas ma = new frmMarcas();
            ma.Show();
        }

        private void ventasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmVentas ve = new frmVentas();
            ve.Show();

        }

        private void cerrarSesiònToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea salir?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        static bool ValidarEmail(string email)
        {
            return email != null && Regex.IsMatch(email, "/^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)$/");
        }
    }
}
