using System.Windows.Forms;

namespace BibliotecaGrafica
{
    partial class Form_Eliminar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Titulo = new Label();
            Id = new Label();
            textBox1 = new TextBox();
            Verificar = new Button();
            errorProvider1 = new ErrorProvider(components);
            Eliminar = new Button();
            Regresar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.None;
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(284, 28);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(219, 60);
            Titulo.TabIndex = 0;
            Titulo.Text = "ELIMINAR";
            // 
            // Id
            // 
            Id.Anchor = AnchorStyles.None;
            Id.AutoSize = true;
            Id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Id.Location = new Point(63, 147);
            Id.Name = "Id";
            Id.Size = new Size(29, 28);
            Id.TabIndex = 2;
            Id.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(108, 144);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(457, 30);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Validating += textBox1_Validating;
            // 
            // Verificar
            // 
            Verificar.Anchor = AnchorStyles.None;
            Verificar.AutoSize = true;
            Verificar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Verificar.Location = new Point(589, 139);
            Verificar.Margin = new Padding(3, 4, 3, 4);
            Verificar.Name = "Verificar";
            Verificar.Size = new Size(149, 47);
            Verificar.TabIndex = 3;
            Verificar.Text = "Validar";
            Verificar.UseVisualStyleBackColor = true;
            Verificar.Click += Verificar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Eliminar
            // 
            Eliminar.Anchor = AnchorStyles.None;
            Eliminar.AutoSize = true;
            Eliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Eliminar.Location = new Point(152, 442);
            Eliminar.Margin = new Padding(3, 4, 3, 4);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(194, 53);
            Eliminar.TabIndex = 5;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // Regresar
            // 
            Regresar.Anchor = AnchorStyles.None;
            Regresar.AutoSize = true;
            Regresar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Regresar.Location = new Point(426, 442);
            Regresar.Margin = new Padding(3, 4, 3, 4);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(194, 53);
            Regresar.TabIndex = 6;
            Regresar.Text = "Regresar";
            Regresar.UseVisualStyleBackColor = true;
            Regresar.Click += Regresar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 533F));
            tableLayoutPanel1.Location = new Point(63, 194);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(675, 240);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // Form_Eliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 507);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Regresar);
            Controls.Add(Eliminar);
            Controls.Add(Verificar);
            Controls.Add(textBox1);
            Controls.Add(Id);
            Controls.Add(Titulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Eliminar";
            Text = "Form_Eliminar";
            Load += textBox1_TextChanged;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Label Id;
        private TextBox textBox1;
        private Button Verificar;
        private Button Eliminar;
        private Button Regresar;
        private TableLayoutPanel tableLayoutPanel1;
        private ErrorProvider errorProvider1;
    }
}