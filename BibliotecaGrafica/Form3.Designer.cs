namespace BibliotecaGrafica
{
    partial class Form3
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
            btn_Salir = new Button();
            btn_Lectores = new Button();
            btn_Prestamo = new Button();
            btn_Especialidad = new Button();
            lb_Titulo = new Label();
            SuspendLayout();
            // 
            // btn_Salir
            // 
            btn_Salir.Anchor = AnchorStyles.None;
            btn_Salir.AutoSize = true;
            btn_Salir.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Salir.Location = new Point(345, 360);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(110, 40);
            btn_Salir.TabIndex = 11;
            btn_Salir.Text = "Regresar";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Lectores
            // 
            btn_Lectores.Anchor = AnchorStyles.None;
            btn_Lectores.AutoSize = true;
            btn_Lectores.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Lectores.Location = new Point(221, 290);
            btn_Lectores.Name = "btn_Lectores";
            btn_Lectores.Size = new Size(359, 40);
            btn_Lectores.TabIndex = 10;
            btn_Lectores.Text = "Reporte de Lectores Con Libros Pendientes";
            btn_Lectores.UseVisualStyleBackColor = true;
            btn_Lectores.Click += btn_Eliminar_Click;
            // 
            // btn_Prestamo
            // 
            btn_Prestamo.Anchor = AnchorStyles.None;
            btn_Prestamo.AutoSize = true;
            btn_Prestamo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Prestamo.Location = new Point(241, 220);
            btn_Prestamo.Name = "btn_Prestamo";
            btn_Prestamo.Size = new Size(318, 40);
            btn_Prestamo.TabIndex = 9;
            btn_Prestamo.Text = "Reporte de Prestamos sin Devolucion";
            btn_Prestamo.UseVisualStyleBackColor = true;
            btn_Prestamo.Click += btn_Modificar_Click;
            // 
            // btn_Especialidad
            // 
            btn_Especialidad.Anchor = AnchorStyles.None;
            btn_Especialidad.AutoSize = true;
            btn_Especialidad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Especialidad.Location = new Point(291, 150);
            btn_Especialidad.Name = "btn_Especialidad";
            btn_Especialidad.Size = new Size(219, 40);
            btn_Especialidad.TabIndex = 8;
            btn_Especialidad.Text = "Reporte por Especialidad";
            btn_Especialidad.UseVisualStyleBackColor = true;
            btn_Especialidad.Click += btn_Insetar_Click;
            // 
            // lb_Titulo
            // 
            lb_Titulo.Anchor = AnchorStyles.None;
            lb_Titulo.AutoSize = true;
            lb_Titulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Titulo.Location = new Point(122, 13);
            lb_Titulo.Name = "lb_Titulo";
            lb_Titulo.Size = new Size(556, 81);
            lb_Titulo.TabIndex = 7;
            lb_Titulo.Text = "Este titulo cambiara";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Lectores);
            Controls.Add(btn_Prestamo);
            Controls.Add(btn_Especialidad);
            Controls.Add(lb_Titulo);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Salir;
        private Button btn_Lectores;
        private Button btn_Prestamo;
        private Button btn_Especialidad;
        private Label lb_Titulo;
    }
}