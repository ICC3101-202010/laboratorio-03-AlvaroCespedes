using System;

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
            string[] ruts = { "rut1", "rut2", "rut3", "rut4","rut5","rut6","rut7","rut8","rut9","rut10","rut11","rut12","rut13","rut14","rut15","rut16","rut17",
            "rut18","rut19","rut20","rut21","rut22","rut23","rut24","rut25","rut26","rut27","rut28","rut29","rut30","rut31","rut32","rut33",
            "rut34","rut35","rut36","rut37","rut40","rut41","rut42","rut43","rut44","rut45","rut46","rut47","rut48","rut49","rut50"};// Rut Primary Key.
            string[] nacimientos = { "nacimiento1", "nacimiento2","nacimiento3","nacimiento4","nacimiento5","nacimiento6","nacimiento7",
            "nacimiento8","nacimiento9","nacimiento10"};
            //Arrays de datos.


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

            string[] lista = { };
            int x = 1;

            while (x <= 8)
            {
                Empleado empleado = new Empleado();
                Random rnd = new Random();
                int rut = rnd.Next(0, 28);
                int nombre = rnd.Next(0, 28);
                int apellido = rnd.Next(0, 15);
                int nacionalidad = rnd.Next(0, 4);
                int naciomiento = rnd.Next(0, 9);

                // Eliminar dicho rut de la lista rut, asi no se repite.
                string rut2 = persona.ruts[rut];// Me di una variable para el rut elegido.
                persona.QuitarRut(rut2);
                Console.WriteLine(" ");

                Console.WriteLine("El empleado numero " +  x + " de rut: " + rut2);// el rut debe ser unico.
                Console.WriteLine("Tiene un nombre y apellido: " + persona.nombres[nombre]+" " + persona.apellidos[apellido]);
                Console.WriteLine("Con una fecha de nacimiento y nacionalidad de: " + persona.nacimientos[naciomiento]+ " " + persona.nacionalidades[nacionalidad]);
                empleado.AgregarEmpleado(rut2);
                x++;
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Los Clientes son: ");

            int y = 1;
            while (y <= 16)
            {
                Cliente cliente = new Cliente();
                Random rnd = new Random();
                int rut = rnd.Next(0, 29);
                int nombre = rnd.Next(0, 28);
                int apellido = rnd.Next(0, 15);
                int nacionalidad = rnd.Next(0, 4);
                int naciomiento = rnd.Next(0, 9);

                // Eliminar dicho rut de la lista rut, asi no se repite.
                string rut2 = persona.ruts[rut];
                persona.QuitarRut(rut2);
                Console.WriteLine(" ");


                Console.WriteLine("El Cliente numero " + y + " de rut: " + rut2);// el rut debe ser unico.
                Console.WriteLine("Tiene un nombre y apellido: " + persona.nombres[nombre]+" " + persona.apellidos[apellido]);
                Console.WriteLine("Con una fecha de nacimiento y nacionalidad de: " + persona.nacimientos[naciomiento]+" "+ persona.nacionalidades[nacionalidad]);
                cliente.AgregarCliente(rut2); //Agrego un cliente a la lista clientes.
                y++;
            }

            //Parte de los productos.
            string[] idProducto = new string[60];// CReo un array de 60 ojbetos. El Id del producto es unico. Me sirve para el stock.
            //Para los productos se considero lo siguente.
            //Existen 5 Marcas. (Ej: Sal lobos, Sal Cahuil)
            //Solo hay 7 productos. (Ej: Sal, Azucar)
            //Por simplicidad hay 10 precios distintos. 
            //Solo 5 tipos. (Ej: Sal lobos Gruesa, Tallarines Italiani 5)
            int z = 1;
            while (z <= 61)
            {
                idProducto[z] = "Id"+z;
                z++;
            }
            string[] marcaProducto = { "Marca1", "Marca2", "Marca3","Marca4","Marca5" };
            string[] nombreProducto = { "Sal", "Azucar", "Aceite", "Arroz", "Tallarines","Salmon","Filete" };
            string[] precioProducto = { "P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "P9", "P10" };
            string[] tipoProducto = { "T1", "T2", "T3", "T4", "T5" };

        }
    }
}
