using Clases;


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

        public void ReporteListarPorEspecialidad(cArbolAVL arbol)

        {
            List<cObjeto> lista = arbol.InOrden();
            Console.Write("Ingrese la especialidad a listar: ");
            string especialidad = Console.ReadLine();
            Console.WriteLine(especialidad);
            Console.WriteLine(new string('-', 112));

            Console.WriteLine($"{"ID",-8} | {"Título",-35} | {"Autor",-25} | {"Año",-6} | {"Especialidad"}");

            Console.WriteLine(new string('-', 112));

            foreach (cObjeto x in lista)
            {
                if (x is cLibro libro)
                {
                    if (libro.Especialidad == especialidad)
                    {
                        libro.Mostrar();
                    }
                }
            }

        }
        public void ReporteListarPrestamosFechadeDev(cArbolAVL arbol)
        {
            List<cObjeto> lista = arbol.InOrden();

            Console.WriteLine(new string('-', 75));

            Console.WriteLine($"{"ID Pres.",-8} | {"ID Lector",-10} |{"ID Libro",-10} | {"F. Préstamo",-12} | {"F. Devolución"}");

            Console.WriteLine(new string('-', 75));

            foreach (cObjeto x in lista)
            {
                if (x is cPrestamo prestamo)
                {
                    if (prestamo.FechaDevolucion == null)
                    {
                        prestamo.Mostrar();
                    }
                }

            }

        }
        public void ReporteListaPendientesdeDevolucion(cArbolAVL arbol)
        {
            List<cObjeto> lista = arbol.InOrden();
            Console.WriteLine(new string('-', 75));

            Console.WriteLine($"{"ID Pres.",-8} | {"ID Lector",-10} |{"ID Libro",-10} | {"F. Préstamo",-12} | {"F. Devolución"}");

            Console.WriteLine(new string('-', 75));
            foreach (cObjeto x in lista)
            {
                if (x is cPrestamo prestamo)
                {
                    if (prestamo.FueraDePlazo())
                    {
                        prestamo.Mostrar();
                    }
                }
            }
        }
        #endregion 


    }
}
