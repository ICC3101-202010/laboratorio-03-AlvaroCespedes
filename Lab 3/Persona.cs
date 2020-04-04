using System;
using System.Collections.Generic;

namespace Lab_3
{
    class Persona
    {
        private string Rut;
        private string Nombre;
        private string Apellido;
        private string Nacimiento;
        private string Nacionalidad;// tengo que colocar public para que las demas clases las hereden.
        // Atributos siempe private.

        public Persona(string rut, string nombre, string apellido, string nacimiento, string nacionalidad)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacimiento = nacimiento;
            this.Nacionalidad = nacionalidad;
        }

        public List<string> nombres;
        public List<string> apellidos;
        public List<string> nacionalidades;
        public List<string> ruts;
        public List<string> nacimientos;
        public Persona()
        {
            nombres = new List<string>();
            apellidos = new List<string>();// puedo agregar parametros.
            nacionalidades = new List<string>();
            ruts = new List<string>();
            nacimientos = new List<string>();
        }// constructor de las listas

        public void AgregarNombre(string nombre)
        {
            nombres.Add(nombre);
        }
        public void AgregarApellido(string apellido)
        {
            apellidos.Add(apellido);
        }
        public void AgregarNacionalidad(string nacionalidad)
        {
            nacionalidades.Add(nacionalidad);
        }
        public void AgregarRut(string rut)
        {
            ruts.Add(rut);
        }
        public void AgregarNacimiento(string nacimiento)
        {
            nacimientos.Add(nacimiento);
        }

        public string CrearNombre(string nombre)
        {
            foreach(string i in nombres) ;
            {

            }
            return null;
        }


    }
}
