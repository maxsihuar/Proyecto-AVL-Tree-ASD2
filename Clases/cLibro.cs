using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class CLibro
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Anio { get; set; }
        public string Especialidad { get; set; }
        public void AgregarLibro(string id, string titulo, string autor, string anio, string especialidad)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Especialidad = especialidad;
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
        public bool BuscarLibro(string id)
        {
            return Id == id;
        }
    }

}

