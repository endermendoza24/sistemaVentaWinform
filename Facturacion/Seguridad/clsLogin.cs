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
