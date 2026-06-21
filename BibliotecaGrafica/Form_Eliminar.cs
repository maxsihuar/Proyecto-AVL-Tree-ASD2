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
    public partial class Form_Eliminar : Form
    {
        private List<TextBox> texts = new List<TextBox>();
        private bool flag = true;
        private int tm_TextBox = 400;
        private int tm_Label = 100;
        private Form2 form_Anterior;

        public cArbolAVL arbolLibros { get; set; }
        public cArbolAVL arbolLectores { get; set; }
        public cArbolAVL arbolPrestamos { get; set; }

        public Controlador control = new Controlador();
        public string ObjetoSeleccionado { get; set; }
        public Form_Eliminar(string Objeto, Form2 Anterior)
        {
            ObjetoSeleccionado = Objeto;
            form_Anterior = Anterior;
            arbolLibros = Anterior.arbolLibros;
            arbolLectores = Anterior.arbolLectores;
            arbolPrestamos = Anterior.arbolPrestamos;

            InitializeComponent();
            Titulo.Text = $" {"ELIMINAR " + ObjetoSeleccionado.ToUpper()}";
            Titulo.Location = new Point((this.ClientSize.Width - Titulo.Size.Width) / 2, 40);

            texts.Add(textBox1);
            ComponentesDinamicos();
        }

        #region ********* Formulario Dinamico**********
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
                //e.Cancel = true; 
            }
            else
            {
                // 2. Si el texto es válido, LIMPIAMOS el error para que desaparezca el icono
                errorProvider1.SetError(textBox1, "");
            }
        }
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

                texts.Add(txtTitulo); texts.Add(txtAutor); texts.Add(txtAnio); texts.Add(txtEspecialidad);


            }
            if (this.ObjetoSeleccionado == "Lector")
            {
                Label lb1 = new Label();
                lb1.Text = "Apellido Paterno:";
                lb1.Width = tm_Label; lb1.Height = 30;
                lb1.AutoSize = true; lb1.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb1);

                TextBox txtAP = new TextBox();
                txtAP.Width = tm_TextBox; txtAP.Height = 30;
                tableLayoutPanel1.Controls.Add(txtAP);

                Label lb2 = new Label();
                lb2.Text = "Apellido Materno:";
                lb2.Width = tm_Label; lb2.Height = 30;
                lb2.AutoSize = true; lb2.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb2);

                TextBox txtAM = new TextBox();
                txtAM.Width = tm_TextBox; txtAM.Height = 30;
                tableLayoutPanel1.Controls.Add(txtAM);

                Label lb3 = new Label();
                lb3.Text = "Nombre:";
                lb3.Width = tm_Label; lb3.Height = 30;
                lb3.AutoSize = true; lb3.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb3);

                TextBox txtNombre = new TextBox();
                txtNombre.Width = tm_TextBox; txtNombre.Height = 30;
                tableLayoutPanel1.Controls.Add(txtNombre);

                Label lb4 = new Label();
                lb4.Text = "Condicion:";
                lb4.Width = tm_Label; lb4.Height = 30;
                lb4.AutoSize = true; lb4.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb4);

                TextBox txtCondicion = new TextBox();
                txtCondicion.Width = tm_TextBox; txtCondicion.Height = 30;
                tableLayoutPanel1.Controls.Add(txtCondicion);

                Label lb5 = new Label();
                lb5.Text = "Email:";
                lb5.Width = tm_Label; lb5.Height = 30;
                lb5.AutoSize = true; lb5.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb5);

                TextBox txtEmail = new TextBox();
                txtEmail.Width = tm_TextBox; txtEmail.Height = 30;
                tableLayoutPanel1.Controls.Add(txtEmail);

                texts.Add(txtAP); texts.Add(txtAM); texts.Add(txtNombre); texts.Add(txtCondicion); texts.Add(txtEmail);
            }
            if (this.ObjetoSeleccionado == "Prestamo")
            {
                Label lb1 = new Label();
                lb1.Text = "Id Lector:";
                lb1.Width = tm_Label; lb1.Height = 30;
                lb1.AutoSize = true; lb1.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb1);

                TextBox txtIdLector = new TextBox();
                txtIdLector.Width = tm_TextBox; txtIdLector.Height = 30;
                tableLayoutPanel1.Controls.Add(txtIdLector);

                Label lb2 = new Label();
                lb2.Text = "Id Libro:";
                lb2.Width = tm_Label; lb2.Height = 30;
                lb2.AutoSize = true; lb2.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb2);

                TextBox txtIdLibro = new TextBox();
                txtIdLibro.Width = tm_TextBox; txtIdLibro.Height = 30;
                tableLayoutPanel1.Controls.Add(txtIdLibro);

                Label lb3 = new Label();
                lb3.Text = "Fecha de Prestamos:";
                lb3.Width = tm_Label; lb3.Height = 30;
                lb3.AutoSize = true; lb3.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb3);

                TextBox txtFP = new TextBox();
                txtFP.Width = tm_TextBox; txtFP.Height = 30;
                tableLayoutPanel1.Controls.Add(txtFP);

                Label lb4 = new Label();
                lb4.Text = "Fecha de Devolucion:";
                lb4.Width = tm_Label; lb4.Height = 30;
                lb4.AutoSize = true; lb4.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                tableLayoutPanel1.Controls.Add(lb4);

                TextBox txtFD = new TextBox();
                txtFD.Width = tm_TextBox; txtFD.Height = 30;
                tableLayoutPanel1.Controls.Add(txtFD);

                texts.Add(txtIdLector); texts.Add(txtIdLibro); texts.Add(txtFP); texts.Add(txtFD);

            }
        }

        #endregion

        private void Form_Eliminar_Load(object sender, EventArgs e)
        {

        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            errorProvider1.SetError(textBox1, "");

            if (!string.IsNullOrEmpty(errorProvider1.GetError(textBox1)))
            {
                MessageBox.Show("Por favor, corrige los errores antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }

            if (ObjetoSeleccionado == "Libro")
            {
                if (control.ValidarId(arbolLibros, id) == 102)
                {
                    errorProvider1.SetError(textBox1, "El Libro no existe");
                    flag = false;
                }
                else { errorProvider1.SetError(textBox1, ""); flag = true; }
            }
            if (ObjetoSeleccionado == "Lector")
            {
                if (control.ValidarId(arbolLectores, id) == 102)
                {
                    errorProvider1.SetError(textBox1, "El Lector no existe");
                    flag |= false; ;
                }
                else { errorProvider1.SetError(textBox1, ""); flag = true; }
            }
            if (ObjetoSeleccionado == "Prestamo")
            {
                if (control.ValidarId(arbolPrestamos, id) == 102)
                {
                    errorProvider1.SetError(textBox1, "El Prestamo no existe");
                    flag = false;
                }
                else { errorProvider1.SetError(textBox1, ""); flag = true;  }
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            

            if (string.IsNullOrWhiteSpace(id))
            {
                errorProvider1.SetError(textBox1, "Ingrese un ID");
                MessageBox.Show("Por favor, ingrese un ID");
                return;
            }

            if(!flag) { return; }


            errorProvider1.SetError(textBox1, "");
            if (ObjetoSeleccionado == "Libro")
            {
                List<string> ls = control.BuscarObjeto(arbolLibros, id);
                List<string> resultado = control.EliminarObjeto(arbolLibros, id);
                for (int i = 0; i < 5; i++)
                {
                    texts[i].Enabled = false;
                    texts[i].Text = ls[i];
                }

                MessageBox.Show(resultado[0], resultado[1]);
            }
            if (ObjetoSeleccionado == "Lector")
            {
                List<string> ls = control.BuscarObjeto(arbolLectores, id);
                List<string> resultado = control.EliminarObjeto(arbolLectores, id);

                for (int i = 0; i < 6; i++)
                {
                    texts[i].Enabled = false;
                    texts[i].Text = ls[i];
                }

                MessageBox.Show(resultado[0], resultado[1]);
            }
            if (ObjetoSeleccionado == "Prestamo")
            {
                List<string> ls = control.BuscarObjeto(arbolPrestamos, id);
                List<string> resultado = control.EliminarObjeto(arbolPrestamos, id);

                for (int i = 0; i < 5; i++)
                {
                    texts[i].Enabled = false;
                    texts[i].Text = ls[i];
                }

                MessageBox.Show(resultado[0], resultado[1]);
            }
            texts[0].Enabled = true;
        }
        private void Regresar_Click(object sender, EventArgs e)
        {
            form_Anterior.StartPosition = FormStartPosition.Manual;
            form_Anterior.Location = this.Location;
            form_Anterior.Size = this.Size;
            form_Anterior.Show();
            this.Hide();
        }

        
    }
}
