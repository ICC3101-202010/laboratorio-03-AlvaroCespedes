using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Cliente: Persona
    {
        List<string> clientes;
        public Cliente()//Constructor de las listas.
        {
            clientes = new List<string>();
        }
        public void AgregarCliente(string rut)
        {
            clientes.Add(rut);
        }
        public void Comprar()// Metodo comprar.
        {
        }
        public Cliente(string nombre, string rut, string apellido, string nacimiento, string nacionalidad)
            : base(nombre, rut, apellido, nacimiento, nacionalidad)
        {

        }
    }
}
