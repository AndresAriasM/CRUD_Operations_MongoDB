namespace ProgramaMongo.Formularios
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
            Lista = new Label();
            pictureBox3 = new PictureBox();
            ListaProgramas = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            txtNombrePrograma = new TextBox();
            txtValor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Lista
            // 
            Lista.AutoSize = true;
            Lista.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Lista.Location = new Point(76, 87);
            Lista.Name = "Lista";
            Lista.Size = new Size(141, 21);
            Lista.TabIndex = 12;
            Lista.Text = "Lista Programas";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 265);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(269, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // ListaProgramas
            // 
            ListaProgramas.BackColor = SystemColors.ScrollBar;
            ListaProgramas.FormattingEnabled = true;
            ListaProgramas.ItemHeight = 15;
            ListaProgramas.Location = new Point(50, 111);
            ListaProgramas.Name = "ListaProgramas";
            ListaProgramas.Size = new Size(196, 139);
            ListaProgramas.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(459, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 6);
            label1.Name = "label1";
            label1.Size = new Size(145, 29);
            label1.TabIndex = 7;
            label1.Text = "Nuevo Programa";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(286, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 250);
            panel1.TabIndex = 13;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(321, 61);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(204, 141);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // txtNombrePrograma
            // 
            txtNombrePrograma.Location = new Point(315, 235);
            txtNombrePrograma.Name = "txtNombrePrograma";
            txtNombrePrograma.Size = new Size(100, 23);
            txtNombrePrograma.TabIndex = 15;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(435, 235);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(300, 214);
            label2.Name = "label2";
            label2.Size = new Size(133, 18);
            label2.TabIndex = 17;
            label2.Text = "Nombre Programa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(463, 216);
            label3.Name = "label3";
            label3.Size = new Size(43, 18);
            label3.TabIndex = 18;
            label3.Text = "Valor";
            // 
            // button1
            // 
            button1.Location = new Point(371, 265);
            button1.Name = "button1";
            button1.Size = new Size(99, 38);
            button1.TabIndex = 19;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NuevoPrograma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(537, 315);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtValor);
            Controls.Add(txtNombrePrograma);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Controls.Add(Lista);
            Controls.Add(pictureBox3);
            Controls.Add(ListaProgramas);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoPrograma";
            Text = "NuevoPrograma";
            Load += NuevoPrograma_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lista;
        private PictureBox pictureBox3;
        private ListBox ListaProgramas;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox4;
        private TextBox txtNombrePrograma;
        private TextBox txtValor;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}