namespace ProgramaBeneficiariosMongo
{
    partial class NuevoMunicipio
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
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ListaMunicipios = new ListBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            ListaDepartamentos = new ListBox();
            label3 = new Label();
            txtNombre_Municipio = new TextBox();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 48);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Municipio";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2023_04_07_214205;
            pictureBox2.Location = new Point(-2, 377);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(408, 75);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Exit_logo_svg__1_;
            pictureBox1.Location = new Point(680, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 51);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ListaMunicipios
            // 
            ListaMunicipios.BackColor = SystemColors.ScrollBar;
            ListaMunicipios.FormattingEnabled = true;
            ListaMunicipios.ItemHeight = 25;
            ListaMunicipios.Location = new Point(38, 130);
            ListaMunicipios.Name = "ListaMunicipios";
            ListaMunicipios.Size = new Size(368, 229);
            ListaMunicipios.TabIndex = 4;
            ListaMunicipios.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(102, 95);
            label2.Name = "label2";
            label2.Size = new Size(235, 32);
            label2.TabIndex = 5;
            label2.Text = "Lista de Municipios";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Flag_map_of_Colombia1;
            pictureBox3.Location = new Point(-2, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(543, 258);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 25);
            linkLabel1.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(426, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 357);
            panel1.TabIndex = 17;
            // 
            // ListaDepartamentos
            // 
            ListaDepartamentos.BackColor = SystemColors.ScrollBar;
            ListaDepartamentos.FormattingEnabled = true;
            ListaDepartamentos.ItemHeight = 25;
            ListaDepartamentos.Location = new Point(460, 130);
            ListaDepartamentos.Name = "ListaDepartamentos";
            ListaDepartamentos.Size = new Size(297, 179);
            ListaDepartamentos.TabIndex = 18;
            ListaDepartamentos.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(442, 95);
            label3.Name = "label3";
            label3.Size = new Size(344, 32);
            label3.TabIndex = 19;
            label3.Text = "Seleccione un Departamento";
            // 
            // txtNombre_Municipio
            // 
            txtNombre_Municipio.Location = new Point(460, 377);
            txtNombre_Municipio.Name = "txtNombre_Municipio";
            txtNombre_Municipio.Size = new Size(150, 31);
            txtNombre_Municipio.TabIndex = 20;
            txtNombre_Municipio.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(459, 353);
            label4.Name = "label4";
            label4.Size = new Size(155, 21);
            label4.TabIndex = 21;
            label4.Text = "Nombre Municipio";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(655, 374);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 23;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NuevoMunicipio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(txtNombre_Municipio);
            Controls.Add(label3);
            Controls.Add(ListaDepartamentos);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(ListaMunicipios);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoMunicipio";
            Text = "NuevoMunicipio";
            Load += NuevoMunicipio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ListBox ListaMunicipios;
        private Label label2;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private ListBox ListaDepartamentos;
        private Label label3;
        private TextBox txtNombre_Municipio;
        private Label label4;
        private Button button2;
    }
}