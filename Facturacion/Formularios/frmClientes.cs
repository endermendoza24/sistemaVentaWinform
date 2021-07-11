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
    public partial class frmClientes : Form
    {
        private string idCliente = null;
        int posicion, id;
        clsCRUD_Clientes clien = new clsCRUD_Clientes();
        clsLogica logi = new clsLogica();
       
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea guardar?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string cedu, nombre, apell;
                    

                    cedu = txtCedula.Text;
                    nombre = txtNombre.Text;
                    apell = txtApellido.Text;


                    btnEditar.Enabled = true;
                    btnBorrarCliente.Enabled = true;
                    clien.InsertarCliente(cedu, nombre, apell);                   

                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                Limpiar();
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'almacenTecnoDataSet3.tblClientes' Puede moverla o quitarla según sea necesario.
            this.tblClientesTableAdapter.Fill(this.almacenTecnoDataSet3.tblClientes);
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnBorrarCliente.Enabled = false;
            txtCedula.Focus();

        }

        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
        }

     


        

        private void btnEditar_Click_1(object sender, EventArgs e)
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


                    clien.EditarCliente(id, cedu, nombre, apell);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void btnBorrarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {   
                if (dtgCliente.SelectedRows.Count > 0)
                {
                    idCliente = dtgCliente.CurrentRow.Cells["idCliente"].Value.ToString();
                    clien.Eliminar(idCliente);                    
                    MessageBox.Show("Eliminado correctamente");
                    
                }
                else
                    MessageBox.Show("seleccione una fila por favor");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
            Limpiar();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombre.Text);
            txtNombre.SelectionStart = txtNombre.Text.Length;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtApellido.Text);
            txtApellido.SelectionStart = txtApellido.Text.Length;

            if (String.IsNullOrEmpty(txtCedula.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text))
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }


        }

        private void grbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void dtgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgCliente.CurrentRow.Index;
            id = Convert.ToInt32(dtgCliente[0, posicion].Value.ToString());
            txtCedula.Text = dtgCliente[1, posicion].Value.ToString();
            txtNombre.Text = dtgCliente[2, posicion].Value.ToString();
            txtApellido.Text = dtgCliente[3, posicion].Value.ToString();
        }

       
    }
}
