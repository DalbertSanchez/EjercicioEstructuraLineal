using EjercicioEstructuraLineal;

namespace Ejercicio_Estructura_Lineal
{
    public class MostrarContacto : ListaContacto
    {
        public static void MostrarContactos(List<Contacto> lista)
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
    }
    
}
