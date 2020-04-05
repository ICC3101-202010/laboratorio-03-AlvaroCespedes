using System;
using System.Collections.Generic;

namespace Lab_3
{
    class Persona
    {
        private string _rut;
        private string _nombre;
        private string _apellido;
        private string _nacimiento;
        private string _nacionalidad;
        // Atributos siempre private. En el caso de herencia.
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                if (value.Length <= 12)
                {
                    this._nombre = value;
                }
            }
        }// GET Y SET

        public Persona(string rut, string nombre, string apellido, string nacimiento, string nacionalidad)
        {
            this._rut = rut;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nacimiento = nacimiento;
            this._nacionalidad = nacionalidad;
        }

        Random rnd = new Random();
        public int NumeroRandom()// Me ayuda a tener un numero random para que los nombres.
        {
            int numero = rnd.Next(0, 29);
            return numero;
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
        //Metodos para agregar los datos.

        public string CrearNombre(string nombre)
        {
            //string nombre = " ";
            foreach (string i in nombres)
            {

            }
            return null;
        }
    }
}
