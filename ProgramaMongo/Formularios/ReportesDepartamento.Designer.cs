namespace ProgramaMongo.Formularios
{
    partial class ReportesDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesDepartamento));
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            ListaDepartamentos = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            listBox2 = new ListBox();
            txtValor = new TextBox();
            label5 = new Label();
            listBox3 = new ListBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(134, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(203, 32);
            label2.TabIndex = 54;
            label2.Text = "Departamentos";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(385, 101);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(17, 167);
            flowLayoutPanel1.TabIndex = 53;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 444);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(384, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 52;
            pictureBox3.TabStop = false;
            // 
            // ListaDepartamentos
            // 
            ListaDepartamentos.BackColor = SystemColors.ScrollBar;
            ListaDepartamentos.FormattingEnabled = true;
            ListaDepartamentos.ItemHeight = 25;
            ListaDepartamentos.Location = new Point(13, 138);
            ListaDepartamentos.Margin = new Padding(4, 5, 4, 5);
            ListaDepartamentos.Name = "ListaDepartamentos";
            ListaDepartamentos.Size = new Size(352, 104);
            ListaDepartamentos.TabIndex = 51;
            ListaDepartamentos.SelectedIndexChanged += ListaDepartamentos_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -2);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(690, -2);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(271, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 43);
            label1.TabIndex = 48;
            label1.Text = "Reportes x Departamento";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel2.Location = new Point(0, 252);
            flowLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(402, 16);
            flowLayoutPanel2.TabIndex = 54;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 288);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(345, 32);
            label3.TabIndex = 56;
            label3.Text = "Municipios x Departamento";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ScrollBar;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(20, 322);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(352, 104);
            listBox1.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(423, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(371, 32);
            label4.TabIndex = 57;
            label4.Text = "Beneficiarios x Departamento";
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.ScrollBar;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(426, 154);
            listBox2.Margin = new Padding(4, 5, 4, 5);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(352, 104);
            listBox2.TabIndex = 58;
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Location = new Point(509, 322);
            txtValor.Margin = new Padding(4, 5, 4, 5);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(201, 31);
            txtValor.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(430, 281);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(355, 32);
            label5.TabIndex = 60;
            label5.Text = "Valor Total x Departamento";
            label5.Click += label5_Click;
            // 
            // listBox3
            // 
            listBox3.BackColor = SystemColors.ScrollBar;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(423, 404);
            listBox3.Margin = new Padding(4, 5, 4, 5);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(352, 104);
            listBox3.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(562, 369);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 32);
            label6.TabIndex = 62;
            label6.Text = "Años";
            // 
            // ReportesDepartamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 527);
            Controls.Add(label6);
            Controls.Add(listBox3);
            Controls.Add(label5);
            Controls.Add(txtValor);
            Controls.Add(listBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox3);
            Controls.Add(ListaDepartamentos);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportesDepartamento";
            Text = "ReportesDepartamentos";
            Load += ReportesDepartamento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private ListBox ListaDepartamentos;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private ListBox listBox1;
        private Label label4;
        private ListBox listBox2;
        private TextBox txtValor;
        private Label label5;
        private ListBox listBox3;
        private Label label6;
    }
}