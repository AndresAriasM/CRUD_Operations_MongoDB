namespace ProgramaBeneficiariosMongo.Formularios
{
    partial class ActualizaMunicipio
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
            ListaDepartamentos = new ListBox();
            label4 = new Label();
            label7 = new Label();
            txtCodigoMunicipio = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            label6 = new Label();
            txtNombreMunicipio = new TextBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            ListaMunicipios = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ListaDepartamentos
            // 
            ListaDepartamentos.BackColor = SystemColors.ScrollBar;
            ListaDepartamentos.FormattingEnabled = true;
            ListaDepartamentos.ItemHeight = 25;
            ListaDepartamentos.Location = new Point(501, 222);
            ListaDepartamentos.Name = "ListaDepartamentos";
            ListaDepartamentos.Size = new Size(242, 104);
            ListaDepartamentos.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(550, 186);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 60;
            label4.Text = "Departamento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(513, 109);
            label7.Name = "label7";
            label7.Size = new Size(169, 28);
            label7.TabIndex = 59;
            label7.Text = "ID del Municipio";
            // 
            // txtCodigoMunicipio
            // 
            txtCodigoMunicipio.Location = new Point(552, 140);
            txtCodigoMunicipio.Name = "txtCodigoMunicipio";
            txtCodigoMunicipio.ReadOnly = true;
            txtCodigoMunicipio.Size = new Size(100, 31);
            txtCodigoMunicipio.TabIndex = 58;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(431, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 357);
            panel1.TabIndex = 57;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(677, 360);
            button2.Name = "button2";
            button2.Size = new Size(117, 44);
            button2.TabIndex = 56;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(467, 342);
            label6.Name = "label6";
            label6.Size = new Size(190, 28);
            label6.TabIndex = 55;
            label6.Text = "Nombre Municipio";
            // 
            // txtNombreMunicipio
            // 
            txtNombreMunicipio.Location = new Point(461, 370);
            txtNombreMunicipio.Name = "txtNombreMunicipio";
            txtNombreMunicipio.Size = new Size(204, 31);
            txtNombreMunicipio.TabIndex = 54;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Flag_map_of_Colombia1;
            pictureBox3.Location = new Point(-3, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 94);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 52;
            label2.Text = "Municipios Existentes";
            // 
            // ListaMunicipios
            // 
            ListaMunicipios.BackColor = SystemColors.ScrollBar;
            ListaMunicipios.FormattingEnabled = true;
            ListaMunicipios.ItemHeight = 25;
            ListaMunicipios.Location = new Point(37, 129);
            ListaMunicipios.Name = "ListaMunicipios";
            ListaMunicipios.Size = new Size(368, 229);
            ListaMunicipios.TabIndex = 51;
            ListaMunicipios.SelectedIndexChanged += ListaMunicipios_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Exit_logo_svg__1_;
            pictureBox1.Location = new Point(679, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 51);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2023_04_07_214205;
            pictureBox2.Location = new Point(-3, 376);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(428, 75);
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(240, 8);
            label1.Name = "label1";
            label1.Size = new Size(352, 48);
            label1.TabIndex = 48;
            label1.Text = "Actualiza Municipio";
            // 
            // ActualizaMunicipio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ListaDepartamentos);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtCodigoMunicipio);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(txtNombreMunicipio);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(ListaMunicipios);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActualizaMunicipio";
            Text = "ActualizaMunicipio";
            Load += ActualizaMunicipio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListaDepartamentos;
        private Label label4;
        private Label label7;
        private TextBox txtCodigoMunicipio;
        private Panel panel1;
        private Button button2;
        private Label label6;
        private TextBox txtNombreMunicipio;
        private PictureBox pictureBox3;
        private Label label2;
        private ListBox ListaMunicipios;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}