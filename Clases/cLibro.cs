using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class cLibro
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Anio { get; set; }
        public string Especialidad { get; set; }
        public void PedirLibro()
        {
            Console.Write("Ingrese ID: ");
            Id = Console.ReadLine();

            Console.Write("Ingrese Título: ");
            Titulo = Console.ReadLine();

            Console.Write("Ingrese Autor: ");
            Autor = Console.ReadLine();

            Console.Write("Ingrese Año: ");
            Anio = Console.ReadLine();

            Console.Write("Ingrese Especialidad: ");
            Especialidad = Console.ReadLine();
        }
        public void MostrarLibro()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Año: " + Anio);
            Console.WriteLine("Especialidad: " + Especialidad);
        }
        public void ModificarLibro(string id, string titulo, string autor, string anio, string especialidad)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Especialidad = especialidad;
        }
        public void EliminarLibro()
        {
            Id = null;
            Titulo = null;
            Autor = null;
            Anio = null;
            Especialidad = null;
        }
        public void BuscarLibro()
        {
            Console.Write("Ingrese ID del libro a buscar: ");
            string idBuscado = Console.ReadLine();
            if (Id == idBuscado)
            {
                Console.WriteLine("Libro encontrado:");
                MostrarLibro();
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }
    }

}

