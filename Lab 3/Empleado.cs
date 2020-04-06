using System.Collections.Generic;

namespace Lab_3
{
    class Empleado : Persona
    {

        List<string> empleados; // Empleados --> Cajero.
        public Empleado()//Construtor
        {
            empleados = new List<string>();
        }

        public void AgregarEmpleado(string rut)
        {
            empleados.Add(rut);
        }
    }
}
