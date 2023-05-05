namespace ProgramaMongo.Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizaMunicipio));
            label5 = new Label();
            txtCodigo = new TextBox();
            label4 = new Label();
            txtNombreMunicipio = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            ListaMunicipios = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ListaDepartamentos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(486, 115);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(220, 32);
            label5.TabIndex = 54;
            label5.Text = "Código Municipio";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(445, 147);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(299, 31);
            txtCodigo.TabIndex = 53;
            txtCodigo.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(473, 197);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(266, 32);
            label4.TabIndex = 52;
            label4.Text = "Lista Departamentos";
            // 
            // txtNombreMunicipio
            // 
            txtNombreMunicipio.Location = new Point(498, 406);
            txtNombreMunicipio.Margin = new Padding(4, 5, 4, 5);
            txtNombreMunicipio.Name = "txtNombreMunicipio";
            txtNombreMunicipio.Size = new Size(201, 31);
            txtNombreMunicipio.TabIndex = 51;
            // 
            // button2
            // 
            button2.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(530, 456);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(137, 55);
            button2.TabIndex = 50;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(498, 370);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(202, 32);
            label3.TabIndex = 49;
            label3.Text = "Nuevo Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 150);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(261, 32);
            label2.TabIndex = 47;
            label2.Text = "Municipios Existentes";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(402, 103);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(14, 415);
            flowLayoutPanel1.TabIndex = 46;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 443);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(384, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // ListaMunicipios
            // 
            ListaMunicipios.BackColor = SystemColors.ScrollBar;
            ListaMunicipios.FormattingEnabled = true;
            ListaMunicipios.ItemHeight = 25;
            ListaMunicipios.Location = new Point(70, 187);
            ListaMunicipios.Margin = new Padding(4, 5, 4, 5);
            ListaMunicipios.Name = "ListaMunicipios";
            ListaMunicipios.Size = new Size(278, 229);
            ListaMunicipios.TabIndex = 44;
            ListaMunicipios.SelectedIndexChanged += ListaMunicipios_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(654, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 43);
            label1.TabIndex = 41;
            label1.Text = "Actualizar Municipio";
            // 
            // ListaDepartamentos
            // 
            ListaDepartamentos.BackColor = SystemColors.ScrollBar;
            ListaDepartamentos.FormattingEnabled = true;
            ListaDepartamentos.ItemHeight = 25;
            ListaDepartamentos.Location = new Point(468, 230);
            ListaDepartamentos.Margin = new Padding(4, 5, 4, 5);
            ListaDepartamentos.Name = "ListaDepartamentos";
            ListaDepartamentos.Size = new Size(278, 129);
            ListaDepartamentos.TabIndex = 55;
            // 
            // ActualizaMunicipio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(765, 525);
            Controls.Add(ListaDepartamentos);
            Controls.Add(label5);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(txtNombreMunicipio);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox3);
            Controls.Add(ListaMunicipios);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActualizaMunicipio";
            Text = "ActualizaMunicipio";
            Load += ActualizaMunicipio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtCodigo;
        private Label label4;
        private TextBox txtNombreMunicipio;
        private Button button2;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private ListBox ListaMunicipios;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private ListBox ListaDepartamentos;
    }
}