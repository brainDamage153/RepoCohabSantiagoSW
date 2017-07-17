using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DAO;
using Datos.DTO;

namespace Negocio.Business
{
    public class Neg
    {
        SqlServerConexion sqlcnn = new SqlServerConexion();

        public void cnns(string cnn)
        {
            sqlcnn.sqlCnn(cnn);
        }

        public void setIngresoLuchador(string cnn, string rut, string nombre, string apellido, DateTime fechaNac, string cinturon, DateTime fechaIngreso, string direccion )
        {
            Luchador l = new Luchador();

            //l.Rut = rut;
            //l.Nombre = nombre;
            //l.Apellido = apellido;
            //l.FechaNac = fechaNac;
            //l.Cinturon = cinturon;
            //l.FechaIngreso = fechaIngreso;
            //l.Direccion = direccion;
            sqlcnn.setInsertUsuario(cnn, rut, nombre, apellido, fechaNac, cinturon, fechaIngreso, direccion);
        }
    }
}
