namespace Car_Rental_SystemBI
{
    partial class adminform
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
            panel1 = new Panel();
            textBox2 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label3 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(467, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 412);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 223);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 40);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(62, 189);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 5;
            label4.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(62, 86);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 4;
            label2.Text = "USERNAME";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 122);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 40);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Baskerville Old Face", 11F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(114, 324);
            button1.Name = "button1";
            button1.Size = new Size(175, 49);
            button1.TabIndex = 2;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Baskerville Old Face", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(125, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 45);
            label1.TabIndex = 1;
            label1.Text = "ADMIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sans Serif Collection", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(552, 25);
            label3.Name = "label3";
            label3.Size = new Size(207, 29);
            label3.TabIndex = 41;
            label3.Text = "CAR RENTAL SERVICE";
            // 
            // button3
            // 
            button3.Location = new Point(581, 720);
            button3.Name = "button3";
            button3.Size = new Size(177, 45);
            button3.TabIndex = 42;
            button3.Text = "<< BACK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Screenshot__122_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(31, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 63);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // adminform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_04_28_224919;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1303, 940);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminform";
            Load += adminform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
    }
}