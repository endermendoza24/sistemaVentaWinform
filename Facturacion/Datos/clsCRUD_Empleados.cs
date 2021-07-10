using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Facturacion.Datos
{
    public class clsCRUD_Empleados
    {
        SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True");
        private clsConexionSQL conet = new clsConexionSQL();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarEmpleado()
        {

            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "SELECT * FROM catEmpleados";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conet.CerrarConexion();
            return tabla;
        }



        public void EditarEmpleado(int idEmpleado, string numCedula, string primerNombre, string primerApellido)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "editarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@numCedula", numCedula);
            comando.Parameters.AddWithValue("@nombre", primerNombre);
            comando.Parameters.AddWithValue("@apellido", primerApellido);
            

            comando.ExecuteNonQuery();
            conet.CerrarConexion();

        }
        public void Eliminar(string idEmpleado)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "DELETE FROM catEmpleados WHERE idEmpleado = @idEmpleado";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conet.CerrarConexion();

        }

       public void InsertarEmpleado(string numCedula, string primerNombre, string primerApellido, DateTime fechaEntrada)
        {
            SqlCommand agregar = new SqlCommand("insert into catEmpleados(numCedula, primerNombre, primerApellido, fechaEntrada) values(@numCedula, @primerNombre, @primerApellido, @fechaEntrada)", conexion);
            conexion.Open();

            agregar.Parameters.Clear();
            agregar.Parameters.AddWithValue("@numCedula", numCedula);
            agregar.Parameters.AddWithValue("@primerNombre", primerNombre);
            agregar.Parameters.AddWithValue("@primerApellido", primerApellido);
            agregar.Parameters.AddWithValue("@fechaEntrada", fechaEntrada);
            agregar.ExecuteNonQuery();
        }

        public DataTable mostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = MostrarEmpleado();
            return tabla;
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

