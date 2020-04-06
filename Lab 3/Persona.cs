using System;
using System.Collections.Generic;

namespace Lab_3
{
    public class Persona // Nombres, Nacimiento, Nacionalidad y Apellidos se pueden repetir. Coincidencias. RUT UNICO. 
    {
        private string _rut;
        private string _nombre;
        private string _apellido;
        private string _nacimiento;
        private string _nacionalidad;
        // Atributos siempre private. En el caso de herencia.





        public Persona(string rut, string nombre, string apellido, string nacimiento, string nacionalidad)
        {
            this._rut = rut;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nacimiento = nacimiento;
            this._nacionalidad = nacionalidad;
        }

        public List<string> nombres;
        public List<string> apellidos;
        public List<string> nacionalidades;
        public List<string> ruts;
        public List<string> nacimientos;

        public string Rut 
        {
            get { return _rut; }
            set { _rut = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Nacimiento
        {
            get { return _nacimiento; }
            set { _nacimiento = value; }
        }
        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }

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
        //Metodos para agregar los datos a la listas.


        // El rut debe ser unico.
        public void QuitarRut(string rut)
        {
            ruts.Remove(rut);
        }

    }
}
