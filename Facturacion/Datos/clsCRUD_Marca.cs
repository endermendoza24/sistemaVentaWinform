using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Facturacion.Datos
{
    public class clsCRUD_Marca
    {
        SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True");
        private clsConexionSQL conet = new clsConexionSQL();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

       

        public DataTable MostrarMarca()
        {

            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "SELECT * FROM catMarcas";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conet.CerrarConexion();
            return tabla;
        }

        //  insertar marca
        public void InsertarMarca(string nombreMarca)
        {
            SqlCommand agregar = new SqlCommand("insert into catMarcas(nombreMarca) Values(@nombreMarca)", conexion);
            conexion.Open();

            agregar.Parameters.Clear();
            agregar.Parameters.AddWithValue("@nombreMarca", nombreMarca);
           
            agregar.ExecuteNonQuery();
        }


        //  editar la marca
        public void EditarMarcas(int idMarcas, string nombreMarca)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "editarMarcas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idMarca", idMarcas);
            comando.Parameters.AddWithValue("@nombreMarca", nombreMarca);            

            comando.ExecuteNonQuery();
        }
        //  eliminar marca
        public void Eliminar(string idMarca)
        {
            comando.Connection = conet.AbrirConexion();
            comando.CommandText = "DELETE FROM catMarcas WHERE idMarca = @idMarca";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idMarca", idMarca);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conet.CerrarConexion();

        }

        
    }
}
