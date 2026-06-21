using Clases;
using System.Collections.Generic;


// 101 Elemento Existe
// 102 Elemento no Existe
// 103 Error General

namespace BibliotecaGrafica
{
    public class Controlador
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

        public List<string> InsertarObjeto(cArbolAVL arbol, List<string> datos)
        {
            if(datos.Count() == 0)
            {
                return ["Error al cargar los datos", "Error"];
            }

            if(arbol.Tipo == "Libro")
            {
                cLibro dato = new cLibro();
                dato.Id = datos[0];
                dato.Titulo = datos[1];
                dato.Autor = datos[2];
                dato.Anio = datos[3];
                dato.Especialidad = datos[4];
                arbol.Insertar(dato);
            }
            if (arbol.Tipo == "Lector")
            {
                cLector dato = new cLector();
                dato.Id = datos[0];
                dato.AP = datos[1];
                dato.AM = datos[2];
                dato.Nombre = datos[3];
                dato.Condicion = datos[4];
                dato.Email = datos[5];
                arbol.Insertar(dato);
            }
            if (arbol.Tipo == "Prestamo")
            {
                cPrestamo dato = new cPrestamo();
                dato.Id = datos[0];
                dato.IdLector = datos[1];
                dato.IdLibro = datos[2];
                dato.FechaPrestamo = datos[3];
                dato.FechaDevolucion = datos[4];
                arbol.Insertar(dato);
            }

            return ["Agregado Correctamente", "Exitoso"];
        }

        public List<string> ModificarObjeto(cArbolAVL arbol, List<string> datos)
        {
            if (datos.Count() == 0)
            {
                return ["Error al cargar los datos", "Error"];
            }

            if (arbol.Tipo == "Libro")
            {
                cLibro dato = new cLibro();
                dato.Id = datos[0];
                dato.Titulo = datos[1];
                dato.Autor = datos[2];
                dato.Anio = datos[3];
                dato.Especialidad = datos[4];
                arbol.Modificar(dato.Id,dato);
            }
            if (arbol.Tipo == "Lector")
            {
                cLector dato = new cLector();
                dato.Id = datos[0];
                dato.AP = datos[1];
                dato.AM = datos[2];
                dato.Nombre = datos[3];
                dato.Condicion = datos[4];
                dato.Email = datos[5];
                arbol.Modificar(dato.Id,dato);
            }
            if (arbol.Tipo == "Prestamo")
            {
                cPrestamo dato = new cPrestamo();
                dato.Id = datos[0];
                dato.IdLector = datos[1];
                dato.IdLibro = datos[2];
                dato.FechaPrestamo = datos[3];
                dato.FechaDevolucion = datos[4];
                arbol.Modificar(dato.Id,dato);
            }

            return ["Agregado Correctamente", "Exitoso"];
        }

        public List<string> EliminarObjeto(cArbolAVL arbol, string Id)

        {
            List<cObjeto> lista = arbol.InOrden();
            cObjeto encontrado = lista.FirstOrDefault(o => o.Id == Id);

            if (encontrado == null)
            {
                return ["Error al encontrar el elemento", "Error"];
            }
            else
            {
                arbol.Eliminar(Id);
                return ["Eliminado Correctamente", "Exitoso"];
            }
        }
        

        public List<string> BuscarObjeto(cArbolAVL arbol, string id)
        {
            List<cObjeto> lista = arbol.InOrden();
            cObjeto encontrado = lista.FirstOrDefault(o => o.Id == id);

            if (encontrado == null)
            {
                return ["Error al encontrar el elemento", "Error"];
            }
            else
            {
                if (encontrado is cLibro libro)
                {
                    return [libro.Id, libro.Titulo, libro.Autor, libro.Anio, libro.Especialidad, "Exitoso"];
                }
                else if (encontrado is cLector lector)
                {
                    return [lector.Id, lector.AP, lector.AM, lector.Nombre, lector.Condicion, lector.Email, "Exitoso"];
                }
                else if (encontrado is cPrestamo prestamo)
                {
                    return [prestamo.Id, prestamo.IdLector, prestamo.IdLibro, prestamo.FechaPrestamo, prestamo.FechaDevolucion, "Exitoso"];
                }
            }
            return ["Error Desconocido", "Error"];
        }

