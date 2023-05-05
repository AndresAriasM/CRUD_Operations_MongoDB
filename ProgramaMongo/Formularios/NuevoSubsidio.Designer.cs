namespace ProgramaMongo.Formularios
{
    partial class NuevoSubsidio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoSubsidio));
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            label3 = new Label();
            ListaDepartamento = new Label();
            ListaProgramas = new ListBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            ListaSubsidios = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ListaBeneficiarios = new ListBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(303, 61);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(10, 249);
            flowLayoutPanel1.TabIndex = 36;
            // 
            // button2
            // 
            button2.Location = new Point(571, 243);
            button2.Name = "button2";
            button2.Size = new Size(96, 62);
            button2.TabIndex = 35;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(389, 230);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 34;
            label3.Text = "Fecha\r\n";
            // 
            // ListaDepartamento
            // 
            ListaDepartamento.AllowDrop = true;
            ListaDepartamento.AutoSize = true;
            ListaDepartamento.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListaDepartamento.Location = new Point(355, 66);
            ListaDepartamento.Name = "ListaDepartamento";
            ListaDepartamento.Size = new Size(92, 21);
            ListaDepartamento.TabIndex = 32;
            ListaDepartamento.Text = "Programa";
            // 
            // ListaProgramas
            // 
            ListaProgramas.BackColor = SystemColors.ScrollBar;
            ListaProgramas.FormattingEnabled = true;
            ListaProgramas.ItemHeight = 15;
            ListaProgramas.Location = new Point(319, 88);
            ListaProgramas.Name = "ListaProgramas";
            ListaProgramas.Size = new Size(179, 139);
            ListaProgramas.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 88);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 30;
            label2.Text = "Lista Subsidios";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(269, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // ListaSubsidios
            // 
            ListaSubsidios.BackColor = SystemColors.ScrollBar;
            ListaSubsidios.FormattingEnabled = true;
            ListaSubsidios.ItemHeight = 15;
            ListaSubsidios.Location = new Point(8, 112);
            ListaSubsidios.Name = "ListaSubsidios";
            ListaSubsidios.Size = new Size(285, 139);
            ListaSubsidios.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(601, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(266, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 25;
            label1.Text = "Nuevo Subsidio";
            // 
            // ListaBeneficiarios
            // 
            ListaBeneficiarios.BackColor = SystemColors.ScrollBar;
            ListaBeneficiarios.FormattingEnabled = true;
            ListaBeneficiarios.ItemHeight = 15;
            ListaBeneficiarios.Location = new Point(504, 88);
            ListaBeneficiarios.Name = "ListaBeneficiarios";
            ListaBeneficiarios.Size = new Size(167, 139);
            ListaBeneficiarios.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(536, 66);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 38;
            label4.Text = "Beneficiario";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(319, 261);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(222, 23);
            dateTimePicker1.TabIndex = 39;
            // 
            // NuevoSubsidio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(679, 317);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(ListaBeneficiarios);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(ListaDepartamento);
            Controls.Add(ListaProgramas);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(ListaSubsidios);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoSubsidio";
            Text = "NuevoSubsidio";
            Load += NuevoSubsidio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Label label3;
        private Label ListaDepartamento;
        private ListBox ListaProgramas;
        private Label label2;
        private PictureBox pictureBox3;
        private ListBox ListaSubsidios;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private ListBox ListaBeneficiarios;
        private Label label4;
        private DateTimePicker dateTimePicker1;
    }
}