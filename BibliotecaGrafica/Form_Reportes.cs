using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliotecaGrafica
{
    public partial class Form_Reportes : Form
    {
        private string ObjetoSeleccionado { get; set; }
        private DataTable tabla;


        public cArbolAVL arbolLibros { get; set; }
        public cArbolAVL arbolLectores { get; set; }
        public cArbolAVL arbolPrestamos { get; set; }
        public Form1 form_Anterior { get; set; }

        public Controlador control = new Controlador();

        public Form_Reportes(string Objeto, Form1 Anterior)
        {
            ObjetoSeleccionado = Objeto;
            form_Anterior = Anterior;
            arbolLibros = Anterior.arbolLibros;
            arbolLectores = Anterior.arbolLectores;
            arbolPrestamos = Anterior.arbolPrestamos;

            InitializeComponent();
            lb_Titulo.Text = $"LISTA DE {ObjetoSeleccionado.ToUpper()}";
            lb_Titulo.Location = new Point((this.ClientSize.Width - lb_Titulo.Size.Width) / 2, 40);
            Iniciar();
            Listar();
        }

        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Id");

            if (ObjetoSeleccionado == "Libro")
            {
                tabla.Columns.Add("Titulo");
                tabla.Columns.Add("Autor");
                tabla.Columns.Add("Año");
                tabla.Columns.Add("Especialidad");
            }
            if (ObjetoSeleccionado == "Lector")
            {
                tabla.Columns.Add("Apellido Paterno");
                tabla.Columns.Add("Apellido Materno");
                tabla.Columns.Add("Nombre");
                tabla.Columns.Add("Condicion");
                tabla.Columns.Add("Email");
            }
            if (ObjetoSeleccionado == "Prestamo")
            {
                tabla.Columns.Add("IdLector");
                tabla.Columns.Add("IdLibro");
                tabla.Columns.Add("Fecha de Prestamo");
                tabla.Columns.Add("Fecha de Devolucion");
            }

            dataGridView1.DataSource = tabla;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ConfigurarPorcentajesColumnas();
        }

        private void ConfigurarPorcentajesColumnas()
        {
            // Verificamos que existan columnas para evitar errores
            if (dataGridView1.Columns.Count == 0) return;

            if (ObjetoSeleccionado == "Libro")
            {
                // Total = 100%
                dataGridView1.Columns["Id"].FillWeight = 10;           // 10%
                dataGridView1.Columns["Titulo"].FillWeight = 35;       // 35%
                dataGridView1.Columns["Autor"].FillWeight = 25;        // 25%
                dataGridView1.Columns["Año"].FillWeight = 10;          // 10%
                dataGridView1.Columns["Especialidad"].FillWeight = 20; // 20%
            }
            else if (ObjetoSeleccionado == "Lector")
            {
                // Total = 100%
                dataGridView1.Columns["Id"].FillWeight = 10;                // 10%
                dataGridView1.Columns["Apellido Paterno"].FillWeight = 17;  // 20%
                dataGridView1.Columns["Apellido Materno"].FillWeight = 17;  // 20%
                dataGridView1.Columns["Nombre"].FillWeight = 12;            // 20%
                dataGridView1.Columns["Condicion"].FillWeight = 20;         // 10%
                dataGridView1.Columns["Email"].FillWeight = 24;             // 20%
            }
            else if (ObjetoSeleccionado == "Prestamo")
            {
                // Total = 100%
                dataGridView1.Columns["Id"].FillWeight = 10;                  // 10%
                dataGridView1.Columns["IdLector"].FillWeight = 15;            // 15%
                dataGridView1.Columns["IdLibro"].FillWeight = 15;             // 15%
                dataGridView1.Columns["Fecha de Prestamo"].FillWeight = 30;   // 30%
                dataGridView1.Columns["Fecha de Devolucion"].FillWeight = 30; // 30%
            }
        }

        private void Listar()
        {
            if (ObjetoSeleccionado == "Libro")
            {
                List<List<string>> datos = control.ReporteGeneral(arbolLibros);
                foreach (List<string> l in datos)
                {
                    DataRow fila = tabla.NewRow();
                    fila["Id"] = l[0];
                    fila["Titulo"] = l[1];
                    fila["Autor"] = l[2];
                    fila["Año"] = l[3];
                    fila["Especialidad"] = l[4];
                    tabla.Rows.Add(fila);
                }
            }
            if (ObjetoSeleccionado == "Lector")
            {
                List<List<string>> datos = control.ReporteGeneral(arbolLectores);
                foreach (List<string> l in datos)
                {
                    DataRow fila = tabla.NewRow();
                    fila["Id"] = l[0];
                    fila["Apellido Paterno"] = l[1];
                    fila["Apellido Materno"] = l[2];
                    fila["Nombre"] = l[3];
                    fila["Condicion"] = l[4];
                    fila["Email"] = l[5];
                    tabla.Rows.Add(fila);
                }
            }
            if (ObjetoSeleccionado == "Prestamo")
            {
                List<List<string>> datos = control.ReporteGeneral(arbolPrestamos);
                foreach (List<string> l in datos)
                {
                    DataRow fila = tabla.NewRow();
                    fila["Id"] = l[0];
                    fila["IdLector"] = l[1];
                    fila["IdLibro"] = l[2];
                    fila["Fecha de Prestamo"] = l[3];
                    fila["Fecha de Devolucion"] = l[4];
                    tabla.Rows.Add(fila);
                }
            }

        }


        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            form_Anterior.StartPosition = FormStartPosition.Manual;
            form_Anterior.Location = this.Location;
            form_Anterior.Size = this.Size;
            form_Anterior.Show();
            this.Hide();
        }
    }
}
