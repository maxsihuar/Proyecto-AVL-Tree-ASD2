using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Clases
{
    class cArbolAVL
    {
        private cNodoAVL raiz;

        #region Metodos Privados
         
        private int Altura(cNodoAVL nodo)
        {
            return nodo == null ? 0 : nodo.altura;
        }
        private void ActualizarAltura(cNodoAVL nodo)
        {
            nodo.altura = 1 + Math.Max(Altura(nodo.hijoIzquierdo), Altura(nodo.hijoDerecho));
        }

        private int ObtenerFE(cNodoAVL nodo)
        {
            return nodo == null ? 0 : Altura(nodo.hijoIzquierdo) - Altura(nodo.hijoDerecho);
        }

        // Rotaciones
        
        private cNodoAVL RotacionLL(cNodoAVL y)
        {
            cNodoAVL x = y.hijoIzquierdo;
            cNodoAVL T2 = x.hijoDerecho;
            x.hijoDerecho = y;
            y.hijoIzquierdo = T2;
            ActualizarAltura(y);
            ActualizarAltura(x);
            return x;
        }

        private cNodoAVL RotacionRR(cNodoAVL x)
        {
            cNodoAVL y = x.hijoDerecho;
            cNodoAVL T2 = y.hijoIzquierdo;
            y.hijoIzquierdo = x;
            x.hijoDerecho = T2;
            ActualizarAltura(x);
            ActualizarAltura(y);
            return y;
        }

        private cNodoAVL Balancear(cNodoAVL nodo)
        {
            int FE = ObtenerFE(nodo);

            switch (FE)
            {
                case < -1 when ObtenerFE(nodo.hijoIzquierdo) <= 0:
                    return RotacionLL(nodo);
                case < -1 when ObtenerFE(nodo.hijoIzquierdo) > 0:
                    nodo.hijoIzquierdo = RotacionRR(nodo.hijoIzquierdo);
                    return RotacionLL(nodo);
                case > 1 when ObtenerFE(nodo.hijoDerecho) >= 0:
                    return RotacionRR(nodo);
                case > 1 when ObtenerFE(nodo.hijoDerecho) < 0:
                    nodo.hijoDerecho = RotacionLL(nodo.hijoDerecho);
                    return RotacionRR(nodo);
                default:
                    return nodo;
            }
        }

        private cNodoAVL _Insertar(cNodoAVL nodo, Object dato)
        {
            if (nodo == null)
            {
                return new cNodoAVL(dato);
            }

            if (((dynamic)dato).Id < ((dynamic)nodo.dato).Id())
            {
                nodo.hijoIzquierdo = _Insertar(nodo.hijoIzquierdo, dato);
            }
            else if (((dynamic)dato).Id > ((dynamic)nodo.dato).Id())
            {
                nodo.hijoDerecho = _Insertar(nodo.hijoDerecho, dato);
            }
            else
            {
                return nodo;
            }

            this.ActualizarAltura(nodo);
            return this.Balancear(nodo);
        }


        #endregion
    }
}
