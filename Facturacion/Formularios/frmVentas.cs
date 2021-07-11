using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Facturacion.Datos;

namespace Facturacion.Formularios
{
    public partial class frmVentas : Form
    {
        //  variables globales
        decimal iva = 0, precio = 0, subtotal = 0, descuento = 0, total=0;
        int cantidad = 0;
        bool bandera;

        //  instancia a otras clases
        private string idVentas = null;
        public int posicion, id;
        clsCRUD_Ventas vent = new clsCRUD_Ventas();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsetVentas.tblVentas' Puede moverla o quitarla según sea necesario.
            this.tblVentasTableAdapter.Fill(this.dtsetVentas.tblVentas);
            // TODO: esta línea de código carga datos en la tabla 'dtsetArticulos.catArticulos' Puede moverla o quitarla según sea necesario.
            this.catArticulosTableAdapter.Fill(this.dtsetArticulos.catArticulos);
            // TODO: esta línea de código carga datos en la tabla 'dtsetEmpleado.catEmpleados' Puede moverla o quitarla según sea necesario.
            this.catEmpleadosTableAdapter.Fill(this.dtsetEmpleado.catEmpleados);
            // TODO: esta línea de código carga datos en la tabla 'almacenTecnoDataSet3.tblClientes' Puede moverla o quitarla según sea necesario.
            this.tblClientesTableAdapter.Fill(this.dtsetCliente.tblClientes);

        }

        //  crear venta

        public void Guardar()
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea guardar?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    DateTime fecha;
                    int idCliente, idEmpleado, idArticulo, cantidad;
                    decimal precio, iva, descuento, total;

                    fecha = dtpFechaVenta.Value;
                    idCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                    idEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);
                    idArticulo = Convert.ToInt32(cmbArticulo.SelectedValue);

                    cantidad = Convert.ToInt32(txtCantidad.Text);
                    precio = Convert.ToDecimal(txtPrecio.Text);
                    iva = Convert.ToDecimal(txtIva.Text);
                    descuento = Convert.ToDecimal(txtDescuento.Text);
                    total = Convert.ToDecimal(txtTotal.Text);

                    vent.CrearVenta(fecha, idCliente, idEmpleado, idArticulo, cantidad,
                        precio, iva, descuento, total);

            }
                catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

           }  

        }

        //  editar venta -- junto a los calculos

        public void Editar()
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea Editar esta venta?", "Usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    DateTime fecha;
                    int idCliente, idEmpleado, idArticulo, cantidad;
                    decimal precio, iva, descuento, total;

                    fecha = dtpFechaVenta.Value;
                    idCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                    idEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);
                    idArticulo = Convert.ToInt32(cmbArticulo.SelectedValue);

                    cantidad = Convert.ToInt32(txtCantidad.Text);
                    precio = Convert.ToDecimal(txtPrecio.Text);
                    iva = Convert.ToDecimal(txtIva.Text);
                    descuento = Convert.ToDecimal(txtDescuento.Text);
                    total = Convert.ToDecimal(txtTotal.Text);

                    vent.EditarVenta(id, fecha, idCliente, idEmpleado, idArticulo, cantidad,
                        precio, iva, descuento, total);

            }
                catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }
        }


        private void txtIva_TextChanged(object sender, EventArgs e)
        {
            //decimal iva = 0, precio = 0, subtotal = 0;
            //int cantidad = 0;

            //cantidad = Convert.ToInt32(txtCantidad.Text);
            //precio = Convert.ToDecimal(txtPrecio.Text);
            //subtotal = precio * cantidad;
            //iva = ((subtotal * 15) / 100) + subtotal;
            //txtIva.Text = Convert.ToString(iva);
        }

        private void dtgVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgVentas.CurrentRow.Index;
            id = Convert.ToInt32(dtgVentas[0, posicion].Value.ToString());
            dtpFechaVenta.Text = dtgVentas[1, posicion].Value.ToString();
            cmbCliente.SelectedValue = dtgVentas[2, posicion].Value.ToString();
            cmbEmpleado.SelectedValue = dtgVentas[3, posicion].Value.ToString();
            cmbArticulo.SelectedValue = dtgVentas[4, posicion].Value.ToString();
            txtCantidad.Text = dtgVentas[4, posicion].Value.ToString();
            txtPrecio.Text = dtgVentas[5, posicion].Value.ToString();
            txtIva.Text = dtgVentas[6, posicion].Value.ToString();
            txtDescuento.Text = dtgVentas[7, posicion].Value.ToString();
            txtTotal.Text = dtgVentas[8, posicion].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if(txtCantidad.Text == "")
            {
                txtCantidad.Text = "0";
            }

            cantidad = Convert.ToInt32(txtCantidad.Text);
            precio = Convert.ToDecimal(txtPrecio.Text);
            subtotal = precio * cantidad;
            iva = ((subtotal * 15) / 100) + subtotal;
            txtIva.Text = Convert.ToString(iva);
            total = iva - descuento;
            txtDescuento.Text = descuento.ToString();
            txtTotal.Text = total.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {               
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            UnPunto(e, txtPrecio.Text);
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "" || txtPrecio.Text == " " || txtPrecio.Text == "   ")
            {
                txtPrecio.Text = "0";
            }

            cantidad = Convert.ToInt32(txtCantidad.Text);
            precio = Convert.ToDecimal(txtPrecio.Text);
            subtotal = precio * cantidad;
            iva = ((subtotal * 15) / 100) + subtotal;
            txtIva.Text = Convert.ToString(iva);
            total = iva - descuento;
            txtDescuento.Text = descuento.ToString();
            txtTotal.Text = total.ToString();
        }

        //  eliminar
        public void Borrar()
        {
            try
            {

                if (dtgVentas.SelectedRows.Count > 0)
                {
                    idVentas = dtgVentas.CurrentRow.Cells["idArticuloDataGridViewTextBoxColumn"].Value.ToString();
                    vent.Eliminar(idVentas);
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


            private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            frmReporte2 rep = new frmReporte2();
            
            rep.Show();

        }


        //  validacion para que solo deje meter un punto
        public void UnPunto(KeyPressEventArgs e, String cadena) // Esta funcion hace que solo se pueda introducir
        {//  Números, punto y coma en los textbox, además de que solo se pueden presionar una vez...
            int contador = 0;
            String caracter = "";
            for (int n = 0; n < cadena.Length; n++)
            {
                caracter = cadena.Substring(n, 1);
                if (caracter == "." || caracter == ",")
                {
                    contador++;
                }
            }

            if (contador == 0)
            {
                bandera = true;
                if ((e.KeyChar == '.') || (e.KeyChar == ',') && bandera)
                {
                    bandera = false;   //ya no acepta otro punto
                    e.Handled = false;//
                }

                else if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;//
                }
            }

            else
            {
                bandera = false;
                e.Handled = true;//
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;//
                }
            }
        }

    }
}
