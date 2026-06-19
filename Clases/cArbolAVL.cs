using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Clases
{
    public class cArbolAVL
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

        private cNodoAVL _Insertar(cNodoAVL nodo, cObjeto dato)
        {
            if (nodo == null)
            {
                return new cNodoAVL(dato);
            }

            if (dato.Id < nodo.dato.Id)
            {
                nodo.hijoIzquierdo = _Insertar(nodo.hijoIzquierdo, dato);
            }
            else if (dato.Id > nodo.dato.Id)
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

        private cNodoAVL Minimo(cNodoAVL nodo)
        {
            while (nodo.hijoIzquierdo != null)
            {
                nodo = nodo.hijoIzquierdo;
            }
            return nodo;
        }


        private cNodoAVL _Eliminar(cNodoAVL nodo, int id)
        {
            if (nodo == null)
            {
                return null;
            }

            if (id < nodo.dato.Id)
            {
                nodo.hijoIzquierdo = this._Eliminar(nodo.hijoIzquierdo, id);
            }
            else if (id > nodo.dato.Id)
            {
                nodo.hijoDerecho = this._Eliminar(nodo.hijoDerecho, id);
            }
            else
            {
                if (nodo.hijoIzquierdo == null)
                {
                    return nodo.hijoDerecho;
                }
                if (nodo.hijoDerecho == null)
                {
                    return nodo.hijoIzquierdo;
                }

                cNodoAVL succesor = this.Minimo(nodo.hijoDerecho);
                nodo.dato = succesor.dato;
                nodo.hijoDerecho = this._Eliminar(nodo.hijoDerecho, succesor.dato.Id);
            }
            this.ActualizarAltura(nodo);
            return this.Balancear(nodo);

        }

        private bool _Buscar(cNodoAVL nodo, int id)
        {
            if (nodo == null) return false;

            if (nodo.dato.Comparar(id))
            {
                return true;
            }
            else if (nodo.dato.Id > id)
            {
                _Buscar(nodo.hijoIzquierdo, id);
            }
            else
            {
                _Buscar(nodo.hijoDerecho, id);
            }

            return false;
        }

        private void _Modificar(cNodoAVL nodo, int id, Object dato)
        {
            if (nodo == null) return;

            if (nodo.dato.Comparar(id))
            {
                nodo.dato = dato;
                return;
            }
            else if (nodo.dato.Id > id)
            {
                _Modificar(nodo.hijoIzquierdo, id, dato);
            }
            else
            {
                _Modificar(nodo.hijoDerecho, id, dato);
            }
        }

        #endregion

        public void Insertar(Object dato)
        {
            raiz = _Insertar(raiz, dato);
        }
        public void Eliminar(int id)
        {
            raiz = _Eliminar(raiz, id);
        }

        public bool Buscar(int id)
        {
            return _Buscar(raiz, id);
        }

        public void Modificar(int id, cObjeto dato)
        {
            _Modificar(raiz, id, dato);
        }
    }
}
