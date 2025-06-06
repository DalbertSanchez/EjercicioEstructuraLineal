using EjercicioEstructuraLineal;

namespace Ejercicio_Estructura_Lineal
{
    public class EliminarContacto : ListaContacto
    {
        public static void EliminarContactos(List<Contacto> lista)
        {
            Console.Clear();
            Console.WriteLine("=== Contacto ===\n");

            Console.Write("Ingrese el nombre del contacto a eliminar: ");
            string nombreBuscado = Console.ReadLine()!;

            bool contactoEliminado = lista.RemoveAll(c => c.Nombre == nombreBuscado) > 0;
            if (contactoEliminado)
            {
                Console.WriteLine($"El contacto {nombreBuscado} se ha eliminado correctamente.");
            }
            else
            {
                foreach (var contacto in lista)
                {
                    Console.WriteLine("Contacto no encontrado");
                    
                }
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
    
}
