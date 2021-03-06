﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    public class Luchador
    {
        private string rut;
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private string cinturon;
        private DateTime fechaIngreso;
        private string direccion;

        public Luchador()
        {

        }


        public string Rut
        {
            get
            {
                return this.rut;
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
                return this.nombre;
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
                return this.apellido;
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
                return this.fechaNac;
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
                return this.cinturon;
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
                return this.fechaIngreso;
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
                return this.direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public Luchador(string rut, string nombre, string apellido, DateTime fechaNac, string cinturon, DateTime fechaIngreso, string direccion)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechaNac;
            this.Cinturon = cinturon;
            this.FechaIngreso = fechaIngreso;
            this.Direccion = direccion;
        }

        public void set(IDataRecord vo)
        {

            try
            {
                //Rut = vo[0].ToString();
                Nombre = vo[1].ToString();
                Apellido = vo[2].ToString();
                FechaNac = (DateTime)vo[3];
                Cinturon = vo[4].ToString();
                FechaIngreso = (DateTime)vo[5];
                Direccion = vo[6].ToString();
            }
            catch (Exception e)
            {

            }

        }
    }
}