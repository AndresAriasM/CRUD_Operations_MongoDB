namespace ProgramaMongo.Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoMunicipio));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ListaMunicipios = new ListBox();
            pictureBox3 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            ListaDepartamento = new Label();
            ListaDepartamentos = new ListBox();
            txtNombreMunicipio = new TextBox();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 7);
            label1.Name = "label1";
            label1.Size = new Size(142, 29);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Municipio";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(457, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // ListaMunicipios
            // 
            ListaMunicipios.BackColor = SystemColors.ScrollBar;
            ListaMunicipios.FormattingEnabled = true;
            ListaMunicipios.ItemHeight = 15;
            ListaMunicipios.Location = new Point(50, 112);
            ListaMunicipios.Name = "ListaMunicipios";
            ListaMunicipios.Size = new Size(196, 139);
            ListaMunicipios.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(269, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(282, 62);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(10, 249);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 88);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 6;
            label2.Text = "Lista Municipios";
            label2.Click += label2_Click;
            // 
            // ListaDepartamento
            // 
            ListaDepartamento.AutoSize = true;
            ListaDepartamento.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListaDepartamento.Location = new Point(331, 59);
            ListaDepartamento.Name = "ListaDepartamento";
            ListaDepartamento.Size = new Size(179, 21);
            ListaDepartamento.TabIndex = 8;
            ListaDepartamento.Text = "Lista Departamentos";
            // 
            // ListaDepartamentos
            // 
            ListaDepartamentos.BackColor = SystemColors.ScrollBar;
            ListaDepartamentos.FormattingEnabled = true;
            ListaDepartamentos.ItemHeight = 15;
            ListaDepartamentos.Location = new Point(318, 86);
            ListaDepartamentos.Name = "ListaDepartamentos";
            ListaDepartamentos.Size = new Size(196, 139);
            ListaDepartamentos.TabIndex = 7;
            ListaDepartamentos.SelectedIndexChanged += ListaDepartamentos_SelectedIndexChanged;
            // 
            // txtNombreMunicipio
            // 
            txtNombreMunicipio.Location = new Point(350, 246);
            txtNombreMunicipio.Name = "txtNombreMunicipio";
            txtNombreMunicipio.Size = new Size(142, 23);
            txtNombreMunicipio.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(344, 227);
            label3.Name = "label3";
            label3.Size = new Size(157, 21);
            label3.TabIndex = 10;
            label3.Text = "Nombre Municipio";
            // 
            // button2
            // 
            button2.Location = new Point(373, 277);
            button2.Name = "button2";
            button2.Size = new Size(96, 33);
            button2.TabIndex = 12;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NuevoMunicipio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(535, 315);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(txtNombreMunicipio);
            Controls.Add(ListaDepartamento);
            Controls.Add(ListaDepartamentos);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox3);
            Controls.Add(ListaMunicipios);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoMunicipio";
            Text = "NuevoMunicipio";
            Load += NuevoMunicipio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox ListaMunicipios;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label ListaDepartamento;
        private ListBox ListaDepartamentos;
        private TextBox txtNombreMunicipio;
        private Label label3;
        private Button button2;
    }
}