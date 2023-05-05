namespace ProgramaMongo.Formularios
{
    partial class ActualizaSubsidio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizaSubsidio));
            label4 = new Label();
            label5 = new Label();
            txtCodigo = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            ListaSubsidio = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ListaBeneficiario = new ListBox();
            ListaPrograma = new ListBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(514, 113);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 83;
            label4.Text = "Nuevo Programa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(429, 56);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 82;
            label5.Text = "Código Subsidio";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(394, 79);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(210, 23);
            txtCodigo.TabIndex = 81;
            // 
            // button2
            // 
            button2.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(442, 266);
            button2.Name = "button2";
            button2.Size = new Size(129, 42);
            button2.TabIndex = 79;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(319, 113);
            label3.Name = "label3";
            label3.Size = new Size(162, 21);
            label3.TabIndex = 78;
            label3.Text = "Nuevo Beneficiario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 91);
            label2.Name = "label2";
            label2.Size = new Size(162, 21);
            label2.TabIndex = 77;
            label2.Text = "Subsidios Existentes";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(281, 62);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(10, 249);
            flowLayoutPanel1.TabIndex = 76;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(269, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 75;
            pictureBox3.TabStop = false;
            // 
            // ListaSubsidio
            // 
            ListaSubsidio.BackColor = SystemColors.ScrollBar;
            ListaSubsidio.FormattingEnabled = true;
            ListaSubsidio.ItemHeight = 15;
            ListaSubsidio.Location = new Point(15, 112);
            ListaSubsidio.Name = "ListaSubsidio";
            ListaSubsidio.Size = new Size(254, 139);
            ListaSubsidio.TabIndex = 74;
            ListaSubsidio.SelectedIndexChanged += ListaSubsidio_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 73;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(624, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 72;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(246, 7);
            label1.Name = "label1";
            label1.Size = new Size(169, 29);
            label1.TabIndex = 71;
            label1.Text = "Actualizar Subsidio";
            // 
            // ListaBeneficiario
            // 
            ListaBeneficiario.BackColor = SystemColors.ScrollBar;
            ListaBeneficiario.FormattingEnabled = true;
            ListaBeneficiario.ItemHeight = 15;
            ListaBeneficiario.Location = new Point(318, 135);
            ListaBeneficiario.Name = "ListaBeneficiario";
            ListaBeneficiario.Size = new Size(172, 64);
            ListaBeneficiario.TabIndex = 84;
            // 
            // ListaPrograma
            // 
            ListaPrograma.BackColor = SystemColors.ScrollBar;
            ListaPrograma.FormattingEnabled = true;
            ListaPrograma.ItemHeight = 15;
            ListaPrograma.Location = new Point(505, 135);
            ListaPrograma.Name = "ListaPrograma";
            ListaPrograma.Size = new Size(177, 64);
            ListaPrograma.TabIndex = 85;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(442, 204);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 86;
            label6.Text = "Nuevo Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(359, 231);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 23);
            dateTimePicker1.TabIndex = 87;
            // 
            // ActualizaSubsidio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(701, 316);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(ListaPrograma);
            Controls.Add(ListaBeneficiario);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtCodigo);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox3);
            Controls.Add(ListaSubsidio);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "ActualizaSubsidio";
            Text = "ActualizaSubsidio";
            Load += ActualizaSubsidio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private TextBox txtCodigo;
        private Button button2;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private ListBox ListaSubsidio;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private ListBox ListaBeneficiario;
        private ListBox ListaPrograma;
        private Label label6;
        private DateTimePicker dateTimePicker1;
    }
}