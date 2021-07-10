using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion.Datos;
using System.Data.SqlClient;

namespace Facturacion.Logica
{
    public class clsUsuarios
    {
        clsConexion data = new clsConexion();

        public DataTable clsUsuario(clsValidacionUsuario obje)
        {
            return data.validacion(obje);
        }
    }
}
