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
        public string IdLibro { get; set; }
        public string FechaPrestamo { get; set; }
        public string FechaDevolucion { get; set; }

        public override void Pedir()
        {

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

            Console.WriteLine($"{base.Id, -8} | {IdLector,-10} |{IdLibro,-10} | {FechaPrestamo,-12} | {FechaDevolucion}");
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
        public bool FueraDePlazo()
        {
            if(FechaDevolucion == null || FechaDevolucion.Trim() == "")
            {
                return false;
            }
            DateTime fechadev = DateTime.Parse(FechaDevolucion);
            return DateTime.Today > fechadev;
        }

    }

}
