using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Facturacion.Datos
{
   public class clsCRUD_Articulos
    {
        SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True");
        private clsConexionSQL conet = new clsConexionSQL();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarArticulo()
        {

            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "Mostrar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conet.CerrarConexion();
            return tabla;
        }

        //  insertar articulo

        public void InsertarArticulo(string nombreArticulo, string categoria, int idProveedores, int idMarca)
        {
            SqlCommand agregar = new SqlCommand("insert into catArticulos(nombreArticulo, categoria, idProveedores, idMarca) Values(@nombreArticulo, @categoria, @idProveedores, @idMarca)", conexion);
            conexion.Open();

            agregar.Parameters.Clear();
            agregar.Parameters.AddWithValue("@nombreArticulo", nombreArticulo);
            agregar.Parameters.AddWithValue("@categoria", categoria);
            agregar.Parameters.AddWithValue("@idProveedores", idProveedores);
            agregar.Parameters.AddWithValue("@idMarca", idMarca);

            agregar.ExecuteNonQuery();
            conexion.Close();
        }


        public void EditarArticulo(int idArticulo, string nombreArticulo, string categoria, int idProveedor, int idMarca)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "EditarArticulos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idArticulo", idArticulo);
            comando.Parameters.AddWithValue("@nombreArticulo", nombreArticulo);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@idProveedor", idProveedor);
            comando.Parameters.AddWithValue("@idMarca", idMarca);

            comando.ExecuteNonQuery();
            conet.CerrarConexion();

        }
        public void Eliminar(string idArticulo)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "DELETE FROM catArticulos where idArticulo = @idArticulo";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idArticulo", idArticulo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conet.CerrarConexion();

        }

        //public void EliminarTotales()
        //{
        //    comando.Connection = conet.AbrirConexion();
        //    comando.CommandText = "EliminarTotales";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    leer = comando.ExecuteReader();

        //    conet.CerrarConexion();

        //}
    }
}

