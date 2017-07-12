using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    class Luchador
    {
        private string rut;
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private string cinturon;
        private DateTime fechaIngreso;

       public Luchador()
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

        public string Cinturon
        {
            get
            {
                return cinturon;
            }

            set
            {
                cinturon = value;
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

        public Luchador(string rut, string nombre, string apellido, DateTime fechaNac, string cinturon, DateTime fechaIngreso)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechaNac;
            this.Cinturon = cinturon;
            this.FechaIngreso = fechaIngreso;
        }
    }
}
