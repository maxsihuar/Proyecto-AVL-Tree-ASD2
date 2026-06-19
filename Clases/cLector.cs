using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class cLector : cObjeto
    {
        public string AP { get; set; }
        public string AM { get; set; }
        public string Nombre { get; set; }
        public string Condicion { get; set; }
        public string Email { get; set; }

        public override void Pedir()
        {
            base.Pedir();

            Console.Write("Ingrese AP: ");
            AP = Console.ReadLine();

            Console.Write("Ingrese AM: ");
            AM = Console.ReadLine();

            Console.Write("Ingrese Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese Condicion: ");
            Condicion = Console.ReadLine();

            Console.Write("Ingrese Email: ");
            Email = Console.ReadLine();
        }
        public void MostrarLector()
        {
            base.Mostrar();
            Console.WriteLine("Apellido Paterno: " + AP);
            Console.WriteLine("Apellido Materno: " + AM);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Condición: " + Condicion);
            Console.WriteLine("Email: " + Email);
        }
        public void ModificarLector(string id, string ap, string am, string nombre, string condicion, string email)
        {
            base.Modificar(id);
            AP = ap;
            AM = am;
            Nombre = nombre;
            Condicion = condicion;
            Email = email;
        }
        public override void Eliminar()
        {
            base.Eliminar();
            AP = null;
            AM = null;
            Nombre = null;
            Condicion = null;
            Email = null;
        }
    }
}
