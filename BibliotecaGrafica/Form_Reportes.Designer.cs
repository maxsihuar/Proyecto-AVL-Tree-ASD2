namespace BibliotecaGrafica
{
    partial class Form_Reportes
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
            btn_Regresar = new Button();
            dataGridView1 = new DataGridView();
            lb_Titulo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Regresar
            // 
            btn_Regresar.Anchor = AnchorStyles.None;
            btn_Regresar.AutoSize = true;
            btn_Regresar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Regresar.Location = new Point(315, 385);
            btn_Regresar.Name = "btn_Regresar";
            btn_Regresar.Size = new Size(170, 40);
            btn_Regresar.TabIndex = 12;
            btn_Regresar.Text = "Regresar";
            btn_Regresar.UseVisualStyleBackColor = true;
            btn_Regresar.Click += btn_Regresar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(770, 240);
            dataGridView1.TabIndex = 11;
            // 
            // lb_Titulo
            // 
            lb_Titulo.Anchor = AnchorStyles.None;
            lb_Titulo.AutoSize = true;
            lb_Titulo.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Titulo.Location = new Point(320, 26);
            lb_Titulo.Name = "lb_Titulo";
            lb_Titulo.Size = new Size(136, 62);
            lb_Titulo.TabIndex = 10;
            lb_Titulo.Text = "Listar";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 533F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            tableLayoutPanel1.Location = new Point(15, 91);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(770, 36);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // Form_Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn_Regresar);
            Controls.Add(dataGridView1);
            Controls.Add(lb_Titulo);
            Name = "Form_Reportes";
            Text = "Form_Reportes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Regresar;
        private DataGridView dataGridView1;
        private Label lb_Titulo;
        private TableLayoutPanel tableLayoutPanel1;
    }
}