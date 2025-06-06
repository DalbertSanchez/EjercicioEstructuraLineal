using EjercicioEstructuraLineal;

namespace Ejercicio_Estructura_Lineal
{
    public class BuscarContacto
    {
        public static void BuscarContactos(List<Contacto> lista)
        {
            Console.Clear();
            Console.WriteLine("=== Contacto ===\n");

            Console.Write("Ingrese el nombre del contacto a buscar: ");
            string nombreBuscado = Console.ReadLine()!;

            var contactoEncontrado = lista.Find(c => c.Nombre == nombreBuscado);
            if (contactoEncontrado is null)
            {
                Console.WriteLine($"El contacto {nombreBuscado} no se encuentra registrado.");
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
    }
}
