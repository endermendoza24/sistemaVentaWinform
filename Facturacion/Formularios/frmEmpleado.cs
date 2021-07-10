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
                try
                {
                    string cedu, nombre, apell;
                    DateTime fcha;

                    cedu = txtCedula.Text;
                    nombre = txtNombre.Text;
                    apell = txtApellido.Text;

                    fcha = dtFecha.Value;



                    emple.InsertarEmpleado(cedu, nombre, apell, fcha);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error","Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                
            }
            }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleado();
           
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
                MessageBox.Show("Ocurrio un error inesperado");
            }
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
