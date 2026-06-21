namespace BibliotecaGrafica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_Libro = new Button();
            btn_Prestamo = new Button();
            btn_Lector = new Button();
            btn_Reportes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(160, 51);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(542, 62);
            label1.TabIndex = 0;
            label1.Text = "GESTION DE BIBLIOTECA";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_Libro
            // 
            btn_Libro.Anchor = AnchorStyles.None;
            btn_Libro.AutoSize = true;
            btn_Libro.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Libro.Location = new Point(376, 170);
            btn_Libro.Name = "btn_Libro";
            btn_Libro.Size = new Size(110, 40);
            btn_Libro.TabIndex = 1;
            btn_Libro.Text = "Libros";
            btn_Libro.UseVisualStyleBackColor = true;
            btn_Libro.Click += btn_Libro_Click;
            // 
            // btn_Prestamo
            // 
            btn_Prestamo.Anchor = AnchorStyles.None;
            btn_Prestamo.AutoSize = true;
            btn_Prestamo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Prestamo.Location = new Point(376, 310);
            btn_Prestamo.Name = "btn_Prestamo";
            btn_Prestamo.Size = new Size(110, 40);
            btn_Prestamo.TabIndex = 2;
            btn_Prestamo.Text = "Prestamo";
            btn_Prestamo.UseVisualStyleBackColor = true;
            btn_Prestamo.Click += btn_Prestamo_Click;
            // 
            // btn_Lector
            // 
            btn_Lector.Anchor = AnchorStyles.None;
            btn_Lector.AutoSize = true;
            btn_Lector.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Lector.Location = new Point(376, 240);
            btn_Lector.Name = "btn_Lector";
            btn_Lector.Size = new Size(110, 40);
            btn_Lector.TabIndex = 3;
            btn_Lector.Text = "Lector";
            btn_Lector.UseVisualStyleBackColor = true;
            btn_Lector.Click += btn_Lector_Click;
            // 
            // btn_Reportes
            // 
            btn_Reportes.Anchor = AnchorStyles.None;
            btn_Reportes.AutoSize = true;
            btn_Reportes.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Reportes.Location = new Point(376, 380);
            btn_Reportes.Name = "btn_Reportes";
            btn_Reportes.Size = new Size(110, 40);
            btn_Reportes.TabIndex = 4;
            btn_Reportes.Text = "Reportes";
            btn_Reportes.UseVisualStyleBackColor = true;
            btn_Reportes.Click += btn_Reportes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 504);
            Controls.Add(btn_Reportes);
            Controls.Add(btn_Lector);
            Controls.Add(btn_Prestamo);
            Controls.Add(btn_Libro);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Menu Principal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Libro;
        private Button btn_Prestamo;
        private Button btn_Lector;
        private Button btn_Reportes;
    }
}
