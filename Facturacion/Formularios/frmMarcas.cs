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
                    MostrarMarca();
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

        private void MostrarMarca()
        {
            dtgMarca.DataSource = marca.MostrarMarca();
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
            MostrarMarca();
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
                    MostrarMarca();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

      

       
       
    }
}
