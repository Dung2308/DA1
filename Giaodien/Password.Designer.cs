namespace Giaodien
{
    partial class Password
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.The_Most_and_Least_Expensive_Michelin_3_Star_Restaurants1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(579, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(297, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Castellar", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(459, 39);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Castellar", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(138, 212);
            button2.Name = "button2";
            button2.Size = new Size(147, 50);
            button2.TabIndex = 8;
            button2.Text = "Change password";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Castellar", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 39);
            button3.Name = "button3";
            button3.Size = new Size(103, 29);
            button3.TabIndex = 9;
            button3.Text = "Username";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Castellar", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 91);
            button4.Name = "button4";
            button4.Size = new Size(103, 40);
            button4.TabIndex = 10;
            button4.Text = "New password";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Castellar", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(12, 149);
            button5.Name = "button5";
            button5.Size = new Size(103, 40);
            button5.TabIndex = 11;
            button5.Text = "confirm password";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(138, 71);
            label1.Name = "label1";
            label1.Size = new Size(272, 22);
            label1.TabIndex = 12;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.Location = new Point(138, 184);
            label2.Name = "label2";
            label2.Size = new Size(272, 25);
            label2.TabIndex = 13;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // button6
            // 
            button6.Font = new Font("Castellar", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(317, 212);
            button6.Name = "button6";
            button6.Size = new Size(147, 50);
            button6.TabIndex = 14;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 281);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Password";
            Text = "Form1";
            Load += Password_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Button button6;
    }
}