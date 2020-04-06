using System.Collections.Generic;

namespace Lab_3
{
    public class Empleado : Persona
    {

        List<string> empleados1; // Empleados --> Cajero.


        public void AgregarEmpleado(string rut)
        {
            empleados1.Add(rut);
        }
        public Empleado()
        {
            empleados1 = new List<string>();
        }
        public Empleado(string nombre, string rut, string apellido, string nacimiento, string nacionalidad) 
            : base(nombre, rut,apellido,nacimiento, nacionalidad)
        {

        }
    }
}
