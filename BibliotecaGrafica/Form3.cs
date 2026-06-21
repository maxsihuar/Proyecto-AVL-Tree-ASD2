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

        public cArbolAVL arbolLibros;
        public cArbolAVL arbolLectores;
        public cArbolAVL arbolPrestamos;


        public Form3(cArbolAVL arbolLibros, cArbolAVL arbolLectores, cArbolAVL arbolPrestamos)
        {
            InitializeComponent();
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
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
