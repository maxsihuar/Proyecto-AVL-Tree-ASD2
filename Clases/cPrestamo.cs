using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class cPrestamo
    {
        public string Id { get; set; }
        public string IdLector { get; set; }
        public String IdLibro { get; set; }
        public string FechaPrestamo { get; set; }
        public string FechaDevolucion { get; set; }

        public void AgregarPrestamo(string id, string idLector, string idLibro, string fechaPrestamo, string fechaDevolucion)
        {
            Id = id;
            IdLector = idLector;
            IdLibro = idLibro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
        }
        public void MostrarPrestamo()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("ID Lector: " + IdLector);
            Console.WriteLine("ID Libro: " + IdLibro);
            Console.WriteLine("Fecha de Préstamo: " + FechaPrestamo);
            Console.WriteLine("Fecha de Devolución: " + FechaDevolucion);
        }
        public void ModificarPrestamo(string id, string idLector, string idLibro, string fechaPrestamo, string fechaDevolucion)
        {
            Id = id;
            IdLector = idLector;
            IdLibro = idLibro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
        }
        public void EliminarPrestamo()
        {
            Id = null;
            IdLector = null;
            IdLibro = null;
            FechaPrestamo = null;
            FechaDevolucion = null;
        }
        public bool BuscarPrestamo(string id)
        {
            return Id == id;
        }
    }

}
