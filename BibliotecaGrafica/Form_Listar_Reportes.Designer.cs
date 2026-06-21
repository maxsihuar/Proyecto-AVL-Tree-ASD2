namespace BibliotecaGrafica
{
    partial class Form_Listar_Reportes
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
            dataGridView1 = new DataGridView();
            btn_Regresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lb_Titulo
            // 
            lb_Titulo.AutoSize = true;
            lb_Titulo.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Titulo.Location = new Point(324, 50);
            lb_Titulo.Name = "lb_Titulo";
            lb_Titulo.Size = new Size(136, 62);
            lb_Titulo.TabIndex = 0;
            lb_Titulo.Text = "Listar";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(770, 240);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_Regresar
            // 
            btn_Regresar.Anchor = AnchorStyles.None;
            btn_Regresar.AutoSize = true;
            btn_Regresar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Regresar.Location = new Point(319, 409);
            btn_Regresar.Name = "btn_Regresar";
            btn_Regresar.Size = new Size(170, 40);
            btn_Regresar.TabIndex = 9;
            btn_Regresar.Text = "Regresar";
            btn_Regresar.UseVisualStyleBackColor = true;
            btn_Regresar.Click += btn_Regresar_Click;
            // 
            // Form_Listar_Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 471);
            Controls.Add(btn_Regresar);
            Controls.Add(dataGridView1);
            Controls.Add(lb_Titulo);
            Name = "Form_Listar_Reportes";
            Text = "Form_Listar_Reportes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Titulo;
        private DataGridView dataGridView1;
        private Button btn_Regresar;
    }
}