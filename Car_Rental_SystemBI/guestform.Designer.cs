namespace Car_Rental_SystemBI
{
    partial class guestform
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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(467, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 457);
            panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 248);
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
            label4.Location = new Point(62, 220);
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
            label2.Location = new Point(62, 109);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 4;
            label2.Text = "USERNAME";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 149);
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
            button1.Location = new Point(125, 358);
            button1.Name = "button1";
            button1.Size = new Size(175, 49);
            button1.TabIndex = 2;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Baskerville Old Face", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(125, 23);
            label1.Name = "label1";
            label1.Size = new Size(158, 45);
            label1.TabIndex = 1;
            label1.Text = "GUEST";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Screenshot__122_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(31, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 63);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(548, 35);
            label3.Name = "label3";
            label3.Size = new Size(209, 22);
            label3.TabIndex = 40;
            label3.Text = "CAR RENTAL SERVICE";
            // 
            // guestform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_04_28_224652;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1303, 940);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "guestform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "guestform";
            Load += guestform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}