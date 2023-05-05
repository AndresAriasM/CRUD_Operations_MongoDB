namespace ProgramaMongo.Formularios
{
    partial class BorrarDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarDepartamento));
            label5 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            txtNombreMunicipio = new TextBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            ListaMunicipios = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(327, 87);
            label5.Name = "label5";
            label5.Size = new Size(191, 21);
            label5.TabIndex = 40;
            label5.Text = "Código Departamento";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(317, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 39;
            // 
            // button2
            // 
            button2.Location = new Point(372, 223);
            button2.Name = "button2";
            button2.Size = new Size(96, 54);
            button2.TabIndex = 36;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(323, 154);
            label3.Name = "label3";
            label3.Size = new Size(201, 21);
            label3.TabIndex = 35;
            label3.Text = "Nombre Departamento";
            // 
            // txtNombreMunicipio
            // 
            txtNombreMunicipio.Enabled = false;
            txtNombreMunicipio.Location = new Point(350, 178);
            txtNombreMunicipio.Name = "txtNombreMunicipio";
            txtNombreMunicipio.Size = new Size(142, 23);
            txtNombreMunicipio.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 87);
            label2.Name = "label2";
            label2.Size = new Size(217, 21);
            label2.TabIndex = 33;
            label2.Text = "Departamentos Existentes";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(282, 61);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(10, 249);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 265);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(269, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // ListaMunicipios
            // 
            ListaMunicipios.BackColor = SystemColors.ScrollBar;
            ListaMunicipios.FormattingEnabled = true;
            ListaMunicipios.ItemHeight = 15;
            ListaMunicipios.Location = new Point(50, 111);
            ListaMunicipios.Name = "ListaMunicipios";
            ListaMunicipios.Size = new Size(196, 139);
            ListaMunicipios.TabIndex = 30;
            ListaMunicipios.SelectedIndexChanged += ListaMunicipios_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(459, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 6);
            label1.Name = "label1";
            label1.Size = new Size(183, 29);
            label1.TabIndex = 27;
            label1.Text = "Borrar Departamento";
            // 
            // BorrarDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(536, 316);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(txtNombreMunicipio);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox3);
            Controls.Add(ListaMunicipios);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "BorrarDepartamento";
            Text = "BorrarDepartamento";
            Load += BorrarDepartamento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBox1;
        private Button button2;
        private Label label3;
        private TextBox txtNombreMunicipio;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private ListBox ListaMunicipios;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}