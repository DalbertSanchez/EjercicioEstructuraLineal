using EjercicioEstructuraLineal;

List<Contacto> contactos = new List<Contacto>()!;
string opcion;

do
{
    Console.Clear();
    Console.WriteLine("==== AGENDA DE CONTACTOS ====");
    Console.WriteLine("1. Agregar contacto");
    Console.WriteLine("2. Mostrar contactos");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción: ");
    opcion = Console.ReadLine()!;

    switch (opcion)
    {
        case "1":
            AgregarContacto(contactos);
            break;
        case "2":
            MostrarContactos(contactos);
            break;
        case "3":
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Presione una tecla para continuar.");
            Console.ReadKey();
            break;
    }
} while (opcion != "3");
    

    static void AgregarContacto(List<Contacto> lista)
{
    Console.Clear();
    Console.WriteLine("=== Agregar nuevo contacto ===");
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine()!;
    Console.Write("Teléfono: ");
    string telefono = Console.ReadLine()!;
    Console.Write("Email: ");
    string email = Console.ReadLine()!;

    lista.Add(new Contacto
    {
        Nombre = nombre,
        Telefono = telefono,
        Email = email
    });

    Console.WriteLine("Contacto agregado correctamente.");
    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadKey();
}

static void MostrarContactos(List<Contacto> lista)
{
    Console.Clear();
    Console.WriteLine("=== Lista de contactos ===\n");

    if (lista.Count == 0)
    {
        Console.WriteLine("No hay contactos registrados.");
    }
    else
    {
        foreach (var contacto in lista)
        {
            Console.WriteLine($"Nombre: {contacto.Nombre}");
            Console.WriteLine($"Teléfono: {contacto.Telefono}");
            Console.WriteLine($"Email: {contacto.Email}");
            Console.WriteLine("------------------------------");
        }
    }

    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadKey();
}