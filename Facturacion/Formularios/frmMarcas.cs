using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion.Datos;
using System.Configuration;

namespace Facturacion
{
    public partial class frmMarcas : Form
    {
        private string idMarca = null;
        clsCRUD_Marca marca = new clsCRUD_Marca();
        clsConexionSQL conex = new clsConexionSQL();
        int id, posicion;
        
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea guardar?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string nombreMarca;
                    nombreMarca = txtNombreMarca.Text;
                    marca.InsertarMarca(nombreMarca);
                    btnModificar.Enabled = true;
                    btnBorrar.Enabled = true;
                    txtNombreMarca.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgMarca.SelectedRows.Count > 0)
                {
                   idMarca  = dtgMarca.CurrentRow.Cells["idMarca"].Value.ToString();
                    marca.Eliminar(idMarca);                    
                    MessageBox.Show("Eliminado correctamente");
                    txtNombreMarca.Clear();
                }
                else
                    MessageBox.Show("seleccione una fila por favor");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }


        private void dtgMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dtgMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgMarca.CurrentRow.Index;
            id = Convert.ToInt32(dtgMarca[0, posicion].Value.ToString());
            txtNombreMarca.Text = dtgMarca[1, posicion].Value.ToString();           
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'almacenTecnoDataSet1.catMarcas' Puede moverla o quitarla según sea necesario.
            this.catMarcasTableAdapter.Fill(this.almacenTecnoDataSet1.catMarcas);
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private void txtNombreMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNombreMarca_TextChanged(object sender, EventArgs e)
        {
            txtNombreMarca.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombreMarca.Text);
            txtNombreMarca.SelectionStart = txtNombreMarca.Text.Length;

            if (String.IsNullOrEmpty(txtNombreMarca.Text))
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea modificar este elemento?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string nombreMarca;
                    nombreMarca = txtNombreMarca.Text;

                    marca.EditarMarcas(id, nombreMarca);
                    txtNombreMarca.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

      

       
       
    }
}
