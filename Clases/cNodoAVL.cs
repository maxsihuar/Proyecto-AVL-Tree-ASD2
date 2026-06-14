using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class cNodoAVL
    {
        public Object dato;
        public cNodoAVL hijoIzquierdo;
        public cNodoAVL hijoDerecho;
        public int altura;

        public cNodoAVL(Object Dato)
        {
            dato = Dato;
            altura = 1;
        }
    }
}
