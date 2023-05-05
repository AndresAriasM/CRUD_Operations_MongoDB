namespace ProgramaBeneficiariosMongo.Formularios
{
    partial class BorrarMunicipio
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
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtNombreMunicipio = new ListBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            txtCodigoMunicipio = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            label6 = new Label();
            NombreMuncipio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Exit_logo_svg__1_;
            pictureBox3.Location = new Point(680, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(124, 51);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Flag_map_of_Colombia1;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(103, 94);
            label2.Name = "label2";
            label2.Size = new Size(235, 32);
            label2.TabIndex = 25;
            label2.Text = "Lista de Municipios";
            label2.Click += label2_Click;
            // 
            // txtNombreMunicipio
            // 
            txtNombreMunicipio.BackColor = SystemColors.ScrollBar;
            txtNombreMunicipio.FormattingEnabled = true;
            txtNombreMunicipio.ItemHeight = 25;
            txtNombreMunicipio.Location = new Point(26, 154);
            txtNombreMunicipio.Name = "txtNombreMunicipio";
            txtNombreMunicipio.Size = new Size(382, 204);
            txtNombreMunicipio.TabIndex = 24;
            txtNombreMunicipio.SelectedIndexChanged += ListaMunicipios_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2023_04_07_214205;
            pictureBox2.Location = new Point(-1, 376);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(409, 75);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(242, 8);
            label1.Name = "label1";
            label1.Size = new Size(305, 48);
            label1.TabIndex = 22;
            label1.Text = "Borrar Municipio";
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(517, 109);
            label7.Name = "label7";
            label7.Size = new Size(169, 28);
            label7.TabIndex = 36;
            label7.Text = "ID del Municipio";
            // 
            // txtCodigoMunicipio
            // 
            txtCodigoMunicipio.Location = new Point(556, 140);
            txtCodigoMunicipio.Name = "txtCodigoMunicipio";
            txtCodigoMunicipio.ReadOnly = true;
            txtCodigoMunicipio.Size = new Size(100, 31);
            txtCodigoMunicipio.TabIndex = 35;
            txtCodigoMunicipio.TextChanged += txtValor_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(435, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 357);
            panel1.TabIndex = 34;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(530, 322);
            button2.Name = "button2";
            button2.Size = new Size(156, 67);
            button2.TabIndex = 33;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(502, 208);
            label6.Name = "label6";
            label6.Size = new Size(225, 28);
            label6.TabIndex = 32;
            label6.Text = "Nombre del Municipio";
            label6.Click += label6_Click;
            // 
            // NombreMuncipio
            // 
            NombreMuncipio.Location = new Point(511, 239);
            NombreMuncipio.Name = "NombreMuncipio";
            NombreMuncipio.ReadOnly = true;
            NombreMuncipio.Size = new Size(204, 31);
            NombreMuncipio.TabIndex = 31;
            // 
            // BorrarMunicipio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(txtCodigoMunicipio);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(NombreMuncipio);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtNombreMunicipio);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrarMunicipio";
            Text = "BorrarMunicipio";
            Load += BorrarMunicipio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label2;
        private ListBox txtNombreMunicipio;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label7;
        private TextBox txtCodigoMunicipio;
        private Panel panel1;
        private Button button2;
        private Label label6;
        private TextBox NombreMuncipio;
    }
}