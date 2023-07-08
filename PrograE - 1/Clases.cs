using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograE___1
{
    internal class Clases
    {
        interface ILibro
        {
            void Prestar();
            void Devolver();
            void MostrarInformacion();
        }

        class Libro : ILibro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int AnioPublicacion { get; set; }
            public decimal Precio { get; set; }
            public bool Disponible { get; set; }

            public void Prestar()
            {
                if (Disponible)
                {
                    Disponible = false;
                    Console.WriteLine("El libro ha sido prestado.");
                }
                else
                {
                    Console.WriteLine("El libro no está disponible en este momento.");
                }
            }

            public void Devolver()
            {
                if (!Disponible)
                {
                    Disponible = true;
                    Console.WriteLine("El libro ha sido devuelto.");
                }
                else
                {
                    Console.WriteLine("El libro ya está disponible.");
                }
            }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Título: {Titulo}");
                Console.WriteLine($"Autor: {Autor}");
                Console.WriteLine($"Año de publicación: {AnioPublicacion}");
                Console.WriteLine($"Precio: {Precio}");
                Console.WriteLine($"Disponible: {(Disponible ? "Sí" : "No")}");
            }
        }
    }
}
