using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Facturacion.Datos
{
    public class clsCRUD_Clientes
    {
        SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True");
        private clsConexionSQL conet = new clsConexionSQL();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCliente()
        {

            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "SELECT * FROM tblClientes";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conet.CerrarConexion();
            return tabla;
        }



        public void EditarCliente(int idCliente, string numCedula, string primerNombre, string primerApellido)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "editarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@numCedula", numCedula);
            comando.Parameters.AddWithValue("@primerNombre", primerNombre);
            comando.Parameters.AddWithValue("@primerApellido", primerApellido);


            comando.ExecuteNonQuery();

        }
        public void Eliminar(string idCliente)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "DELETE FROM tblClientes WHERE idCliente = @idCliente";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conet.CerrarConexion();

        }

        public void InsertarCliente(string numCedula, string primerNombre, string primerApellido)
        {
            SqlCommand agregar = new SqlCommand("insert into tblClientes(numCedula, primerNombre, primerApellido) values(@numCedula, @primerNombre, @primerApellido)", conexion);
            conexion.Open();

            agregar.Parameters.Clear();
            agregar.Parameters.AddWithValue("@numCedula", numCedula);
            agregar.Parameters.AddWithValue("@primerNombre", primerNombre);
            agregar.Parameters.AddWithValue("@primerApellido", primerApellido);            
            agregar.ExecuteNonQuery();
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
