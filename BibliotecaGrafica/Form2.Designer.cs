namespace BibliotecaGrafica
{
    partial class Form2
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
            lb_Titulo = new Label();
            btn_Insetar = new Button();
            btn_Modificar = new Button();
            btn_Eliminar = new Button();
            btn_Buscar = new Button();
            btn_Listar = new Button();
            btn_Salir = new Button();
            SuspendLayout();
            // 
            // lb_Titulo
            // 
            lb_Titulo.Anchor = AnchorStyles.None;
            lb_Titulo.AutoSize = true;
            lb_Titulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Titulo.Location = new Point(134, 56);
            lb_Titulo.Name = "lb_Titulo";
            lb_Titulo.Size = new Size(442, 65);
            lb_Titulo.TabIndex = 0;
            lb_Titulo.Text = "Este titulo cambiara";
            lb_Titulo.Click += lb_Titulo_Click;
            // 
            // btn_Insetar
            // 
            btn_Insetar.Anchor = AnchorStyles.None;
            btn_Insetar.AutoSize = true;
            btn_Insetar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Insetar.Location = new Point(329, 120);
            btn_Insetar.Margin = new Padding(3, 2, 3, 2);
            btn_Insetar.Name = "btn_Insetar";
            btn_Insetar.Size = new Size(96, 30);
            btn_Insetar.TabIndex = 1;
            btn_Insetar.Text = "Insertar";
            btn_Insetar.UseVisualStyleBackColor = true;
            btn_Insetar.Click += btn_Insetar_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Anchor = AnchorStyles.None;
            btn_Modificar.AutoSize = true;
            btn_Modificar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Modificar.Location = new Point(329, 165);
            btn_Modificar.Margin = new Padding(3, 2, 3, 2);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(96, 30);
            btn_Modificar.TabIndex = 2;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Anchor = AnchorStyles.None;
            btn_Eliminar.AutoSize = true;
            btn_Eliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Eliminar.Location = new Point(329, 210);
            btn_Eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(96, 30);
            btn_Eliminar.TabIndex = 3;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Anchor = AnchorStyles.None;
            btn_Buscar.AutoSize = true;
            btn_Buscar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Buscar.Location = new Point(329, 255);
            btn_Buscar.Margin = new Padding(3, 2, 3, 2);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(96, 30);
            btn_Buscar.TabIndex = 4;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // btn_Listar
            // 
            btn_Listar.Anchor = AnchorStyles.None;
            btn_Listar.AutoSize = true;
            btn_Listar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Listar.Location = new Point(329, 300);
            btn_Listar.Margin = new Padding(3, 2, 3, 2);
            btn_Listar.Name = "btn_Listar";
            btn_Listar.Size = new Size(96, 30);
            btn_Listar.TabIndex = 5;
            btn_Listar.Text = "Listar";
            btn_Listar.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            btn_Salir.Anchor = AnchorStyles.None;
            btn_Salir.AutoSize = true;
            btn_Salir.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Salir.Location = new Point(329, 345);
            btn_Salir.Margin = new Padding(3, 2, 3, 2);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(96, 30);
            btn_Salir.TabIndex = 6;
            btn_Salir.Text = "Regresar";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 378);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Listar);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Modificar);
            Controls.Add(btn_Insetar);
            Controls.Add(lb_Titulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Titulo;
        private Button btn_Insetar;
        private Button btn_Modificar;
        private Button btn_Eliminar;
        private Button btn_Buscar;
        private Button btn_Listar;
        private Button btn_Salir;
    }
}