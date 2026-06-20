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
        #region Menús
        void MenuOS(string titulo)
        {
            Console.WriteLine("===== MENÚ REGISTRAR " + titulo + "=====");
            Console.WriteLine("1. Agregar " + titulo);
            Console.WriteLine("2. Mostrar " + titulo);
            Console.WriteLine("3. Modificar " + titulo);
            Console.WriteLine("4. Eliminar " + titulo);
            Console.WriteLine("5. Buscar " + titulo);
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
                        cLibro Libro = new cLibro();
                        Libro.Pedir();
                        Libros.Insertar(Libro);
                        Console.WriteLine("Libro agregado exitosamente.");
                        break;
                    case 2:
                        break;

                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
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
                        cLector Lector = new cLector();
                        Lector.Pedir();
                        Lectores.Insertar(Lector);
                        Console.WriteLine("Lector agregado exitosamente.");
                        break;
                    case 2:
                        break;

                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            }
            while (opcion_ != 6);
        }
        void MenuPrestamos(cArbolAVL Prestamos)
        {
            int opcion_;
            do
            {
                MenuOS("Prestamo");
                opcion_ = int.Parse(Console.ReadLine());
                switch (opcion_)
                {
                    case 1:
                        cPrestamo Prestamo = new cPrestamo();
                        Prestamo.Pedir();
                        Prestamos.Insertar(Prestamo);
                        Console.WriteLine("Prestamo agregado exitosamente.");
                        break;
                    case 2:
                        break;

                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            }
            while (opcion_ != 6);
        }
        void Menu()
        {
            int opcion;

            do
            {
                Console.WriteLine("\n===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1. Registrar Libro");
                Console.WriteLine("2. Registrar Lector");
                Console.WriteLine("3. Registrar Préstamo");
                Console.WriteLine("4. Reportes");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        //MenuLibros(new Object());
                        break;
                    case 2:
                        //MenuLectores(new Object());
                        break;
                    case 3:
                        //MenuPrestamos(new Object());
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
            test datos = new test();
            datos.CargarDatos();
            cArbolAVL Libros = datos.arbolLibros;
            cArbolAVL Lectores = datos.arbolLectores;
            cArbolAVL Prestamos = datos.arbolPrestamos;
            Console.WriteLine(Libros.Buscar("L001"));
        }
    }
}
