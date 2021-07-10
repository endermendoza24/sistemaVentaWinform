using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Facturacion.Seguridad
{
   public class clsLogin
    {
        private string cadena = "Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True";

        SqlConnection conexion = new SqlConnection("Data Source=.; Initial Catalog=AlmacenTecno;Integrated Security=True");     
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public Boolean IniciarSesion(string Usuario, string Password)
        {
            SqlConnection conex = new SqlConnection(cadena);
            conex.Open();

            SqlParameter parnom = new SqlParameter("@Usuario", Usuario);
            SqlParameter parpass = new SqlParameter("@Password", Password);
            SqlCommand comando = new SqlCommand("SELECT * FROM tblUsuarios WHERE Usuario = @Usuario AND Password = @Password",conex);

            comando.Parameters.Add(parnom);
            comando.Parameters.Add(parpass);
            return true;

        }

        
    }
}
