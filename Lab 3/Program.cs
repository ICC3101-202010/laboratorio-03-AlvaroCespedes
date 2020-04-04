using System;
using Lab_3.Persona;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona(); // Creo el constructor

            string[] nombres = { "Juan", "Alvaro", "Carlos", "Jose", "Diego","Maria","Francisca","Catalina","Antonia","Antonio"
            ,"Monse","Raul","Pedro","Raimundo", "Nelson", "Sonia", "Cristobal","Ramon","James","Maximo", "Vicente", "Pablo","Martin", "Joching","Sebastian",
            "Luis","Francisco","Richi","Javiera","Fernanda"};

            string[] apellidos = { };
            foreach (string nombre in nombres)
            {
                persona.AgregarDatos(nombre);
            }// Ya estan agregado a la lista nombres.
        }
    }
}
