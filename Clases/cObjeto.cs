using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class cObjeto
    {
        public string Id { get; set; }

        public virtual void Pedir()
        {
            Console.Write("Ingrese ID: ");
            Id = Console.ReadLine();
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("ID: " + Id);
        }
        public virtual void Modificar(string id)
        {
            Id = id;
        }
        public virtual void Eliminar()
        {
            Id = null;
        }
        public virtual bool Comparar(string id)
        {
            return Id == id;
        }
    }
}
