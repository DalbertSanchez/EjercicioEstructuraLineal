using EjercicioEstructuraLineal;

namespace Ejercicio_Estructura_Lineal
{
    public class AgregarContactos : ListaContacto
    {
     
        public static void AgregarContacto(List<Contacto> lista)
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

    }
}
