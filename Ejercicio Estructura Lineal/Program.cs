using Ejercicio_Estructura_Lineal;
using EjercicioEstructuraLineal;

List<Contacto> contactos = new List<Contacto>()!;
string opcion;


do
{
    Console.Clear();
    Console.WriteLine("==== AGENDA DE CONTACTOS ====");
    Console.WriteLine("1. Agregar contacto");
    Console.WriteLine("2. Mostrar contactos");
    Console.WriteLine("3. Buscar contacto ");
    Console.WriteLine("4. Eliminar contacto");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");
    opcion = Console.ReadLine()!;

    switch (opcion)
    {
        case "1":
            AgregarContactos.AgregarContacto(contactos);
            break;
        case "2":
            MostrarContacto.MostrarContactos(contactos);
            break;
        case "3":
            BuscarContacto.BuscarContactos(contactos);
            break;
        case "4":
            EliminarContacto.EliminarContactos(contactos);
            break;
        case "5":
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Presione una tecla para continuar.");
            Console.ReadKey();
            break;
    }
} while (opcion != "5");
    
