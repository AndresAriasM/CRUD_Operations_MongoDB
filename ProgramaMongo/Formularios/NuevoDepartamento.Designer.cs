namespace ProgramaMongo.Formularios
{
    partial class NuevoDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoDepartamento));
            button2 = new Button();
            label3 = new Label();
            txtNombreMunicipio = new TextBox();
            ListaDepartamento = new Label();
            pictureBox3 = new PictureBox();
            ListaMunicipios = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(531, 233);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(154, 78);
            button2.TabIndex = 21;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(450, 142);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(301, 32);
            label3.TabIndex = 20;
            label3.Text = "Nombre Departamento";
            // 
            // txtNombreMunicipio
            // 
            txtNombreMunicipio.Location = new Point(494, 179);
            txtNombreMunicipio.Margin = new Padding(4, 5, 4, 5);
            txtNombreMunicipio.Name = "txtNombreMunicipio";
            txtNombreMunicipio.Size = new Size(201, 31);
            txtNombreMunicipio.TabIndex = 19;
            // 
            // ListaDepartamento
            // 
            ListaDepartamento.AutoSize = true;
            ListaDepartamento.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListaDepartamento.Location = new Point(101, 137);
            ListaDepartamento.Margin = new Padding(4, 0, 4, 0);
            ListaDepartamento.Name = "ListaDepartamento";
            ListaDepartamento.Size = new Size(266, 32);
            ListaDepartamento.TabIndex = 18;
            ListaDepartamento.Text = "Lista Departamentos";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 306);
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
            ListaMunicipios.Location = new Point(34, 179);
            ListaMunicipios.Margin = new Padding(4, 5, 4, 5);
            ListaMunicipios.Name = "ListaMunicipios";
            ListaMunicipios.Size = new Size(348, 104);
            ListaMunicipios.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, -1);
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
            pictureBox1.Location = new Point(651, -1);
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
            label1.Location = new Point(239, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(267, 43);
            label1.TabIndex = 13;
            label1.Text = "Nuevo Departamento";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(411, 75);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(19, 308);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // NuevoDepartamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(764, 388);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(txtNombreMunicipio);
            Controls.Add(ListaDepartamento);
            Controls.Add(pictureBox3);
            Controls.Add(ListaMunicipios);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoDepartamento";
            Text = "NuevoDepartamento";
            Load += NuevoDepartamento_Load;
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
        private Label ListaDepartamento;
        private PictureBox pictureBox3;
        private ListBox ListaMunicipios;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}