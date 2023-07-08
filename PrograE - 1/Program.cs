using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograE___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            Clases clase = new Clases();

            while (true)
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Agregar un libro a la biblioteca");
                Console.WriteLine("2. Eliminar un libro de la biblioteca");
                Console.WriteLine("3. Mostrar todos los libros de la biblioteca");
                Console.WriteLine("4. Buscar libros");
                Console.WriteLine("5. Mostrar libro de mayor precio");
                Console.WriteLine("6. Mostrar los tres libros más baratos");
                Console.WriteLine("7. Buscar libros por inicio del nombre del autor");
                Console.WriteLine("8. Salir del programa");
                Console.Write("Ingrese el número de opción: ");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine();

                    switch (opcion)
                    {
                        case 1:
                            AgregarLibro(biblioteca);
                            break;
                        case 2:
                            EliminarLibro(biblioteca);
                            break;
                        case 3:
                            biblioteca.MostrarLibros();
                            break;
                        case 4:
                            BuscarLibros(biblioteca);
                            break;
                        case 5:
                            biblioteca.MostrarLibroMayorPrecio();
                            break;
                        case 6:
                            biblioteca.MostrarTresLibrosMasBaratos();
                            break;
                        case 7:
                            BuscarLibrosPorInicioAutor(biblioteca);
                            break;
                        case 8:
                            Console.WriteLine("¡Hasta luego!");
                            return;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, ingrese un número del 1 al 8.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número.");
                }

                Console.WriteLine();
            }
        }

        static void AgregarLibro(Biblioteca biblioteca)
        {
            Libro libro = new Libro();

            Console.Write("Ingrese el título del libro: ");
            libro.Titulo = Console.ReadLine();

            Console.Write("Ingrese el autor del libro: ");
            libro.Autor = Console.ReadLine();

            Console.Write("Ingrese el año de publicación del libro: ");
            if (int.TryParse(Console.ReadLine(), out int anio))
            {
                libro.AnioPublicacion = anio;
            }
            else
            {
                Console.WriteLine("El año de publicación debe ser unnúmero válido.");
                return;
            }

            Console.Write("Ingrese el precio del libro: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal precio))
            {
                libro.Precio = precio;
            }
            else
            {
                Console.WriteLine("El precio debe ser un número válido.");
                return;
            }

            libro.Disponible = true;

            biblioteca.AgregarLibro(libro);
        }

        static void EliminarLibro(Biblioteca biblioteca)
        {
            Console.Write("Ingrese el título del libro que desea eliminar: ");
            string titulo = Console.ReadLine();

            Libro libroEncontrado = null;
            foreach (Libro libro in biblioteca.libros)
            {
                if (libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    libroEncontrado = libro;
                    break;
                }
            }

            if (libroEncontrado != null)
            {
                biblioteca.EliminarLibro(libroEncontrado);
            }
            else
            {
                Console.WriteLine("No se encontró un libro con el título especificado.");
            }
        }

        static void BuscarLibros(Biblioteca biblioteca)
        {
            Console.Write("Ingrese el texto de búsqueda: ");
            string textoBusqueda = Console.ReadLine();

            biblioteca.BuscarLibros(textoBusqueda);
        }

        static void BuscarLibrosPorInicioAutor(Biblioteca biblioteca)
        {
            Console.Write("Ingrese el inicio del nombre del autor: ");
            string inicioAutor = Console.ReadLine();

            biblioteca.BuscarLibrosPorInicioAutor(inicioAutor);
        }
    }
}
