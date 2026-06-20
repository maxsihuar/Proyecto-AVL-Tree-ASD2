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
        public Form_Insetar_Modificar()
        {
            InitializeComponent();
        }


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
    }
}
