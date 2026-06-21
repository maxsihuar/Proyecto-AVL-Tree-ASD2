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
            Titulo = new Label();
            Id = new Label();
            textBox1 = new TextBox();
            Verificar = new Button();
            Eliminar = new Button();
            Regresar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.None;
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(294, 57);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(213, 60);
            Titulo.TabIndex = 0;
            Titulo.Text = "INSERTAR";
            // 
            // Id
            // 
            Id.Anchor = AnchorStyles.None;
            Id.AutoSize = true;
            Id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Id.Location = new Point(100, 146);
            Id.Name = "Id";
            Id.Size = new Size(29, 28);
            Id.TabIndex = 2;
            Id.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(140, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 30);
            textBox1.TabIndex = 1;
            // 
            // Verificar
            // 
            Verificar.Anchor = AnchorStyles.None;
            Verificar.AutoSize = true;
            Verificar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Verificar.Location = new Point(562, 144);
            Verificar.Name = "Verificar";
            Verificar.Size = new Size(130, 35);
            Verificar.TabIndex = 3;
            Verificar.Text = "Validar";
            Verificar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            Eliminar.Anchor = AnchorStyles.None;
            Eliminar.AutoSize = true;
            Eliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Eliminar.Location = new Point(178, 402);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(170, 40);
            Eliminar.TabIndex = 5;
            Eliminar.Text = "Subir";
            Eliminar.UseVisualStyleBackColor = true;
            // 
            // Regresar
            // 
            Regresar.Anchor = AnchorStyles.None;
            Regresar.AutoSize = true;
            Regresar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Regresar.Location = new Point(428, 402);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(170, 40);
            Regresar.TabIndex = 6;
            Regresar.Text = "Regresar";
            Regresar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 466F));
            tableLayoutPanel1.Location = new Point(46, 207);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(709, 182);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // Form_Eliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Regresar);
            Controls.Add(Eliminar);
            Controls.Add(Verificar);
            Controls.Add(textBox1);
            Controls.Add(Id);
            Controls.Add(Titulo);
            Name = "Form_Eliminar";
            Text = "Form_Eliminar";
            Load += Form_Eliminar_Load;
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
    }
}