namespace ProgramaMongo.Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarMunicipio));
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
            label4 = new Label();
            textCodigo = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(530, 424);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(137, 55);
            button2.TabIndex = 22;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(485, 312);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(236, 32);
            label3.TabIndex = 21;
            label3.Text = "Nombre Municipio";
            // 
            // txtNombreMunicipio
            // 
            txtNombreMunicipio.Enabled = false;
            txtNombreMunicipio.Location = new Point(498, 349);
            txtNombreMunicipio.Margin = new Padding(4, 5, 4, 5);
            txtNombreMunicipio.Name = "txtNombreMunicipio";
            txtNombreMunicipio.Size = new Size(201, 31);
            txtNombreMunicipio.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(261, 32);
            label2.TabIndex = 19;
            label2.Text = "Municipios Existentes";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(402, 100);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(14, 415);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 440);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(384, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // ListaMunicipios
            // 
            ListaMunicipios.BackColor = SystemColors.ScrollBar;
            ListaMunicipios.FormattingEnabled = true;
            ListaMunicipios.ItemHeight = 25;
            ListaMunicipios.Location = new Point(70, 184);
            ListaMunicipios.Margin = new Padding(4, 5, 4, 5);
            ListaMunicipios.Name = "ListaMunicipios";
            ListaMunicipios.Size = new Size(278, 229);
            ListaMunicipios.TabIndex = 16;
            ListaMunicipios.SelectedIndexChanged += ListaMunicipios_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, -3);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(652, -3);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 43);
            label1.TabIndex = 13;
            label1.Text = "Borrar Municipio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(451, 226);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(301, 32);
            label4.TabIndex = 24;
            label4.Text = "Nombre Departamento";
            // 
            // textCodigo
            // 
            textCodigo.Enabled = false;
            textCodigo.Location = new Point(498, 263);
            textCodigo.Margin = new Padding(4, 5, 4, 5);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(201, 31);
            textCodigo.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(489, 144);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(220, 32);
            label5.TabIndex = 26;
            label5.Text = "Código Municipio";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(451, 181);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 31);
            textBox1.TabIndex = 25;
            // 
            // BorrarMunicipio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(763, 524);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(textCodigo);
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
            Name = "BorrarMunicipio";
            Text = "BorrarMunicipio";
            Load += BorrarMunicipio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label4;
        private TextBox textCodigo;
        private Label label5;
        private TextBox textBox1;
    }
}