using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Facturacion.Datos;

namespace Facturacion
{
    public partial class frmArticulos : Form
    {
        private string idArticulo = null;
        int posicion, id;
        clsCRUD_Articulos arti = new clsCRUD_Articulos();
        //clsLogica logi = new clsLogica();
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'almacenTecnoDataSet2.catArticulos' Puede moverla o quitarla según sea necesario.
            this.catArticulosTableAdapter1.Fill(this.almacenTecnoDataSet2.catArticulos);
            // TODO: esta línea de código carga datos en la tabla 'dtsetArticulos.catArticulos' Puede moverla o quitarla según sea necesario.
            this.catArticulosTableAdapter.Fill(this.dtsetArticulos.catArticulos);
            // TODO: esta línea de código carga datos en la tabla 'almacenTecnoDataSet1.catMarcas' Puede moverla o quitarla según sea necesario.
            this.catMarcasTableAdapter.Fill(this.almacenTecnoDataSet1.catMarcas);
            // TODO: esta línea de código carga datos en la tabla 'almacenTecnoDataSet.catProveedores' Puede moverla o quitarla según sea necesario.
            this.catProveedoresTableAdapter.Fill(this.almacenTecnoDataSet.catProveedores);

        }

        //  funci[on de guardar

        public void Guardar()
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea guardar?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string nombreArt, categoria;
                    int idProv, idMarca;


                    nombreArt = txtArticulo.Text;
                    categoria = cmbCategoria.Text;
                    idProv = Convert.ToInt32(cmbProveedor.SelectedValue);
                    idMarca = Convert.ToInt32(cmbMarca.SelectedValue);


                    arti.InsertarArticulo(nombreArt, categoria, idProv, idMarca);

            }
                catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            }
        }

        //  editar
        public void Editar()
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea modificar este elemento?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string nombreArt, categoria;
                    int idProv, idMarca;

                    nombreArt = txtArticulo.Text;
                    categoria = cmbCategoria.Text;
                    idProv = Convert.ToInt32(cmbProveedor.SelectedValue);
                    idMarca = Convert.ToInt32(cmbMarca.SelectedValue);

                    arti.EditarArticulo(id, nombreArt, categoria, idProv, idMarca);
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error" + ex, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        

        private void dtgArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgArticulos.CurrentRow.Index;
            id = Convert.ToInt32(dtgArticulos[0, posicion].Value.ToString());
            txtArticulo.Text = dtgArticulos[1, posicion].Value.ToString();
            cmbCategoria.Text = dtgArticulos[2, posicion].Value.ToString();
            cmbProveedor.SelectedValue = dtgArticulos[3, posicion].Value.ToString();
            cmbMarca.SelectedValue = dtgArticulos[4, posicion].Value.ToString();
        }
        //  borrar
        public void Borrar()
        {
            try
            {

                if (dtgArticulos.SelectedRows.Count > 0)
                {
                    idArticulo = dtgArticulos.CurrentRow.Cells["idArticuloDataGridViewTextBoxColumn"].Value.ToString();
                    arti.Eliminar(idArticulo);
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
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {
            txtArticulo.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtArticulo.Text);
            txtArticulo.SelectionStart = txtArticulo.Text.Length;
        }

        private void txtArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
