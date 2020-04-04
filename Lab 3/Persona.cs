using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Persona
    {
        public string Rut;
        public string Nombre;
        public string Apellido;
        public string Nacimiento;
        public string Nacionalidad;// tengo que colocar public para que las demas clases las hereden.

        public Persona(string rut, string nombre, string apellido, string nacimiento, string nacionalidad)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacimiento = nacimiento;
            this.Nacionalidad = nacionalidad;
        }
        public List<string> nombres;
        public Persona()
        {
            nombres = new List<string>(); // puedo agregar parametros.
        }
        public List<string> apellidos;
        public List<string> nacionalidades;
        public List<int> ruts;
        public List<int> nacimientos;

        public void AgregarDatos(string nombre)
        {
            nombres.Add(nombre);
            //apellidos.Add(apellido);
            //nacionalidades.Add(nacionalidad);
            //ruts.Add(rut);
            //nacimientos.Add(nacimiento);
        }
    }
}
