using Facturacion.Datos;
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

        private void MostrarCliente()
        {
            dtgCliente.DataSource = clien.MostrarCliente();
        }


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


                    MostrarCliente();


                    clien.InsertarCliente(cedu, nombre, apell);

                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            MostrarCliente();

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
                    MostrarCliente();
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
                MostrarCliente();
                if (dtgCliente.SelectedRows.Count > 0)
                {
                    idCliente = dtgCliente.CurrentRow.Cells["idCliente"].Value.ToString();
                    clien.Eliminar(idCliente);
                    MostrarCliente();
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
