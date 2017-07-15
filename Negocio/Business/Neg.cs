using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DAO;

namespace Negocio.Business
{
    public class Neg
    {
        SqlServerConexion sqlcnn = new SqlServerConexion();

        public void setIngresoLuchador(string rut, string nombre, string apellido, DateTime fechaNac, string cinturon, DateTime fechaIngreso, string direccion )
        {
            sqlcnn.setInsertUsuario(rut, nombre, apellido, fechaNac, cinturon, fechaIngreso, direccion);
        }
    }
}
