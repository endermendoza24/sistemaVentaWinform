using Facturacion.Datos;
using Facturacion.Formularios;
using Facturacion.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class frmEmpleados : Form
    {
        private string idEmpleado = null;
        int posicion, id;
        clsCRUD_Empleados emple = new clsCRUD_Empleados();
        clsLogica logi = new clsLogica();

        private void MostrarEmpleado()
        {
            dtgEmpleado.DataSource = emple.mostrarProd();
        }


        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea guardar?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //try
                //{
                    string cedu, nombre, apell;
                    DateTime fcha;

                    cedu = txtCedula.Text;
                    nombre = txtNombre.Text;
                    apell = txtApellido.Text;

                    fcha = dtFecha.Value;



                    emple.InsertarEmpleado(cedu, nombre, apell, fcha);
                    btnBorrarEmpleado.Enabled = true;
                    btnEditar.Enabled = true;
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Ha ocurrido un error","Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                //}
                Limpiar();
            }
            }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsetEmpleado.catEmpleados' Puede moverla o quitarla según sea necesario.
            this.catEmpleadosTableAdapter.Fill(this.dtsetEmpleado.catEmpleados);
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnBorrarEmpleado.Enabled = false;

        }

        private void btnBorrarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgEmpleado.SelectedRows.Count > 0)
                {
                    idEmpleado = dtgEmpleado.CurrentRow.Cells["idEmpleado"].Value.ToString();
                    emple.Eliminar(idEmpleado);
                    MostrarEmpleado();
                    MessageBox.Show("Eliminado correctamente");

                }
                else
                    MessageBox.Show("seleccione una fila por favor");
        }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado, dato está enlazado.");
            }
            Limpiar();
        }

        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea modificar este elemento?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string cedu, nombre, apell;

                    cedu = txtCedula.Text;
                    nombre = txtNombre.Text;
                    apell = txtApellido.Text;


                    emple.EditarEmpleado(id, cedu, nombre, apell);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error );
                }

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
            txtNombre.SelectionStart = txtNombre.Text.Length;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellido.Text);
            txtApellido.SelectionStart = txtApellido.Text.Length;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCedula.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text))
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }
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

        

        

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmInicio ini = new frmInicio();
            ini.Show();
        }

        private void clientesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmClientes cl = new frmClientes();
            cl.Show();

        }

        private void marcasToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea salir?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }

        }

        private void dtgEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgEmpleado.CurrentRow.Index;
            id = Convert.ToInt32(dtgEmpleado[0, posicion].Value.ToString());
            txtCedula.Text = dtgEmpleado[1, posicion].Value.ToString();
            txtNombre.Text = dtgEmpleado[2, posicion].Value.ToString();
            txtApellido.Text = dtgEmpleado[3, posicion].Value.ToString();
        }
    }
}
