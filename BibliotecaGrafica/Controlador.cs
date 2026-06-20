using System;
using Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 101 Elemento Existe
// 102 Elemento no Existe
// 103 Error General

namespace BibliotecaGrafica
{
    internal class Controlador
    {
        public int ValidarId(cArbolAVL arbol, string id)
        {
            if (arbol.Buscar(id))
            {
                return 101;
            }
            else
            {
                return 102;
            }
        }

        public List<string> InsertarObjeto(cArbolAVL arbol)
        {
            List<string> list = new List<string>();
            string id;
            cObjeto dato;

            if (arbol.Tipo == "Libro")
            {
                dato = new cLibro();

                Console.Write("Ingrese el ID del libro: ");
                id = Console.ReadLine();
            }
            else
            {
                dato = new cLector();
                Console.Write("Ingrese el ID del lector: ");
                id = Console.ReadLine();
            }


            int resultado = ValidarId(arbol, id);

            if (resultado == 102)
            {
                dato.Pedir();
                dato.Id = id;
                arbol.Insertar(dato);
                list.Add("101");
                list.Add("Objeto insertado con éxito.");
            }
            else
            {
                list.Add("102");
                list.Add("ERROR : El objeto ya existe");
            }

            return list;
        }

        public void InsertarPrestamo(cArbolAVL arbol, cArbolAVL arbolLibros, cArbolAVL arbolLector)
        {
            cPrestamo dato = new cPrestamo();

            Console.Write("Ingrese el ID del préstamo: ");
            string id = Console.ReadLine();

            int resultadoLibro = ValidarId(arbolLibros, dato.IdLibro);
            int reultadoLector = ValidarId(arbolLector, dato.IdLector);

            int resultado = ValidarId(arbol, id);

            if (resultado == 102 && resultadoLibro == 101 && reultadoLector == 101)
            {
                dato.Pedir();
                dato.Id = id;
                arbol.Insertar(dato);
                Console.WriteLine("Objeto insertado con éxito.");
            }
            else if (resultadoLibro == 102)
            {
                Console.WriteLine("ERROR : El libro no existe");
            }
            else if (reultadoLector == 102)
            {
                Console.WriteLine("ERROR : El lector no existe");
            }
            else
            {
                Console.WriteLine("ERROR : El objeto ya existe");
            }
        }

        public void ModificarObjeto(cArbolAVL arbol)
        {
            cObjeto dato = new cObjeto();

            Console.Write("Ingrese el ID del objeto a modificar: ");
            string id = Console.ReadLine();

            int resultado = ValidarId(arbol, id);
            if (resultado == 101)
            {
                dato.Pedir();
                dato.Id = id;
                arbol.Modificar(id, dato);
            }
            else
            {
                Console.WriteLine("ERROR : El objeto no existe");
            }
        }

        public void EliminarObjeto(cArbolAVL arbol)
        {
            Console.Write("Ingrese el ID del objeto a eliminar: ");
            string id = Console.ReadLine();

            int resultado = ValidarId(arbol, id);
            if (resultado == 101)
            {
                arbol.Eliminar(id);
            }
            else
            {
                Console.WriteLine("ERROR : El objeto no existe");
            }
        }

        public void BuscarObjeto(cArbolAVL arbol)
        {
            Console.Write("Ingrese el ID del objeto a buscar: ");
            string id = Console.ReadLine();
            if (arbol.Buscar(id))
            {
                Console.WriteLine("El objeto existe:");
                List<cObjeto> lista = arbol.InOrden();
                cObjeto encontrado = lista.FirstOrDefault(o => o.Id == id);
                encontrado.Mostrar();

            }
            else
            {
                Console.WriteLine("El objeto no existe");
            }
        }

        #region ************Reportes*****************

        public void ReporteGeneral(cArbolAVL arbol)
        {
            List<cObjeto> lista = arbol.InOrden();

            if (lista.Count() == 0)
            {
                Console.WriteLine("No hay datos para mostrar");
                return;
            }

            if (lista.FirstOrDefault() is cLibro)
            {
                Console.WriteLine(new string('-', 112));

                Console.WriteLine($"{"ID",-8} | {"Título",-35} | {"Autor",-25} | {"Año",-6} | {"Especialidad"}");

                Console.WriteLine(new string('-', 112));
            }
            else if (lista.FirstOrDefault() is cPrestamo)
            {

                Console.WriteLine(new string('-', 75));

                Console.WriteLine($"{"ID Pres.",-8} | {"ID Lector",-10} |{"ID Libro",-10} | {"F. Préstamo",-12} | {"F. Devolución"}");

                Console.WriteLine(new string('-', 75));
            }
            else
            {
                Console.WriteLine(new string('-', 115));

                Console.WriteLine($"{"ID",-8} | {"Ape. Paterno",-18} | {"Ape. Materno",-18} | {"Nombre",-20} | {"Condición",-12} | {"Email",-25}");

                Console.WriteLine(new string('-', 115));
            }

            foreach (cObjeto dato in lista)
            {
                dato.Mostrar();
            }
        }


        #endregion 

    }
}