        #region ************Reportes*****************

        public List<List<string>> ReporteGeneral(cArbolAVL arbol)
        {
            List<cObjeto> lista = arbol.InOrden();
            List<List<string>> ListaF = new List<List<string>>();

            if (lista.Count() == 0)
            {
                Console.WriteLine("No hay datos para mostrar");
            }

            if (lista.FirstOrDefault() is cLibro)
            {
                foreach(cLibro libro in lista)
                {
                    List<string> datos = new List<string>();
                    datos.Add(libro.Id);
                    datos.Add(libro.Titulo);
                    datos.Add(libro.Autor);
                    datos.Add(libro.Anio);
                    datos.Add(libro.Especialidad);
                    ListaF.Add(datos);
                }
            }
            else if (lista.FirstOrDefault() is cPrestamo)
            {
                foreach (cPrestamo prestamo in lista)
                {
                    List<string> datos = new List<string>();
                    datos.Add(prestamo.Id);
                    datos.Add(prestamo.IdLector);
                    datos.Add(prestamo.IdLibro);
                    datos.Add(prestamo.FechaPrestamo);
                    datos.Add(prestamo.FechaDevolucion);
                    ListaF.Add(datos);
                }
            }
            else
            {
                foreach (cLector lector in lista)
                {
                    List<string> datos = new List<string>();
                    datos.Add(lector.Id);
                    datos.Add(lector.AP);
                    datos.Add(lector.AM);
                    datos.Add(lector.Nombre);
                    datos.Add(lector.Condicion);
                    datos.Add(lector.Email);
                    ListaF.Add(datos);
                }
            }
            return ListaF;
        }

        public List<List<string>> ReporteListarPorEspecialidad(cArbolAVL arbol, string especialidad)
        {
            List<List<string>> datos = new List<List<string>>();
            List<cObjeto> lista = arbol.InOrden();

            foreach (cLibro libro in lista)
            {
                if (libro.Especialidad == especialidad)
                {
                    List<string> dato = new List<string>();
                    dato.Add(libro.Id);
                    dato.Add(libro.Titulo);
                    dato.Add(libro.Autor);
                    dato.Add(libro.Anio);
                    dato.Add(libro.Especialidad);
                    datos.Add(dato);
                }
            }

            return datos;

        }
        public List<List<string>> ReporteListarPrestamosFechadeDev(cArbolAVL arbol)
        {
            List<cObjeto> lista = arbol.InOrden();
            List<List<string>> datos = new List<List<string>>();

            foreach (cPrestamo prestamo in lista)
            {
                if (prestamo.FechaDevolucion == null  || prestamo.FechaDevolucion.Trim() == "")
                 {
                    List<string> dato = new List<string>();
                    dato.Add(prestamo.Id);
                    dato.Add(prestamo.IdLector);
                    dato.Add(prestamo.IdLibro);
                    dato.Add(prestamo.FechaPrestamo);
                    dato.Add("Sin Fecha");
                    datos.Add(dato);
                }
            }
            return datos;
        }
        public List<List<string>> ReporteListaPendientesdeDevolucion(cArbolAVL arbolPrestamo, cArbolAVL arbolLectores)
        {
            List<List<string>> ListaF = new List<List<string>>();
            List<cObjeto> lista = arbolPrestamo.InOrden();
            List<cObjeto> listaL = arbolLectores.InOrden();

            foreach (cPrestamo prestamo in lista)
            {
                if (prestamo.FueraDePlazo())
                {
                    string id = prestamo.IdLector;
                    foreach(cLector lector in listaL)
                    {
                        if(lector.Id == id)
                        {
                            List<string> datos = new List<string>();
                            datos.Add(lector.Id);
                            datos.Add(lector.AP);
                            datos.Add(lector.AM);
                            datos.Add(lector.Nombre);
                            datos.Add(lector.Condicion);
                            datos.Add(lector.Email);
                            ListaF.Add(datos);
                        }
                    }
                }
            }

            return ListaF;
        }
        #endregion 


    }
}
