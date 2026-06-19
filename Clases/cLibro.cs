using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class cLibro : cObjeto
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Anio { get; set; }
        public string Especialidad { get; set; }
        public override void Pedir()
        {
            base.Pedir();

            Console.Write("Ingrese Título: ");
            Titulo = Console.ReadLine();

            Console.Write("Ingrese Autor: ");
            Autor = Console.ReadLine();

            Console.Write("Ingrese Año: ");
            Anio = Console.ReadLine();

            Console.Write("Ingrese Especialidad: ");
            Especialidad = Console.ReadLine();
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Año: " + Anio);
            Console.WriteLine("Especialidad: " + Especialidad);
        }
        public void Modificar(string id, string titulo, string autor, string anio, string especialidad)
        {
            base.Modificar(id);
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Especialidad = especialidad;
        }
        public override void Eliminar()
        {
            base.Eliminar();
            Titulo = null;
            Autor = null;
            Anio = null;
            Especialidad = null;
        }
    }

}

