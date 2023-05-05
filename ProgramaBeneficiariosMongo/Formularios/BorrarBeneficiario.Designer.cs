﻿namespace ProgramaBeneficiariosMongo.Formularios
{
    partial class BorrarBeneficiario
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
            label7 = new Label();
            txtCodigoBeneficiario = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            txtNombreBeneficiario = new TextBox();
            label3 = new Label();
            txtMunicipio = new TextBox();
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
            label5.Location = new Point(51, 94);
            label5.Name = "label5";
            label5.Size = new Size(346, 32);
            label5.TabIndex = 49;
            label5.Text = "Lista de Beneficiarios Activos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(225, 2);
            label6.Name = "label6";
            label6.Size = new Size(335, 48);
            label6.TabIndex = 48;
            label6.Text = "Borrar Beneficiario";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(249, -1);
            label4.Name = "label4";
            label4.Size = new Size(0, 48);
            label4.TabIndex = 47;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Flag_map_of_Colombia1;
            pictureBox3.Location = new Point(-3, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 46;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(101, 94);
            label2.Name = "label2";
            label2.Size = new Size(235, 32);
            label2.TabIndex = 45;
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
            ListaBeneficiarios.TabIndex = 44;
            ListaBeneficiarios.SelectedIndexChanged += ListaBeneficiarios_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Exit_logo_svg__1_;
            pictureBox1.Location = new Point(679, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 51);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2023_04_07_214205;
            pictureBox2.Location = new Point(-3, 376);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(428, 75);
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(518, 105);
            label7.Name = "label7";
            label7.Size = new Size(188, 28);
            label7.TabIndex = 55;
            label7.Text = "ID del Beneficiario";
            // 
            // txtCodigoBeneficiario
            // 
            txtCodigoBeneficiario.Location = new Point(559, 136);
            txtCodigoBeneficiario.Name = "txtCodigoBeneficiario";
            txtCodigoBeneficiario.ReadOnly = true;
            txtCodigoBeneficiario.Size = new Size(100, 31);
            txtCodigoBeneficiario.TabIndex = 54;
            txtCodigoBeneficiario.TextChanged += txtCodigoBeneficiario_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(431, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 357);
            panel1.TabIndex = 53;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(526, 359);
            button2.Name = "button2";
            button2.Size = new Size(156, 67);
            button2.TabIndex = 52;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(498, 178);
            label1.Name = "label1";
            label1.Size = new Size(244, 28);
            label1.TabIndex = 51;
            label1.Text = "Nombre del Beneficiario";
            // 
            // txtNombreBeneficiario
            // 
            txtNombreBeneficiario.Location = new Point(507, 209);
            txtNombreBeneficiario.Name = "txtNombreBeneficiario";
            txtNombreBeneficiario.ReadOnly = true;
            txtNombreBeneficiario.Size = new Size(204, 31);
            txtNombreBeneficiario.TabIndex = 50;
            txtNombreBeneficiario.TextChanged += txtNombreBeneficiario_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(480, 264);
            label3.Name = "label3";
            label3.Size = new Size(262, 28);
            label3.TabIndex = 57;
            label3.Text = "Municipio del Beneficiario";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(507, 295);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.ReadOnly = true;
            txtMunicipio.Size = new Size(204, 31);
            txtMunicipio.TabIndex = 56;
            // 
            // BorrarBeneficiario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtMunicipio);
            Controls.Add(label7);
            Controls.Add(txtCodigoBeneficiario);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(txtNombreBeneficiario);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(ListaBeneficiarios);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrarBeneficiario";
            Text = "BorrarBeneficiario";
            Load += BorrarBeneficiario_Load;
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
        private Label label7;
        private TextBox txtCodigoBeneficiario;
        private Panel panel1;
        private Button button2;
        private Label label1;
        private TextBox txtNombreBeneficiario;
        private Label label3;
        private TextBox txtMunicipio;
    }
}