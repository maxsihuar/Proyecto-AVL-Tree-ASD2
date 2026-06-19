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
        
        public void InsertarObjeto(cArbolAVL arbol, cObjeto dato)
        {
            int resultado = ValidarId(arbol, dato.Id);

            if (resultado == 102)
            {
                arbol.Insertar(dato);
            }
            else
            {
                Console.WriteLine("103");
            }
        }
    }
}
