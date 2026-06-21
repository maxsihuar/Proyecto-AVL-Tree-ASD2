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
    public partial class Form2 : Form
    {
        private Form1 form_Anterior;

        public cArbolAVL arbolLibros { get; set; }
        public cArbolAVL arbolLectores { get; set; }
        public cArbolAVL arbolPrestamos { get; set; }

        public string ObjetoSeleccionado { get; set; }
        public Form2(string Titulo, string Objeto, Form1 anterior)
        {
            ObjetoSeleccionado = Objeto;
            form_Anterior = anterior;
            arbolLibros = anterior.arbolLibros;
            arbolLectores = anterior.arbolLectores;
            arbolPrestamos = anterior.arbolPrestamos;

            InitializeComponent();
            lb_Titulo.Text = Titulo;
            lb_Titulo.Location = new Point((this.ClientSize.Width - lb_Titulo.Size.Width) / 2, 40);
        }

        private void lb_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insetar_Click(object sender, EventArgs e)
        {
            Form_Insetar_Modificar formInsetarModificar = new Form_Insetar_Modificar(ObjetoSeleccionado, "Insertar", this);
            formInsetarModificar.FormClosed += (s, args) => Application.Exit();

            formInsetarModificar.StartPosition = FormStartPosition.Manual;
            formInsetarModificar.Location = this.Location;
            formInsetarModificar.Size = this.Size;

            formInsetarModificar.Show();
            this.Hide();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Form_Insetar_Modificar formInsetarModificar = new Form_Insetar_Modificar(ObjetoSeleccionado, "Modificar", this);
            formInsetarModificar.FormClosed += (s, args) => Application.Exit();

            formInsetarModificar.StartPosition = FormStartPosition.Manual;
            formInsetarModificar.Location = this.Location;
            formInsetarModificar.Size = this.Size;

            formInsetarModificar.Show();
            this.Hide();
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Form_Eliminar form_Eliminar = new Form_Eliminar(ObjetoSeleccionado, this);
            form_Eliminar.FormClosed += (s, args) => Application.Exit();
            form_Eliminar.StartPosition = FormStartPosition.Manual;
            form_Eliminar.Location = this.Location;
            form_Eliminar.Size = this.Size;
            form_Eliminar.Show();
            this.Hide();
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Form_Buscar form_Buscar = new Form_Buscar(ObjetoSeleccionado, this);
            form_Buscar.FormClosed += (s, args) => Application.Exit();
            form_Buscar.StartPosition = FormStartPosition.Manual;
            form_Buscar.Location = this.Location;
            form_Buscar.Size = this.Size;
            form_Buscar.Show();
            this.Hide();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            form_Anterior.StartPosition = FormStartPosition.Manual;
            form_Anterior.Location = this.Location;
            form_Anterior.Size = this.Size;
            form_Anterior.Show();
            this.Hide();
        }

        
    }
}
