using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al menu");
            Console.WriteLine("Por favor, aprete 10 y Enter");
            string opcion1 = Console.ReadLine();
            Persona persona = new Persona();
            Empleado empleado = new Empleado();
            Cliente cliente = new Cliente();
            Producto producto = new Producto();

            while (opcion1 =="10")
            {
                Console.WriteLine("Eligir una opcion");
                Console.WriteLine("(1) Agregar Empleado");
                Console.WriteLine("(2) Agregar Producto");
                Console.WriteLine("(3) Agregar cliente");
                Console.WriteLine("(4) Ver informacion Empleados");
                Console.WriteLine("(5) Ver informacion Productos");
                Console.WriteLine("(6) Ver informacion Clientes");
                Console.WriteLine("(7) Realizar una compra con un cliente");
                Console.WriteLine("(8) Cambiar sueldos ");
                Console.WriteLine("(9) Ver 15 clientes, 7 empleados y 30 productos al azar.");
                Console.WriteLine("(0) Para salir del programa");
                string opcion2 = Console.ReadLine();

                if (opcion2 == "1")
                {

                    Console.WriteLine("Escriba el rut del empleado: ");
                    string rut = Console.ReadLine();
                    empleado.AgregarRut(rut);

                    Console.WriteLine("Agregar Nombre: ");
                    string nombre = Console.ReadLine();
                    empleado.AgregarNombre(nombre);

                    Console.WriteLine("Agregar Apellido: ");
                    string apellido = Console.ReadLine();
                    empleado.AgregarApellido(apellido);

                    Console.WriteLine("Escriba la fecha de nacimiento: ");
                    string nacimiento = Console.ReadLine();
                    empleado.AgregarNacimiento(nacimiento);

                    Console.WriteLine("Su nacionalidad: ");
                    string nacionalidad = Console.ReadLine();
                    empleado.AgregarNacionalidad(nacionalidad);

                    Console.WriteLine("Agregar Sueldo del empleado: ");
                    string sueldo = Console.ReadLine();
                    empleado.AgregarSueldo(sueldo);

                    Console.WriteLine("Empleado Agregado con exito.");
                    Console.WriteLine("Escriba lo que sea para volver al menu.(Q)");

                    //foreach(string i in empleado.ruts)
                    //{
                    //    Console.WriteLine(i);
                    //}

                    string opcion3 = Console.ReadLine();
                    opcion2 = opcion3;

                }// listo

                if (opcion2 == "2") 
                {
                    Console.WriteLine("Escriba el nombre del producto: ");
                    string nombre = Console.ReadLine();
                    producto.AgregarNombrePro(nombre);

                    Console.WriteLine("Agregar Precio: ");
                    string precio = Console.ReadLine();
                    producto.AgregarPreciosPro(precio);

                    Console.WriteLine("Agregar marca: ");
                    string marca = Console.ReadLine();
                    producto.AgregarMarcasPro(marca);

                    Console.WriteLine("Agrege su tipo: ");
                    string tipo = Console.ReadLine();
                    producto.AgregarTiposPro(tipo);

                    Console.WriteLine("Agregue su Id, Recuerda que es unica: ");
                    string Id = Console.ReadLine();
                    producto.AgregarIdPro(Id);

                    Console.WriteLine("Agregue el stok del producto: ");
                    string stock = Console.ReadLine();
                    producto.AgregarStock(stock);

                    Console.WriteLine("Prducto Agregado con exito.");
                    Console.WriteLine("Escriba lo que sea para volver al menu.(Q)");
                    string opcion3 = Console.ReadLine();
                    opcion2 = opcion3;
                } // Se va agregando producto uno a uno. un "stock a stock"

                if(opcion2 == "3")
                {
                    Console.WriteLine("Escriba el rut del Cliente: ");
                    string rut = Console.ReadLine();
                    cliente.AgregarRut(rut);

                    Console.WriteLine("Agregar Nombre: ");
                    string nombre = Console.ReadLine();
                    cliente.AgregarNombre(nombre);

                    Console.WriteLine("Agregar Apellido: ");
                    string apellido = Console.ReadLine();
                    cliente.AgregarApellido(apellido);

                    Console.WriteLine("Escriba la fecha de nacimiento: ");
                    string nacimiento = Console.ReadLine();
                    cliente.AgregarNacimiento(nacimiento);

                    Console.WriteLine("Su nacionalidad: ");
                    string nacionalidad = Console.ReadLine();
                    cliente.AgregarNacionalidad(nacionalidad);

                    Console.WriteLine("Cliente Agregado con exito.");
                    Console.WriteLine("Escriba lo que sea para volver al menu.(Q)");
                    string opcion3 = Console.ReadLine();
                    opcion2 = opcion3;
                }

                if(opcion2 == "4")
                {
        
                    int x = 0;
                    int lista = empleado.ruts.Count;
                    while (x < lista)
                    {
                        Console.WriteLine("Rut empleado: " + empleado.ruts[x]+ " "+
                                           "Nombre Empleado: " + empleado.nombres[x]+ " " +
                                           "Apellido empleado: "+ empleado.apellidos[x]+ " " +
                                           "Fecha nacimiento: "+empleado.nacimientos[x]+ " " +
                                           "Nacionalidad: "+empleado.nacionalidades[x]);
                        x++;
                    }
                    Console.WriteLine("Informacion completada");
                    Console.WriteLine("Escriba lo que sea para volver al menu.(Q)");

                    string opcion3 = Console.ReadLine();
                    opcion2 = opcion3;

                }

                if (opcion2 == "5")
                {
                    int x = 0;
                    int lista = producto.idsPro.Count;
                    while (x < lista)
                    {
                        Console.WriteLine("Id producto: " + producto.idsPro[x] + " " +
                                           "Nombre producto: " + producto.nombresPro[x] + " " +
                                           "Marca producto: " + producto.marcasPro[x] + " " +
                                           "Tipo producto : " + producto.tiposPro[x] + " " +
                                           "Precio producto: " + producto.preciosPro[x]);
                        x++;
                    }
                    Console.WriteLine("Inforacion entregada con exito.");
                    Console.WriteLine("Escriba lo que sea para volver al menu.(Q)");

                    string opcion3 = Console.ReadLine();
                    opcion2 = opcion3;
                }

                if (opcion2 == "6")
                {
                    int x = 0;
                    int lista = cliente.ruts.Count;
                    while (x < lista)
                    {
                        Console.WriteLine("Rut Cliente: " + cliente.ruts[x] + " " +
                                           "Nombre Cliente: " + cliente.nombres[x] + " " +
                                           "Apellido Cliente: " + cliente.apellidos[x] + " " +
                                           "Fecha nacimiento: " + cliente.nacimientos[x] + " " +
                                           "Nacionalidad: " + cliente.nacionalidades[x]);
                        x++;
                    }
                    Console.WriteLine("Informacion completada");
                    Console.WriteLine("Escriba lo que sea para volver al menu.(Q)");

                    string opcion3 = Console.ReadLine();
                    opcion2 = opcion3;
                }

                if(opcion2 == "7")
                {
                    Console.WriteLine("Primero debe elegir el cliente que realizara la compra: ");
                    foreach (string i in cliente.ruts)
                    {
                        int x = 0;
                        int lista = cliente.ruts.Count;
                        Console.WriteLine("Elegir numero del cliente");
                        while (x < lista)
                        {
                            Console.WriteLine("Rut Cliente: " +"("+ (x + 1)+")" + i);
                                               
                            x++;
                        }

                        string cliente1 = Console.ReadLine();
               
                    }
                }

                if (opcion2 == "8")
                {
                    Console.WriteLine("¿A que empleado desea cambiar sueldo ?");
                    int x = 1;
                    foreach (string rut in empleado.ruts)
                    {
                        Console.WriteLine("opcion "+x+ rut);
                        x++;
                    }
                    Console.WriteLine("Recuerde que el rut es unico");
                    string eleccion = Console.ReadLine();// Tengo que volverla a entero.
                    

                }

                if (opcion2 == "9")
                {
                    //Persona persona = new Persona(); // Creo el constructor

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

                    int x = 1;
                    Console.WriteLine("Los empleados son: ");
                    while (x <= 7)
                    {

                        Random rnd = new Random();
                        int rut = rnd.Next(0, 28);
                        int nombre = rnd.Next(0, 28);
                        int apellido = rnd.Next(0, 15);
                        int nacionalidad = rnd.Next(0, 4);
                        int naciomiento = rnd.Next(0, 9);

                        // Eliminar dicho rut de la lista rut, asi no se repite.
                        string rut2 = persona.ruts[rut];// Me di una variable para el rut elegido.
                        persona.QuitarRut(rut2);
                        //Console.WriteLine(" ");

                        Console.WriteLine("El empleado numero " + x + " de rut: " + rut2);// el rut debe ser unico.
                        Console.WriteLine("Tiene un nombre y apellido: " + persona.nombres[nombre] + " " + persona.apellidos[apellido]);
                        Console.WriteLine("Con una fecha de nacimiento y nacionalidad de: " + persona.nacimientos[naciomiento] + " " + persona.nacionalidades[nacionalidad]);
                        empleado.AgregarEmpleado(rut2);
                        x++;
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("------------------------------------------------------------------------ ");
                    Console.WriteLine("Los Clientes son: ");

                    int y = 1;
                    while (y <= 15)
                    {
                        Cliente cliente1 = new Cliente();
                        Random rnd = new Random();
                        int rut = rnd.Next(0, 20);
                        int nombre = rnd.Next(0, 28);
                        int apellido = rnd.Next(0, 15);
                        int nacionalidad = rnd.Next(0, 4);
                        int naciomiento = rnd.Next(0, 9);

                        // Eliminar dicho rut de la lista rut, asi no se repite.
                        string rut2 = persona.ruts[rut]; //Tengo problemas. out of range.
                        persona.QuitarRut(rut2);
                        //Console.WriteLine(" ");


                        Console.WriteLine("El Cliente numero " + y + " de rut: " + rut2);// el rut debe ser unico.
                        Console.WriteLine("Tiene un nombre y apellido: " + persona.nombres[nombre] + " " + persona.apellidos[apellido]);
                        Console.WriteLine("Con una fecha de nacimiento y nacionalidad de: " + persona.nacimientos[naciomiento] + " " + persona.nacionalidades[nacionalidad]);
                        y++;
                    }

                    //Parte de los productos.
                    string[] idProducto = new string[61];// CReo un array de 61 ojbetos. El Id del producto es unico. Me sirve para el stock.
                                                         //Para los productos se considero lo siguente.
                                                         //Existen 5 Marcas. (Ej: Sal lobos, Sal Cahuil)
                                                         //Solo hay 7 productos. (Ej: Sal, Azucar)
                                                         //Por simplicidad hay 10 precios distintos. 
                                                         //Solo 5 tipos. (Ej: Sal lobos Gruesa, Tallarines Italiani 5)

                    Producto producto1 = new Producto();
                    int z = 0;
                    while (z <= 60)
                    {
                        idProducto[z] = "Id" + z;
                        z++;
                    }
                    string[] marcaProducto = { "Carozzi", "Taliani", "Tucapel", "Trattoria", "Jumbo" };
                    string[] nombreProducto = { "Sal", "Azucar", "Aceite", "Arroz", "Tallarines", "Salmon", "Filete" };
                    string[] precioProducto = { "5.000", "6.999", "2.000", "4.000", "500", "237", "5.200", "15.000", "20.000", "1.000" };
                    string[] tipoProducto = { "Grueso/a", "5 Pulgadas", "Largo", "Corto", "7 pulgadas" };

                    //Agrego todo a las listas.
                    foreach (string id in idProducto)
                    {
                        producto1.AgregarIdPro(id);
                    }
                    foreach (string nombre in nombreProducto)
                    {
                        producto1.AgregarNombrePro(nombre);
                    }
                    foreach (string marca in marcaProducto)
                    {
                        producto1.AgregarMarcasPro(marca);
                    }
                    foreach (string precio in precioProducto)
                    {
                        producto1.AgregarPreciosPro(precio);
                    }
                    foreach (string tipo in tipoProducto)
                    {
                        producto1.AgregarTiposPro(tipo);
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Los productos son: ");

                    int x1 = 1;
                    while (x1 <= 30)
                    {

                        Random rnd = new Random();
                        int id = rnd.Next(0, 20);// del uno al 20 para no tener problemas de Index.
                        int marca = rnd.Next(0, 5);
                        int nombre = rnd.Next(0, 7);
                        int precio = rnd.Next(0, 10);
                        int tipo = rnd.Next(0, 5);

                        string id2 = producto1.idsPro[id];
                        producto1.QuitarId(id2);
                        Console.WriteLine("El producto numero " + x1);
                        Console.WriteLine("Su nombre, marca, tipo y precio Respestivamente: " +
                                            producto1.nombresPro[nombre] + " " +
                                            producto1.marcasPro[marca] + " " +
                                            producto1.tiposPro[tipo] + " " +
                                            producto1.preciosPro[precio]);
                        x1++;
                    }

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("INICIO DE LA COMPRA.");

                    string[] fecha = { "Fecha1", "Fecha2", "Fecha3", "Fecha4", "Fecha5" };// 5 fechas diferentes.

                    int x2 = 1;
                    while (x2 <= 75)//Son 75 compras.
                    {
                        break;
                    }
                } // Son otras variables para la simulacion.

                if (opcion2 == "0")
                {
                    break;
                }

            }
        }
    }
}
