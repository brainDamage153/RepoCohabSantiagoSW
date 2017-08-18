using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    public class Trabajador
    {
        #region VARIABLES
        private string rut;
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private DateTime fechaIngreso;
        private string direccion;
        #endregion

        public Trabajador()
        {

        }

        public string Rut
        {
            get
            {
                return rut;
            }

            set
            {
                rut = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public DateTime FechaNac
        {
            get
            {
                return fechaNac;
            }

            set
            {
                fechaNac = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }

            set
            {
                fechaIngreso = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public Trabajador(string rut, string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, string direccion)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.fechaIngreso = fechaIngreso;
            this.direccion = direccion;
        }
        



    }
}
