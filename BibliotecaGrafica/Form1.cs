namespace BibliotecaGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_Libro_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("MENU DE LIBROS", "Libro", this);
            form2.FormClosed += (s, args) => Application.Exit();

            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Size = this.Size;

            form2.Show();
            this.Hide();
        }

        private void btn_Lector_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("MENU DE LECTORES", "Lector", this);
            form2.ObjetoSeleccionado = "Lector";
            form2.FormClosed += (s, args) => Application.Exit();

            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Size = this.Size;

            form2.Show();
            this.Hide();
        }

        private void btn_Prestamo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("MENU DE PRESTAMOS", "Prestamo", this);
            form2.ObjetoSeleccionado = "Prestamo";
            form2.FormClosed += (s, args) => Application.Exit();

            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Size = this.Size;

            form2.Show();
            this.Hide();
        }
    }
}
