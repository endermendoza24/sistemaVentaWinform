﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion.Datos;

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
                //try
                //{
                    string nombreProveedor, correo, telefono, ciudad;
                    nombreProveedor = txtNombre.Text;
                    correo = txtCorreo.Text;
                    telefono = txtTelefono.Text;
                    ciudad = txtCiudad.Text;
                    prov.InsertarProveedor(nombreProveedor, correo, telefono, ciudad);
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Ha ocurrido un error", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                //}

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
          
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
            
        }

        
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Agregar();
           
        }

       
    }
}