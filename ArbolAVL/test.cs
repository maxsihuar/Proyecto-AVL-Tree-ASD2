using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ArbolAVL
{
    public class test
    {
        public void CargarDatos()
        {
            //ARBOLES AVL
            cArbolAVL arbolLibros = new cArbolAVL();
            cArbolAVL arbolLectores = new cArbolAVL();
            cArbolAVL arbolPrestamos = new cArbolAVL();

            //Libros
            cLibro libro1 = new cLibro { Id = "L001", Titulo = "C#", Autor = "Juan Pérez", Anio = "2020", Especialidad = "Programación" };
            cLibro libro2 = new cLibro { Id = "L002", Titulo = "Java", Autor = "Ana López", Anio = "2019", Especialidad = "Software" };
            cLibro libro3 = new cLibro { Id = "L003", Titulo = "Python", Autor = "Carlos Ruiz", Anio = "2021", Especialidad = "Desarrollo" };
            cLibro libro4 = new cLibro { Id = "L004", Titulo = "SQL", Autor = "María Torres", Anio = "2018", Especialidad = "Base de Datos" };
            cLibro libro5 = new cLibro { Id = "L005", Titulo = "Redes", Autor = "Pedro Gómez", Anio = "2017", Especialidad = "Redes" };
            cLibro libro6 = new cLibro { Id = "L006", Titulo = "Linux", Autor = "Luis Díaz", Anio = "2022", Especialidad = "Sistemas" };
            cLibro libro7 = new cLibro { Id = "L007", Titulo = "IA", Autor = "Sofía Ramos", Anio = "2023", Especialidad = "Inteligencia Artificial" };
            arbolLibros.Insertar(libro1);
            arbolLibros.Insertar(libro2);
            arbolLibros.Insertar(libro3);
            arbolLibros.Insertar(libro4);
            arbolLibros.Insertar(libro5);
            arbolLibros.Insertar(libro6);
            arbolLibros.Insertar(libro7);

            //Lectores
            cLector lector1 = new cLector { Id = "U001", AP = "Pérez", AM = "Gómez", Nombre = "Juan", Condicion = "Estudiante", Email = "juan@uni.com" };
            cLector lector2 = new cLector { Id = "U002", AP = "López", AM = "Torres", Nombre = "Ana", Condicion = "Docente", Email = "ana@uni.com" };
            cLector lector3 = new cLector { Id = "U003", AP = "Díaz", AM = "Ramos", Nombre = "Carlos", Condicion = "Estudiante", Email = "carlos@uni.com" };
            cLector lector4 = new cLector { Id = "U004", AP = "Vargas", AM = "Castillo", Nombre = "María", Condicion = "Administrativo", Email = "maria@uni.com" };
            cLector lector5 = new cLector { Id = "U005", AP = "Sánchez", AM = "Ruiz", Nombre = "Pedro", Condicion = "Estudiante", Email = "pedro@uni.com" };
            cLector lector6 = new cLector { Id = "U006", AP = "Flores", AM = "Quispe", Nombre = "Lucía", Condicion = "Docente", Email = "lucia@uni.com" };
            cLector lector7 = new cLector { Id = "U007", AP = "Mendoza", AM = "Rojas", Nombre = "Luis", Condicion = "Estudiante", Email = "luis@uni.com" };
            arbolLectores.Insertar(lector1);
            arbolLectores.Insertar(lector2);
            arbolLectores.Insertar(lector3);
            arbolLectores.Insertar(lector4);
            arbolLectores.Insertar(lector5);
            arbolLectores.Insertar(lector6);
            arbolLectores.Insertar(lector7);

            //Prestamos
            cPrestamo prestamo1 = new cPrestamo { Id = "P001", IdLector = "U001", IdLibro = "L001", FechaPrestamo = "01/06/2026", FechaDevolucion = "15/06/2026" };
            cPrestamo prestamo2 = new cPrestamo { Id = "P002", IdLector = "U002", IdLibro = "L003", FechaPrestamo = "02/06/2026", FechaDevolucion = "16/06/2026" };
            cPrestamo prestamo3 = new cPrestamo { Id = "P003", IdLector = "U003", IdLibro = "L005", FechaPrestamo = "03/06/2026", FechaDevolucion = "17/06/2026" };
            cPrestamo prestamo4 = new cPrestamo { Id = "P004", IdLector = "U004", IdLibro = "L002", FechaPrestamo = "04/06/2026", FechaDevolucion = "18/06/2026" };
            cPrestamo prestamo5 = new cPrestamo { Id = "P005", IdLector = "U005", IdLibro = "L007", FechaPrestamo = "05/06/2026", FechaDevolucion = "19/06/2026" };
            cPrestamo prestamo6 = new cPrestamo { Id = "P006", IdLector = "U006", IdLibro = "L004", FechaPrestamo = "06/06/2026", FechaDevolucion = "20/06/2026" };
            cPrestamo prestamo7 = new cPrestamo { Id = "P007", IdLector = "U007", IdLibro = "L006", FechaPrestamo = "07/06/2026", FechaDevolucion = "21/06/2026" };
            arbolPrestamos.Insertar(prestamo1);
            arbolPrestamos.Insertar(prestamo2);
            arbolPrestamos.Insertar(prestamo3);
            arbolPrestamos.Insertar(prestamo4);
            arbolPrestamos.Insertar(prestamo5);
            arbolPrestamos.Insertar(prestamo6);
            arbolPrestamos.Insertar(prestamo7);

        }
    }
}
