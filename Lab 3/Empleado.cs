using System.Collections.Generic;

namespace Lab_3
{
    public class Empleado : Persona
    {
        private string _sueldo;

        public string Sueldo { get => _sueldo; set => _sueldo = value; }

        public void AgregarSueldo(string sueldo)
        {
            sueldos.Add(sueldo);
        }


        List<string> sueldos;
        List<string> empleados1; // Empleados --> Cajero.


        public void AgregarEmpleado(string rut)
        {
            empleados1.Add(rut);
        }
        public void QuitarSueldo(string sueldo)
        {
            sueldos.Remove(sueldo);
        }

        public Empleado(string sueldo)
        {
            this._sueldo = sueldo;
        }
        public Empleado(string nombre, string rut, string apellido, string nacimiento, string nacionalidad) 
            : base(nombre, rut,apellido,nacimiento, nacionalidad)
        {

        }

        public Empleado()
        {
            empleados1 = new List<string>();
            sueldos = new List<string>();
        }
    }
}
