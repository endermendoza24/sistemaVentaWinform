using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Facturacion.Datos
{
    public class clsConexionSQL
    {
        SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True");
        public  SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        readonly string connectionstring;
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }

        //  factura 
        public static DataSet QueryConsultaDataSet(string Q)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True");
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand(Q, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                con.Open();
                da.Fill(ds);
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
    }
}
