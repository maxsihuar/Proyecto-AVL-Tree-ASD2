using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolAVL
{
    public string ValidarExistenciaId(cArbolAVL arbol, int id) 
    {
        if (arbol.Buscar(id))
        {
            return "ID encontrado.";
        }
        else
        {
            return "ID no encontrado.";
        }
    }
    public void InsertarObjeto(cArbolAVL arbol, cObjeto dato)
    {

    }


    internal class funciones
    {
    }
}
