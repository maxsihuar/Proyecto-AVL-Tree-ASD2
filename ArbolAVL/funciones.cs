using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 101 Elemento Existe
// 102 Elemento no Existe
// 103 Error General

namespace ArbolAVL
{
    internal class funciones
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

        public void InsertarObjeto(cArbolAVL arbol)
        {   
            cObjeto dato = new cObjeto();
            dato.Pedir();

            int resultado = ValidarId(arbol, dato.Id);

            if (resultado == 102)
            {
                arbol.Insertar(dato);
            }
            else
            {
                Console.WriteLine("ERROR : El objeto ya existe");
            }
        }

        public void InsertarPrestamo(cArbolAVL arbol, cArbolAVL arbolLibros, cArbolAVL arbolLector)
        {
            cPrestamo dato = new cPrestamo();
            dato.Pedir();

            int resultadoLibro = ValidarId(arbolLibros, dato.IdLibro);
            int reultadoLector = ValidarId(arbolLector, dato.IdLector);

            int resultado = ValidarId(arbol, dato.Id);

            if (resultado == 102 && resultadoLibro == 101 && reultadoLector == 101)
            {
                arbol.Insertar(dato);
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

        public void ModificarObjeto(cArbolAVL arbol, cObjeto dato)
        {
            int resultado = ValidarId(arbol, dato.Id);
            if (resultado == 101)
            {
                arbol.Modificar(dato.Id, dato);
            }
            else
            {
                Console.WriteLine("ERROR : El objeto no existe");
            }
        }

        public void EliminarObjeto(cArbolAVL arbol, string id)
        {
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

        #region ************Reportes*****************

        public void ReporteGeneral(cArbolAVL arbol)
        {
            List<cObjeto> lista = arbol.InOrden();


        }


        #endregion 

    }
}
