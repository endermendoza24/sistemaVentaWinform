using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Facturacion.Datos
{
    public class clsCRUD_Ventas
    {
        SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True");
        private clsConexionSQL conet = new clsConexionSQL();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void CrearVenta(DateTime fecha, int  idCliente, int idEmpleado, int  idArticulo, int cantidad, decimal precio, decimal iva, decimal descuento, decimal total)
        {
            SqlCommand agregar = new SqlCommand("insert into tblVentas(fecha, idCliente, idEmpleado, idArticulo, cantidad, precio, iva, descuento, total) Values(@fecha, @idCliente, @idEmpleado, @idArticulo, @cantidad, @precio, @iva, @descuento, @total)", conexion);
            conexion.Open();

            agregar.Parameters.Clear();
            agregar.Parameters.AddWithValue("@fecha", fecha);
            agregar.Parameters.AddWithValue("@idCliente", idCliente);
            agregar.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            agregar.Parameters.AddWithValue("@idArticulo", idArticulo);
            agregar.Parameters.AddWithValue("@cantidad", cantidad);
            agregar.Parameters.AddWithValue("@precio", precio);
            agregar.Parameters.AddWithValue("@iva", iva);
            agregar.Parameters.AddWithValue("@descuento", descuento);
            agregar.Parameters.AddWithValue("@total", total);
            agregar.ExecuteNonQuery();
            conexion.Close();
        }

        //  editar la v enta


        public void EditarVenta(int idVentas, DateTime fecha, int idCliente,
            int idEmpleado, int idArticulo, int cantidad, decimal precio, 
            decimal iva, decimal descuento, decimal total)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "editarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idVentas", idVentas);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@idArticulo", idArticulo);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@iva", iva);
            comando.Parameters.AddWithValue("@descuento", descuento);
            comando.Parameters.AddWithValue("@total", total);

            comando.ExecuteNonQuery();
            conet.CerrarConexion();

        }
        //  borra venta
        public void Eliminar(string idVentas)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "DELETE FROM tblVentas WHERE idVentas = @idventas";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idVentas", idVentas);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conet.CerrarConexion();

        }
    }
}
