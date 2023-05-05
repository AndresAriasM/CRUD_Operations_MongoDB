namespace ProgramaMongo.Formularios
{
    partial class NuevoBeneficiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoBeneficiario));
            button2 = new Button();
            label3 = new Label();
            txtNombreMunicipio = new TextBox();
            ListaDepartamento = new Label();
            ListaMunicipios = new ListBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            ListaBeneficiarios = new ListBox();
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
            button2.Location = new Point(367, 280);
            button2.Name = "button2";
            button2.Size = new Size(96, 33);
            button2.TabIndex = 23;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(331, 230);
            label3.Name = "label3";
            label3.Size = new Size(174, 21);
            label3.TabIndex = 22;
            label3.Text = "Nombre Beneficiario";
            // 
            // txtNombreMunicipio
            // 
            txtNombreMunicipio.Location = new Point(309, 251);
            txtNombreMunicipio.Name = "txtNombreMunicipio";
            txtNombreMunicipio.Size = new Size(214, 23);
            txtNombreMunicipio.TabIndex = 21;
            // 
            // ListaDepartamento
            // 
            ListaDepartamento.AutoSize = true;
            ListaDepartamento.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListaDepartamento.Location = new Point(344, 59);
            ListaDepartamento.Name = "ListaDepartamento";
            ListaDepartamento.Size = new Size(135, 21);
            ListaDepartamento.TabIndex = 20;
            ListaDepartamento.Text = "Lista Municipios";
            // 
            // ListaMunicipios
            // 
            ListaMunicipios.BackColor = SystemColors.ScrollBar;
            ListaMunicipios.FormattingEnabled = true;
            ListaMunicipios.ItemHeight = 15;
            ListaMunicipios.Location = new Point(318, 86);
            ListaMunicipios.Name = "ListaMunicipios";
            ListaMunicipios.Size = new Size(196, 139);
            ListaMunicipios.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 88);
            label2.Name = "label2";
            label2.Size = new Size(152, 21);
            label2.TabIndex = 18;
            label2.Text = "Lista Beneficiarios";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(269, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // ListaBeneficiarios
            // 
            ListaBeneficiarios.BackColor = SystemColors.ScrollBar;
            ListaBeneficiarios.FormattingEnabled = true;
            ListaBeneficiarios.ItemHeight = 15;
            ListaBeneficiarios.Location = new Point(50, 112);
            ListaBeneficiarios.Name = "ListaBeneficiarios";
            ListaBeneficiarios.Size = new Size(196, 139);
            ListaBeneficiarios.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(457, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 7);
            label1.Name = "label1";
            label1.Size = new Size(161, 29);
            label1.TabIndex = 13;
            label1.Text = "Nuevo Beneficiario";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(281, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(10, 249);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // NuevoBeneficiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(535, 318);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(txtNombreMunicipio);
            Controls.Add(ListaDepartamento);
            Controls.Add(ListaMunicipios);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(ListaBeneficiarios);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoBeneficiario";
            Text = "NuevoBeneficiario";
            Load += NuevoBeneficiario_Load;
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
        private ListBox ListaMunicipios;
        private Label label2;
        private PictureBox pictureBox3;
        private ListBox ListaBeneficiarios;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}