namespace Library
{
    partial class Login
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
            usernamebtn = new TextBox();
            usernamesbtn = new TextBox();
            PasswordBtn = new TextBox();
            passbtn = new TextBox();
            loginbtn = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernamebtn
            // 
            usernamebtn.BackColor = Color.MediumSeaGreen;
            usernamebtn.BorderStyle = BorderStyle.None;
            usernamebtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            usernamebtn.Location = new Point(295, 294);
            usernamebtn.Name = "usernamebtn";
            usernamebtn.Size = new Size(100, 18);
            usernamebtn.TabIndex = 0;
            usernamebtn.Text = "Username :";
            usernamebtn.TextAlign = HorizontalAlignment.Center;
            // 
            // usernamesbtn
            // 
            usernamesbtn.Location = new Point(390, 294);
            usernamesbtn.Name = "usernamesbtn";
            usernamesbtn.Size = new Size(151, 23);
            usernamesbtn.TabIndex = 1;
            // 
            // PasswordBtn
            // 
            PasswordBtn.Location = new Point(390, 333);
            PasswordBtn.Name = "PasswordBtn";
            PasswordBtn.Size = new Size(151, 23);
            PasswordBtn.TabIndex = 2;
            // 
            // passbtn
            // 
            passbtn.BackColor = Color.MediumSeaGreen;
            passbtn.BorderStyle = BorderStyle.None;
            passbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            passbtn.Location = new Point(293, 333);
            passbtn.Name = "passbtn";
            passbtn.Size = new Size(100, 18);
            passbtn.TabIndex = 3;
            passbtn.Text = "Password :";
            passbtn.TextAlign = HorizontalAlignment.Center;
            passbtn.TextChanged += passbtn_TextChanged;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.Location = new Point(432, 362);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(75, 23);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._482669819_638377848771400_2931107360208488733_n;
            pictureBox1.Location = new Point(363, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MediumSeaGreen;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Footlight MT Light", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(220, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(481, 31);
            textBox1.TabIndex = 6;
            textBox1.Text = "Public Library System";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(245, 162);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(888, 482);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(loginbtn);
            Controls.Add(passbtn);
            Controls.Add(PasswordBtn);
            Controls.Add(usernamesbtn);
            Controls.Add(usernamebtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernamebtn;
        private TextBox usernamesbtn;
        private TextBox PasswordBtn;
        private TextBox passbtn;
        private Button loginbtn;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
    }
}