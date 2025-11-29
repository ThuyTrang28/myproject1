namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            button4 = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._360_F_750607046_DuUEAdnx6Pvh3EwXUVDRVqXW0exAk5lR;
            pictureBox2.Location = new Point(-237, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._360_F_750607046_DuUEAdnx6Pvh3EwXUVDRVqXW0exAk5lR;
            pictureBox3.Location = new Point(-18, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(768, 599);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(216, 100);
            button1.Name = "button1";
            button1.Size = new Size(353, 386);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources._8345328;
            pictureBox1.Location = new Point(344, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 218);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 13;
            label1.Text = "Login to Your Account";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(276, 262);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 16;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(276, 318);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(276, 383);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(416, 380);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 19;
            label4.Text = "Forgot Password?";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(276, 420);
            button4.Name = "button4";
            button4.Size = new Size(240, 34);
            button4.TabIndex = 20;
            button4.Text = "Login";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(276, 283);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 23);
            txtUsername.TabIndex = 21;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(276, 336);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(240, 23);
            txtPassword.TabIndex = 22;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 597);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Label label4;
        private Button button4;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}
