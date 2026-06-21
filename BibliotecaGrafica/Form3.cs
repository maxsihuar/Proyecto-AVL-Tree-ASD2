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

namespace BibliotecaGrafica
{
    public partial class Form3 : Form
    {
        private Form1 form_Anterior;

        public cArbolAVL arbolLibros { get; set; }
        public cArbolAVL arbolLectores { get; set; }
        public cArbolAVL arbolPrestamos { get; set; }


        public Form3(Form1 form_Anterior, cArbolAVL arbolLibros, cArbolAVL arbolLectores, cArbolAVL arbolPrestamos)
        {
            InitializeComponent();
            this.form_Anterior = form_Anterior;
            this.arbolLectores = arbolLectores;
            this.arbolPrestamos = arbolPrestamos;
            this.arbolLibros = arbolLibros;
           
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            form_Anterior.StartPosition = FormStartPosition.Manual;
            form_Anterior.Location = this.Location;
            form_Anterior.Size = this.Size;
            form_Anterior.Show();
            this.Hide();
        }

        private void btn_Insetar_Click(object sender, EventArgs e)
        {
            Form_Reportes form = new Form_Reportes("por Especialidad", this);
            form.FormClosed += (s, args) => Application.Exit();
            form.Location = this.Location; form.Size = this.Size;
            form.Show();
            this.Hide();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Form_Reportes form = new Form_Reportes("de Prestamos sin Devolución", this);
            form.FormClosed += (s, args) => Application.Exit();
            form.Location = this.Location; form.Size = this.Size;
            form.Show();
            this.Hide();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
           Form_Reportes form = new Form_Reportes("de Lectores con Libros Pendientes", this);
            form.FormClosed += (s, args) => Application.Exit();
            form.Location = this.Location; form.Size = this.Size;
            form.Show();
            this.Hide();
        }
    }
}
