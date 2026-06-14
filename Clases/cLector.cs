using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class cLector
    {
        public string Id { get; set; }
        public string AP { get; set; }
        public string AM { get; set; }
        public string Nombre { get; set; }
        public string Condicion { get; set; }
        public string Email { get; set; }

        public void AgregarLector(string id, string ap, string am, string nombre, string condicion, string email)
        {
            Id = id;
            AP = ap;
            AM = am;
            Nombre = nombre;
            Condicion = condicion;
            Email = email;
        }
        public void MostrarLector()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Apellido Paterno: " + AP);
            Console.WriteLine("Apellido Materno: " + AM);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Condición: " + Condicion);
            Console.WriteLine("Email: " + Email);
        }
        public void ModificarLector(string id, string ap, string am, string nombre, string condicion, string email)
        {
            Id = id;
            AP = ap;
            AM = am;
            Nombre = nombre;
            Condicion = condicion;
            Email = email;
        }
        public void EliminarLector()
        {
            Id = null;
            AP = null;
            AM = null;
            Nombre = null;
            Condicion = null;
            Email = null;
        }
        public bool BuscarLector(string id)
        {
            return Id == id;
        }
    }
}
