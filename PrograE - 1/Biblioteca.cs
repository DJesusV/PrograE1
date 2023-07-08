using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograE___1
{
    internal class Biblioteca
    {
        Clases clase = new Clases();

        private List<Libro> libros;

        public Biblioteca()
        {
            libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
            Console.WriteLine("El libro ha sido agregado a la biblioteca.");
        }

        public void EliminarLibro(Libro libro)
        {
            libros.Remove(libro);
            Console.WriteLine("El libro ha sido eliminado de la biblioteca.");
        }

        public void MostrarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("La biblioteca está vacía.");
            }
            else
            {
                Console.WriteLine("Lista de libros en la biblioteca:");
                foreach (Libro libro in libros)
                {
                    libro.MostrarInformacion();
                    Console.WriteLine("------------------------");
                }
            }
        }

        public void BuscarLibros(string textoBusqueda)
        {
            bool encontrados = false;
            foreach (Libro libro in libros)
            {
                if (libro.Titulo.Contains(textoBusqueda) || libro.Autor.Contains(textoBusqueda))
                {
                    libro.MostrarInformacion();
                    Console.WriteLine("------------------------");
                    encontrados = true;
                }
            }

            if (!encontrados)
            {
                Console.WriteLine("No se encontraron libros que coincidan con la búsqueda.");
            }
        }

        public void MostrarLibroMayorPrecio()
        {
            Libro libroMayorPrecio = null;
            foreach (Libro libro in libros)
            {
                if (libroMayorPrecio == null || libro.Precio > libroMayorPrecio.Precio)
                {
                    libroMayorPrecio = libro;
                }
            }

            if (libroMayorPrecio != null)
            {
                Console.WriteLine("Libro de mayor precio:");
                libroMayorPrecio.MostrarInformacion();
            }
            else
            {
                Console.WriteLine("No hay libros en la biblioteca.");
            }
        }

        public void MostrarTresLibrosMasBaratos()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros en la biblioteca.");
            }
            else if (libros.Count <= 3)
            {
                Console.WriteLine("Los libros más baratos en la biblioteca:");
                foreach (Libro libro in libros)
                {
                    libro.MostrarInformacion();
                    Console.WriteLine("------------------------");
                }
            }
            else
            {
                libros.Sort((libro1, libro2) => libro1.Precio.CompareTo(libro2.Precio));
                Console.WriteLine("Los tres libros más baratos en la biblioteca:");
                for (int i = 0; i < 3; i++)
                {
                    libros[i].MostrarInformacion();
                    Console.WriteLine("------------------------");
                }
            }
        }

        public void BuscarLibrosPorInicioAutor(string inicioAutor)
        {
            bool encontrados = false;
            foreach (Libro libro in libros)
            {
                if (libro.Autor.StartsWith(inicioAutor))
                {
                    libro.MostrarInformacion();
                    Console.WriteLine("------------------------");
                    encontrados = true;
                }
            }

            if (!encontrados)
            {
                Console.WriteLine("No se encontraron libros cuyo autor comience con el texto especificado.");
            }
        }
    }
}
