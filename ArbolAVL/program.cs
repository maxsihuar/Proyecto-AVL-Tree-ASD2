using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;


namespace ArbolAVL
{
       
    class program
    {
        public funciones fn = new funciones();
        #region Menús
        void MenuOS(string titulo)
        {
            Console.WriteLine("===== MENÚ " + titulo + "=====");
            Console.WriteLine("1. Agregar " + titulo);
            Console.WriteLine("2. Modificar " + titulo);
            Console.WriteLine("3. Eliminar " + titulo);
            Console.WriteLine("4. Buscar " + titulo);
            Console.WriteLine("5. Listar " + titulo);
            Console.WriteLine("6. Salir");
            Console.WriteLine("Seleccione una opción: ");

        }
        void MenuLibros(cArbolAVL Libros)
        {
            int opcion_;
            do
            {
                MenuOS("Libro");
                opcion_ = int.Parse(Console.ReadLine());
                switch (opcion_)
                {
                    case 1:
                        fn.InsertarObjeto(Libros);
                        break;
                    case 2:
                        fn.ModificarObjeto(Libros);
                        break;
                    case 3:
                        fn.EliminarObjeto(Libros);
                        break;
                    case 4:
                        fn.BuscarObjeto(Libros);
                        break;
                    case 5:
                        fn.ReporteGeneral(Libros);
                        break;
                    case 6:
                        return;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            }
            while (opcion_ != 6);
        }
        void MenuLectores(cArbolAVL Lectores)
        {
            int opcion_;
            do
            {
                MenuOS("Lector");
                opcion_ = int.Parse(Console.ReadLine());
                switch (opcion_)
                {
                    case 1:
                        fn.InsertarObjeto(Lectores);
                        break;
                    case 2:
                        fn.ModificarObjeto(Lectores);
                        break;
                    case 3:
                        fn.EliminarObjeto(Lectores);
                        break;
                    case 4:
                        fn.BuscarObjeto(Lectores);
                        break;
                    case 5:
                        fn.ReporteGeneral(Lectores);
                        break;
                    case 6:
                        return;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            }
            while (opcion_ != 6);
        }
        void MenuPrestamos(cArbolAVL Prestamos, cArbolAVL Libros, cArbolAVL Lectores)
        {
            int opcion_;
            do
            {
                MenuOS("Prestamo");
                opcion_ = int.Parse(Console.ReadLine());
                switch (opcion_)
                {
                    case 1:
                        fn.InsertarPrestamo(Prestamos, Libros, Lectores);
                        break;
                    case 2:
                        fn.ModificarObjeto(Prestamos);
                        break;
                    case 3:
                        fn.EliminarObjeto(Prestamos);
                        break;
                    case 4:
                        fn.BuscarObjeto(Prestamos);
                        break;
                    case 5:
                        fn.ReporteGeneral(Prestamos);
                        break;
                    case 6:
                        return;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            }
            while (opcion_ != 6);
        }
        void Menu(cArbolAVL Prestamos, cArbolAVL Libros, cArbolAVL Lectores)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("\n===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1. Registrar Libro");
                Console.WriteLine("2. Registrar Lector");
                Console.WriteLine("3. Registrar Préstamo");
                Console.WriteLine("4. Reportes");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        MenuLibros(Libros);
                        break;
                    case 2:
                        MenuLectores(Lectores);
                        break;
                    case 3:
                        MenuPrestamos(Prestamos, Libros, Lectores);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 5);
        }
        #endregion

        static void Main(string[] args)
        {
            program main = new program();

            test datos = new test();
            datos.CargarDatos();
            cArbolAVL Libros = datos.arbolLibros;
            cArbolAVL Lectores = datos.arbolLectores;
            cArbolAVL Prestamos = datos.arbolPrestamos;

            main.Menu(Prestamos, Libros, Lectores);
            funciones hola = new funciones();
            hola.ReporteListarPorEspecialidad(Libros);
        }
    }
}
