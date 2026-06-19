using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class cPrestamo : cObjeto
    {
        public string IdLector { get; set; }
        public String IdLibro { get; set; }
        public string FechaPrestamo { get; set; }
        public string FechaDevolucion { get; set; }

        public override void Pedir()
        {
            base.Pedir();

            Console.Write("Ingrese ID: ");
            Id = Console.ReadLine();

            Console.Write("Ingrese IdLector: ");
            IdLector = Console.ReadLine();

            Console.Write("Ingrese IdLibro: ");
            IdLibro = Console.ReadLine();

            Console.Write("Ingrese Fecha del Prestamo: ");
            FechaPrestamo = Console.ReadLine();

            Console.Write("Ingrese Fecha de Devolucion ");
            FechaDevolucion = Console.ReadLine();
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("ID Lector: " + IdLector);
            Console.WriteLine("ID Libro: " + IdLibro);
            Console.WriteLine("Fecha de Préstamo: " + FechaPrestamo);
            Console.WriteLine("Fecha de Devolución: " + FechaDevolucion);
        }
        public void Modificar(string id, string idLector, string idLibro, string fechaPrestamo, string fechaDevolucion)
        {
            base.Modificar(id);
            IdLector = idLector;
            IdLibro = idLibro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
        }
        public override void Eliminar()
        {
            base.Eliminar();
            IdLector = null;
            IdLibro = null;
            FechaPrestamo = null;
            FechaDevolucion = null;
        }

    }

}
