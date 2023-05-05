namespace ProgramaMongo.Formularios
{
    partial class ActualizaDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizaDepartamento));
            label5 = new Label();
            txtCodigo = new TextBox();
            txtNombreMunicipio = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            ListaDepartamentos = new ListBox();
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
            label5.Location = new Point(325, 88);
            label5.Name = "label5";
            label5.Size = new Size(191, 21);
            label5.TabIndex = 68;
            label5.Text = "Código Departamento";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(311, 112);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(210, 23);
            txtCodigo.TabIndex = 67;
            // 
            // txtNombreMunicipio
            // 
            txtNombreMunicipio.Location = new Point(350, 181);
            txtNombreMunicipio.Name = "txtNombreMunicipio";
            txtNombreMunicipio.Size = new Size(142, 23);
            txtNombreMunicipio.TabIndex = 65;
            // 
            // button2
            // 
            button2.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(360, 230);
            button2.Name = "button2";
            button2.Size = new Size(125, 47);
            button2.TabIndex = 64;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(350, 160);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 63;
            label3.Text = "Nuevo Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 90);
            label2.Name = "label2";
            label2.Size = new Size(217, 21);
            label2.TabIndex = 62;
            label2.Text = "Departamentos Existentes";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(281, 62);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(10, 249);
            flowLayoutPanel1.TabIndex = 61;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(269, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            // 
            // ListaDepartamentos
            // 
            ListaDepartamentos.BackColor = SystemColors.ScrollBar;
            ListaDepartamentos.FormattingEnabled = true;
            ListaDepartamentos.ItemHeight = 15;
            ListaDepartamentos.Location = new Point(49, 112);
            ListaDepartamentos.Name = "ListaDepartamentos";
            ListaDepartamentos.Size = new Size(196, 139);
            ListaDepartamentos.TabIndex = 59;
            ListaDepartamentos.SelectedIndexChanged += ListaDepartamentos_SelectedIndexChanged_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(459, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 29);
            label1.TabIndex = 56;
            label1.Text = "Actualizar Departamento";
            // 
            // ActualizaDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(537, 317);
            Controls.Add(label5);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombreMunicipio);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox3);
            Controls.Add(ListaDepartamentos);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActualizaDepartamento";
            Text = "ActualizaDepartamento";
            Load += ActualizaDepartamento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox txtCodigo;
        private TextBox txtNombreMunicipio;
        private Button button2;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private ListBox ListaDepartamentos;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}