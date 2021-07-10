using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Facturacion.Datos
{
    public class clsCRUD_Proveedores
    {
        SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True");
        private clsConexionSQL conet = new clsConexionSQL();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //  esto muestra en el formulario el edatagridview
        //public DataTable MostrarProveedor()
        //{

        //    comando.Connection = conet.AbrirConexion();
        //    comando.CommandText = "SELECT * FROM catProveedores";
        //    comando.CommandType = CommandType.Text;
        //    leer = comando.ExecuteReader();
        //    tabla.Load(leer);
        //    conet.CerrarConexion();
        //    return tabla;
        //}

        //  insertar datos a proveedores

        public void InsertarProveedor(string nombreProveedor, string correo, string telefono, string ciudad)
        {
            SqlCommand agregar = new SqlCommand("insert into catProveedores(nombreProveedor, correo, telefono, ciudad) Values(@nombreProveedor, @correo, @telefono, @ciudad)", conexion);
            conexion.Open();

            agregar.Parameters.Clear();
            agregar.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
            agregar.Parameters.AddWithValue("@correo", correo);
            agregar.Parameters.AddWithValue("@telefono", telefono);
            agregar.Parameters.AddWithValue("@ciudad", ciudad);
            agregar.ExecuteNonQuery();
            conexion.Close();
        }
       
        public void EditarProveedor(int idProveedor, string nombreProveedor, string correo, string telefono, string ciudad)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "editarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", idProveedor);
            comando.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@ciudad", ciudad);

            comando.ExecuteNonQuery();
            conet.CerrarConexion();
        }
        //  este metodo elimina los elementos seleccionados 
        public void Eliminar(string idProveedor)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "DELETE FROM catProveedores WHERE idProveedor = @idProveedor";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idProveedor", idProveedor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conet.CerrarConexion();

        }


    }
}
