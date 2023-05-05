namespace ProgramaBeneficiariosMongo
{
    partial class NuevoPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPrograma));
            label2 = new Label();
            ListaProgramas = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            label6 = new Label();
            txtNombrePrograma = new TextBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            txtValor = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(101, 94);
            label2.Name = "label2";
            label2.Size = new Size(235, 32);
            label2.TabIndex = 10;
            label2.Text = "Lista de Municipios";
            // 
            // ListaProgramas
            // 
            ListaProgramas.BackColor = SystemColors.ScrollBar;
            ListaProgramas.FormattingEnabled = true;
            ListaProgramas.ItemHeight = 25;
            ListaProgramas.Location = new Point(37, 129);
            ListaProgramas.Name = "ListaProgramas";
            ListaProgramas.Size = new Size(368, 229);
            ListaProgramas.TabIndex = 9;
            ListaProgramas.SelectedIndexChanged += ListaProgramas_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Exit_logo_svg__1_;
            pictureBox1.Location = new Point(679, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 51);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2023_04_07_214205;
            pictureBox2.Location = new Point(-3, 376);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(428, 75);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 8);
            label1.Name = "label1";
            label1.Size = new Size(310, 48);
            label1.TabIndex = 6;
            label1.Text = "Nuevo Municipio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(155, 35);
            label3.Name = "label3";
            label3.Size = new Size(310, 48);
            label3.TabIndex = 11;
            label3.Text = "Nuevo Municipio";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(219, 2);
            label4.Name = "label4";
            label4.Size = new Size(306, 48);
            label4.TabIndex = 12;
            label4.Text = "Nuevo Programa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(108, 94);
            label5.Name = "label5";
            label5.Size = new Size(232, 32);
            label5.TabIndex = 13;
            label5.Text = "Lista de Programas";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Flag_map_of_Colombia1;
            pictureBox3.Location = new Point(-3, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(566, 376);
            button2.Name = "button2";
            button2.Size = new Size(156, 67);
            button2.TabIndex = 26;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(482, 308);
            label6.Name = "label6";
            label6.Size = new Size(172, 28);
            label6.TabIndex = 25;
            label6.Text = "Nuevo Programa";
            // 
            // txtNombrePrograma
            // 
            txtNombrePrograma.Location = new Point(487, 339);
            txtNombrePrograma.Name = "txtNombrePrograma";
            txtNombrePrograma.Size = new Size(164, 31);
            txtNombrePrograma.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(462, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 357);
            panel1.TabIndex = 27;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(487, 69);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(301, 215);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(679, 338);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 31);
            txtValor.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(696, 308);
            label7.Name = "label7";
            label7.Size = new Size(60, 28);
            label7.TabIndex = 30;
            label7.Text = "Valor";
            // 
            // NuevoPrograma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(txtValor);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(txtNombrePrograma);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ListaProgramas);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoPrograma";
            Text = "NuevoPrograma";
            Load += NuevoPrograma_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox ListaProgramas;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox3;
        private Button button2;
        private Label label6;
        private TextBox txtNombrePrograma;
        private Panel panel1;
        private PictureBox pictureBox4;
        private TextBox txtValor;
        private Label label7;
    }
}