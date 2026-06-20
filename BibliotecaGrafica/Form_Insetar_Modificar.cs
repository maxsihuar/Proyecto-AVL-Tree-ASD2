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
    public partial class Form_Insetar_Modificar : Form
    {
        private int tm_TextBox = 400;
        private int tm_Label = 100;
        private Form2 form_Anterior;
        public string TipoOperacion { get; set; }
        public string ObjetoSeleccionado { get; set; }
        public Form_Insetar_Modificar(string Objeto, string Tipo, Form2 Anterior)
        {
            ObjetoSeleccionado = Objeto;
            TipoOperacion = Tipo;
            form_Anterior = Anterior;

            InitializeComponent();
            lb_Titulo.Text = $"{TipoOperacion.ToUpper()} {ObjetoSeleccionado.ToUpper()}";
            lb_Titulo.Location = new Point((this.ClientSize.Width - lb_Titulo.Size.Width) / 2, 40);
            ComponentesDinamicos();
        }

        #region ********* Formulario Dinamico**********
        private void ComponentesDinamicos()
        {
            if (ObjetoSeleccionado == string.Empty)
            {
                Label lb1 = new Label();
                lb1.Text = "Hubo un error al cargar la ventana";
                lb1.Width = tm_Label; lb1.Height = 30; lb1.Location = new Point(10, 10);
                lb1.AutoSize = true; lb1.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb1);
            }
            if (this.ObjetoSeleccionado == "Libro")
            {
                Label lb1 = new Label();
                lb1.Text = "Título:";
                lb1.Width = tm_Label; lb1.Height = 30;
                lb1.AutoSize = true; lb1.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb1);

                TextBox txtTitulo = new TextBox();
                txtTitulo.Width = tm_TextBox; txtTitulo.Height = 30;
                tableLayoutPanel1.Controls.Add(txtTitulo);

                Label lb2 = new Label();
                lb2.Text = "Autor:";
                lb2.Width = tm_Label; lb2.Height = 30;
                lb2.AutoSize = true; lb2.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb2);

                TextBox txtAutor = new TextBox();
                txtAutor.Width = tm_TextBox; txtAutor.Height = 30;
                tableLayoutPanel1.Controls.Add(txtAutor);

                Label lb3 = new Label();
                lb3.Text = "Año:";
                lb3.Width = tm_Label; lb3.Height = 30;
                lb3.AutoSize = true; lb3.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb3);

                TextBox txtAnio = new TextBox();
                txtAnio.Width = tm_TextBox; txtAnio.Height = 30;
                tableLayoutPanel1.Controls.Add(txtAnio);

                Label lb4 = new Label();
                lb4.Text = "Especialidad:";
                lb4.Width = tm_Label; lb4.Height = 30;
                lb4.AutoSize = true; lb4.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb4);

                TextBox txtEspecialidad = new TextBox();
                txtEspecialidad.Width = tm_TextBox; txtEspecialidad.Height = 30;
                tableLayoutPanel1.Controls.Add(txtEspecialidad);


            }

        }


        #endregion


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            // 1. Condición de error: ¿Está vacío o tiene menos de 3 letras?
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Length < 3)
            {
                // Muestra el icono rojo y el mensaje de error al lado del TextBox
                errorProvider1.SetError(textBox1, "El texto no es válido. Debe tener al menos 3 caracteres.");

                // OPCIONAL: Esto evita que el usuario cambie de casilla hasta que lo corrija
                // e.Cancel = true; 
            }
            else
            {
                // 2. Si el texto es válido, LIMPIAMOS el error para que desaparezca el icono
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void btn_ValidarId_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(errorProvider1.GetError(textBox1)))
            {
                MessageBox.Show("Por favor, corrige los errores antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución del botón
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

        private void lb_Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
