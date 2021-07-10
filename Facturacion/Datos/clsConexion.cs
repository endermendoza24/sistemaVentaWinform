using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Facturacion.Logica;

namespace Facturacion.Datos
{
   public class clsConexion
    {
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True");

        public DataTable validacion(clsValidacionUsuario obje)
        {
            SqlCommand command = new SqlCommand("spLogueo", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", obje.Usuario);
            command.Parameters.AddWithValue("@password", obje.Password);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
