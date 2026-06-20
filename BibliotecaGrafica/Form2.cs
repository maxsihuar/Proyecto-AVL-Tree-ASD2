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
        public string Titulo { get; set; }
        public Form2(string Titulo)
        {
            InitializeComponent();
            lb_Titulo.Text = Titulo;
            lb_Titulo.Location = new Point((this.ClientSize.Width - lb_Titulo.Size.Width) / 2, 40);
        }

        private void lb_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insetar_Click(object sender, EventArgs e)
        {
            Form_Insetar_Modificar formInsetarModificar = new Form_Insetar_Modificar();
            formInsetarModificar.FormClosed += (s, args) => Application.Exit();

            formInsetarModificar.StartPosition = FormStartPosition.Manual;
            formInsetarModificar.Location = this.Location;
            formInsetarModificar.Size = this.Size;

            formInsetarModificar.Show();
            this.Hide();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => Application.Exit();

            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            form1.Size = this.Size;

            form1.Show();
            this.Hide();
        }
    }
}
