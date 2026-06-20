using Clases;
using static System.Net.Mime.MediaTypeNames;

namespace BibliotecaGrafica
{
    public class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program main = new Program();

            test datos = new test();
            datos.CargarDatos();
            cArbolAVL Libros = datos.arbolLibros;
            cArbolAVL Lectores = datos.arbolLectores;
            cArbolAVL Prestamos = datos.arbolPrestamos;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new Form1());
        }
    }
}