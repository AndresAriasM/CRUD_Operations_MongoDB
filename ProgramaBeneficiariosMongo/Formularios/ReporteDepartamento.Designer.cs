namespace ProgramaBeneficiariosMongo.Formularios
{
    partial class ReporteDepartamento
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
            ListaMunicipios = new ListBox();
            txtValorTotal = new TextBox();
            label3 = new Label();
            label10 = new Label();
            label8 = new Label();
            label1 = new Label();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            ListaDepartamentos = new ListBox();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ListaBeneficiarios = new ListBox();
            panel1 = new Panel();
            Año = new ListBox();
            Mes = new ListBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ListaMunicipios
            // 
            ListaMunicipios.BackColor = SystemColors.ScrollBar;
            ListaMunicipios.FormattingEnabled = true;
            ListaMunicipios.ItemHeight = 25;
            ListaMunicipios.Location = new Point(12, 279);
            ListaMunicipios.Name = "ListaMunicipios";
            ListaMunicipios.Size = new Size(309, 79);
            ListaMunicipios.TabIndex = 122;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(605, 203);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(140, 31);
            txtValorTotal.TabIndex = 120;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(463, 203);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 119;
            label3.Text = "Valor Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(101, 235);
            label10.Name = "label10";
            label10.Size = new Size(141, 32);
            label10.TabIndex = 118;
            label10.Text = "Municipios";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(515, 68);
            label8.Name = "label8";
            label8.Size = new Size(161, 32);
            label8.TabIndex = 117;
            label8.Text = "Beneficiarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(407, 359);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 116;
            label1.Text = "Meses registrados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(367, 270);
            label7.Name = "label7";
            label7.Size = new Size(208, 32);
            label7.TabIndex = 114;
            label7.Text = "Años registrados";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(572, 222);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 25);
            linkLabel1.TabIndex = 112;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(74, 94);
            label5.Name = "label5";
            label5.Size = new Size(285, 32);
            label5.TabIndex = 111;
            label5.Text = "Lista de Departamentos";
            // 
            // ListaDepartamentos
            // 
            ListaDepartamentos.BackColor = SystemColors.ScrollBar;
            ListaDepartamentos.FormattingEnabled = true;
            ListaDepartamentos.ItemHeight = 25;
            ListaDepartamentos.Location = new Point(6, 129);
            ListaDepartamentos.Name = "ListaDepartamentos";
            ListaDepartamentos.Size = new Size(395, 79);
            ListaDepartamentos.TabIndex = 110;
            ListaDepartamentos.SelectedIndexChanged += ListaDepartamentos_SelectedIndexChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Captura_de_pantalla_2023_04_07_214205;
            pictureBox4.Location = new Point(-1, 376);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(402, 75);
            pictureBox4.TabIndex = 109;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(207, 2);
            label6.Name = "label6";
            label6.Size = new Size(425, 48);
            label6.TabIndex = 108;
            label6.Text = "Reporte Departamentos";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(249, -1);
            label4.Name = "label4";
            label4.Size = new Size(0, 48);
            label4.TabIndex = 107;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Flag_map_of_Colombia1;
            pictureBox3.Location = new Point(-3, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 106;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(101, 94);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 105;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Exit_logo_svg__1_;
            pictureBox1.Location = new Point(680, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 51);
            pictureBox1.TabIndex = 104;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ListaBeneficiarios
            // 
            ListaBeneficiarios.BackColor = SystemColors.ScrollBar;
            ListaBeneficiarios.FormattingEnabled = true;
            ListaBeneficiarios.ItemHeight = 25;
            ListaBeneficiarios.Location = new Point(469, 103);
            ListaBeneficiarios.Name = "ListaBeneficiarios";
            ListaBeneficiarios.Size = new Size(288, 79);
            ListaBeneficiarios.TabIndex = 124;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(407, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 166);
            panel1.TabIndex = 125;
            // 
            // Año
            // 
            Año.BackColor = SystemColors.ScrollBar;
            Año.FormattingEnabled = true;
            Año.ItemHeight = 25;
            Año.Location = new Point(605, 253);
            Año.Name = "Año";
            Año.Size = new Size(83, 79);
            Año.TabIndex = 126;
            // 
            // Mes
            // 
            Mes.BackColor = SystemColors.ScrollBar;
            Mes.FormattingEnabled = true;
            Mes.ItemHeight = 25;
            Mes.Location = new Point(634, 359);
            Mes.Name = "Mes";
            Mes.Size = new Size(83, 79);
            Mes.TabIndex = 127;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(4, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(407, 10);
            panel2.TabIndex = 126;
            // 
            // ReporteDepartamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(Mes);
            Controls.Add(Año);
            Controls.Add(panel1);
            Controls.Add(ListaBeneficiarios);
            Controls.Add(ListaMunicipios);
            Controls.Add(txtValorTotal);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(ListaDepartamentos);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReporteDepartamento";
            Text = "ReporteDepartamento";
            Load += ReporteDepartamento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox ListaMunicipios;
        private TextBox txtValorTotal;
        private Label label3;
        private Label label10;
        private Label label8;
        private Label label1;
        private Label label7;
        private LinkLabel linkLabel1;
        private Label label5;
        private ListBox ListaDepartamentos;
        private PictureBox pictureBox4;
        private Label label6;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox1;
        private ListBox ListaBeneficiarios;
        private Panel panel1;
        private ListBox Año;
        private ListBox Mes;
        private Panel panel2;
    }
}