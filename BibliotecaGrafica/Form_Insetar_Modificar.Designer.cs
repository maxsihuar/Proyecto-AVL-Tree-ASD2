namespace BibliotecaGrafica
{
    partial class Form_Insetar_Modificar
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
            lb_Titulo = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btn_ValidarId = new Button();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_Subir = new Button();
            btn_Regresar = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lb_Titulo
            // 
            lb_Titulo.Anchor = AnchorStyles.None;
            lb_Titulo.AutoSize = true;
            lb_Titulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Titulo.Location = new Point(294, 57);
            lb_Titulo.Name = "lb_Titulo";
            lb_Titulo.Size = new Size(213, 60);
            lb_Titulo.TabIndex = 0;
            lb_Titulo.Text = "INSERTAR";
            lb_Titulo.Click += lb_Titulo_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(140, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 30);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Validating += textBox1_Validating;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 146);
            label1.Name = "label1";
            label1.Size = new Size(29, 28);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // btn_ValidarId
            // 
            btn_ValidarId.Anchor = AnchorStyles.None;
            btn_ValidarId.AutoSize = true;
            btn_ValidarId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ValidarId.Location = new Point(562, 144);
            btn_ValidarId.Name = "btn_ValidarId";
            btn_ValidarId.Size = new Size(130, 35);
            btn_ValidarId.TabIndex = 3;
            btn_ValidarId.Text = "Validar";
            btn_ValidarId.UseVisualStyleBackColor = true;
            btn_ValidarId.Click += btn_ValidarId_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            // btn_Subir
            // 
            btn_Subir.Anchor = AnchorStyles.None;
            btn_Subir.AutoSize = true;
            btn_Subir.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Subir.Location = new Point(178, 402);
            btn_Subir.Name = "btn_Subir";
            btn_Subir.Size = new Size(170, 40);
            btn_Subir.TabIndex = 5;
            btn_Subir.Text = "Subir";
            btn_Subir.UseVisualStyleBackColor = true;
            // 
            // btn_Regresar
            // 
            btn_Regresar.Anchor = AnchorStyles.None;
            btn_Regresar.AutoSize = true;
            btn_Regresar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Regresar.Location = new Point(428, 402);
            btn_Regresar.Name = "btn_Regresar";
            btn_Regresar.Size = new Size(170, 40);
            btn_Regresar.TabIndex = 6;
            btn_Regresar.Text = "Regresar";
            btn_Regresar.UseVisualStyleBackColor = true;
            btn_Regresar.Click += btn_Regresar_Click;
            // 
            // Form_Insetar_Modificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Regresar);
            Controls.Add(btn_Subir);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn_ValidarId);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lb_Titulo);
            Name = "Form_Insetar_Modificar";
            Text = "Form_Insetar_Modificar";
            Load += textBox1_TextChanged;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Titulo;
        private TextBox textBox1;
        private Label label1;
        private Button btn_ValidarId;
        private ErrorProvider errorProvider1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_Subir;
        private Button btn_Regresar;
    }
}