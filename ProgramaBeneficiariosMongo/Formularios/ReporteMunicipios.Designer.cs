namespace ProgramaBeneficiariosMongo.Formularios
{
    partial class ReporteMunicipios
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
            txtValorTotal = new TextBox();
            label3 = new Label();
            label10 = new Label();
            label8 = new Label();
            label1 = new Label();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            ListaMunicipios = new ListBox();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtNumBeneficiarios = new TextBox();
            ListaProgramas = new ListBox();
            button2 = new Button();
            Año = new ListBox();
            Mes = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(618, 272);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(140, 31);
            txtValorTotal.TabIndex = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(622, 238);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 99;
            label3.Text = "Valor Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(555, 71);
            label10.Name = "label10";
            label10.Size = new Size(127, 32);
            label10.TabIndex = 96;
            label10.Text = "Programa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(426, 237);
            label8.Name = "label8";
            label8.Size = new Size(161, 32);
            label8.TabIndex = 95;
            label8.Text = "Beneficiarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(600, 326);
            label1.Name = "label1";
            label1.Size = new Size(188, 28);
            label1.TabIndex = 94;
            label1.Text = "Meses Registrados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(415, 326);
            label7.Name = "label7";
            label7.Size = new Size(176, 28);
            label7.TabIndex = 92;
            label7.Text = "Años Registrados";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(554, 244);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 25);
            linkLabel1.TabIndex = 88;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(74, 94);
            label5.Name = "label5";
            label5.Size = new Size(235, 32);
            label5.TabIndex = 87;
            label5.Text = "Lista de Municipios";
            // 
            // ListaMunicipios
            // 
            ListaMunicipios.BackColor = SystemColors.ScrollBar;
            ListaMunicipios.FormattingEnabled = true;
            ListaMunicipios.ItemHeight = 25;
            ListaMunicipios.Location = new Point(6, 129);
            ListaMunicipios.Name = "ListaMunicipios";
            ListaMunicipios.Size = new Size(395, 229);
            ListaMunicipios.TabIndex = 86;
            ListaMunicipios.SelectedIndexChanged += ListaSubsidios_SelectedIndexChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Captura_de_pantalla_2023_04_07_214205;
            pictureBox4.Location = new Point(-1, 376);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(402, 75);
            pictureBox4.TabIndex = 85;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(225, 2);
            label6.Name = "label6";
            label6.Size = new Size(349, 48);
            label6.TabIndex = 84;
            label6.Text = "Reporte Municipios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(249, -1);
            label4.Name = "label4";
            label4.Size = new Size(0, 48);
            label4.TabIndex = 83;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Flag_map_of_Colombia1;
            pictureBox3.Location = new Point(-3, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 82;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(101, 94);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 81;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Exit_logo_svg__1_;
            pictureBox1.Location = new Point(679, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 51);
            pictureBox1.TabIndex = 80;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtNumBeneficiarios
            // 
            txtNumBeneficiarios.Location = new Point(436, 272);
            txtNumBeneficiarios.Name = "txtNumBeneficiarios";
            txtNumBeneficiarios.ReadOnly = true;
            txtNumBeneficiarios.Size = new Size(140, 31);
            txtNumBeneficiarios.TabIndex = 101;
            txtNumBeneficiarios.TextChanged += textBox1_TextChanged;
            // 
            // ListaProgramas
            // 
            ListaProgramas.BackColor = SystemColors.ScrollBar;
            ListaProgramas.FormattingEnabled = true;
            ListaProgramas.ItemHeight = 25;
            ListaProgramas.Location = new Point(466, 119);
            ListaProgramas.Name = "ListaProgramas";
            ListaProgramas.Size = new Size(309, 104);
            ListaProgramas.TabIndex = 102;
            ListaProgramas.SelectedIndexChanged += ListaProgramas_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(352, 71);
            button2.Name = "button2";
            button2.Size = new Size(102, 44);
            button2.TabIndex = 103;
            button2.Text = "Cargar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Año
            // 
            Año.BackColor = SystemColors.ScrollBar;
            Año.FormattingEnabled = true;
            Año.ItemHeight = 25;
            Año.Location = new Point(427, 367);
            Año.Name = "Año";
            Año.Size = new Size(157, 54);
            Año.TabIndex = 104;
            // 
            // Mes
            // 
            Mes.BackColor = SystemColors.ScrollBar;
            Mes.FormattingEnabled = true;
            Mes.ItemHeight = 25;
            Mes.Location = new Point(618, 367);
            Mes.Name = "Mes";
            Mes.Size = new Size(157, 54);
            Mes.TabIndex = 105;
            // 
            // ReporteMunicipios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Mes);
            Controls.Add(Año);
            Controls.Add(button2);
            Controls.Add(ListaProgramas);
            Controls.Add(txtNumBeneficiarios);
            Controls.Add(txtValorTotal);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(ListaMunicipios);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReporteMunicipios";
            Text = "ReporteMunicipios";
            Load += ReporteMunicipios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorTotal;
        private Label label3;
        private Label label10;
        private Label label8;
        private Label label1;
        private Label label7;
        private LinkLabel linkLabel1;
        private Label label5;
        private ListBox ListaMunicipios;
        private PictureBox pictureBox4;
        private Label label6;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtNumBeneficiarios;
        private ListBox ListaProgramas;
        private Button button2;
        private ListBox Año;
        private ListBox Mes;
    }
}