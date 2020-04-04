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

            string[] apellidos = {"Cespedes","Solis","Valle","Caceres","Lara","Lisboa","Arriagada","Araneda","Tan","Grandos","Borquez",
            "Perez","Risopatron","Del Valle","Pitt",};

            string[] nacionalidades = { "Chilena", "Peruana", "Colombiana", "Argentina" };

            string[] ruts = { "19591144-4", "823645-3", "24500-3", "12334523-2" };

            string[] nacimientos = { "03.04.1999", "02.04.2012" };
            foreach (string nombre in nombres)
            {
                persona.AgregarNombre(nombre);
            }

            foreach (string apellido in apellidos)
            {
                persona.AgregarApellido(apellido);
            }
            foreach (string nacionalidad in nacionalidades)
            {
                persona.AgregarNacionalidad(nacionalidad);
            }
            foreach (string rut in ruts)
            {
                persona.AgregarRut(rut);
            }
            foreach (string nacimiento in nacimientos)
            {
                persona.AgregarNacimiento(nacimiento);
            }
            //Bubles para agregar a la listas

        }
    }
}
