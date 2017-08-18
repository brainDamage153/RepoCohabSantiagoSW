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
        

        SqlServerConexion sc = new SqlServerConexion();
        Luchador l = new Luchador();
        Trabajador t = new Trabajador();

        public void cnns(string cnn)
        {
            sc.sqlCnn(cnn);
        }

        public void setIngresoLuchador(string cnn, string rut, string nombre, string apellido, DateTime fechaNac, string cinturon, DateTime fechaIngreso, string direccion )
        {
            l.Rut = rut;
            l.Nombre = nombre;
            l.Apellido = apellido;
            l.FechaNac = fechaNac;
            l.Cinturon = cinturon;
            l.FechaIngreso = fechaIngreso;
            l.Direccion = direccion;

            try
            {
                sc.setInsertUsuario(cnn, l);
            }
            catch (Exception e)
            {

            }
        }

        public void setIngresoTrabajador(string cnn, string rut, string nom, string apellido, DateTime fechaNac, DateTime fechaIngreso, string direccion)
        {
            t.Rut = rut;
            t.Nombre = nom;
            t.Apellido = apellido;
            t.FechaNac = fechaNac;
            t.FechaIngreso = fechaIngreso;
            t.Direccion = direccion;
            sc.setInsertTrabajador(cnn, t);
        }

        public void getTrabajador(string cnn, string rut, string nom, string apellido, DateTime fechaNac, DateTime fechaIngreso, string direccion)
        {
                
        }

        public List<string> get_Luchador(string cnn,string rut)
        {
            List<string> list = new List<string>();
            string nombre;
            string apellido;
            DateTime fechaNac;
            string cinturon;
            DateTime fechaIngreso;
            string direccion;
            //Luchador l = new Luchador();
             sc.get_Luchador(cnn, rut);
            
            list.Add(rut = l.Rut);
            list.Add(nombre = l.Nombre);
            list.Add(apellido = l.Apellido);
            list.Add(Convert.ToString(fechaNac=l.FechaNac));
            list.Add(cinturon = l.Cinturon);
            list.Add(Convert.ToString(fechaIngreso = l.FechaIngreso));
            list.Add(direccion = l.Direccion);

            return list;
        }
    }
}
