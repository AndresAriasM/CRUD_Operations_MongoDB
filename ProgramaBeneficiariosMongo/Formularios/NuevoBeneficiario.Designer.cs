namespace ProgramaBeneficiariosMongo.Formularios
{
    partial class NuevoBeneficiario
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
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            ListaBeneficiarios = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            txtNombre_Beneficiario = new TextBox();
            label3 = new Label();
            ListaMunicipios = new ListBox();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(104, 94);
            label5.Name = "label5";
            label5.Size = new Size(255, 32);
            label5.TabIndex = 33;
            label5.Text = "Lista de Beneficiarios";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(225, 2);
            label6.Name = "label6";
            label6.Size = new Size(340, 48);
            label6.TabIndex = 32;
            label6.Text = "Nuevo Beneficiario";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(249, -1);
            label4.Name = "label4";
            label4.Size = new Size(0, 48);
            label4.TabIndex = 31;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Flag_map_of_Colombia1;
            pictureBox3.Location = new Point(-3, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(101, 94);
            label2.Name = "label2";
            label2.Size = new Size(235, 32);
            label2.TabIndex = 29;
            label2.Text = "Lista de Municipios";
            // 
            // ListaBeneficiarios
            // 
            ListaBeneficiarios.BackColor = SystemColors.ScrollBar;
            ListaBeneficiarios.FormattingEnabled = true;
            ListaBeneficiarios.ItemHeight = 25;
            ListaBeneficiarios.Location = new Point(37, 129);
            ListaBeneficiarios.Name = "ListaBeneficiarios";
            ListaBeneficiarios.Size = new Size(368, 229);
            ListaBeneficiarios.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Exit_logo_svg__1_;
            pictureBox1.Location = new Point(679, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 51);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2023_04_07_214205;
            pictureBox2.Location = new Point(-3, 376);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(428, 75);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(548, 393);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 40;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(525, 321);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 39;
            label1.Text = "Nombre Beneficiario";
            label1.Click += label1_Click;
            // 
            // txtNombre_Beneficiario
            // 
            txtNombre_Beneficiario.Location = new Point(464, 345);
            txtNombre_Beneficiario.Name = "txtNombre_Beneficiario";
            txtNombre_Beneficiario.Size = new Size(297, 31);
            txtNombre_Beneficiario.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(468, 92);
            label3.Name = "label3";
            label3.Size = new Size(294, 32);
            label3.TabIndex = 37;
            label3.Text = "Seleccione un Municipio";
            // 
            // ListaMunicipios
            // 
            ListaMunicipios.BackColor = SystemColors.ScrollBar;
            ListaMunicipios.FormattingEnabled = true;
            ListaMunicipios.ItemHeight = 25;
            ListaMunicipios.Location = new Point(464, 129);
            ListaMunicipios.Name = "ListaMunicipios";
            ListaMunicipios.Size = new Size(297, 179);
            ListaMunicipios.TabIndex = 36;
            ListaMunicipios.SelectedIndexChanged += ListaMunicipios_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(431, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 357);
            panel1.TabIndex = 35;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(548, 258);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 25);
            linkLabel1.TabIndex = 34;
            // 
            // NuevoBeneficiario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(txtNombre_Beneficiario);
            Controls.Add(label3);
            Controls.Add(ListaMunicipios);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(ListaBeneficiarios);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoBeneficiario";
            Text = "NuevoBeneficiario";
            Load += NuevoBeneficiario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label2;
        private ListBox ListaBeneficiarios;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private Label label1;
        private TextBox txtNombre_Beneficiario;
        private Label label3;
        private ListBox ListaMunicipios;
        private Panel panel1;
        private LinkLabel linkLabel1;
    }
}