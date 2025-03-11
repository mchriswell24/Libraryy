namespace Library
{
    partial class Form1
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UsernameText = new Button();
            PasswordText = new Button();
            UsernameTxt = new TextBox();
            PasswordTxt = new TextBox();
            LoginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-6, 164);
            label1.Name = "label1";
            label1.Size = new Size(410, 62);
            label1.TabIndex = 13;
            label1.Text = "Pamantasan ng Lungsod ng San Pablo \r\nLibrary System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.oo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(121, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 134);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // UsernameText
            // 
            UsernameText.FlatStyle = FlatStyle.Popup;
            UsernameText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UsernameText.Location = new Point(12, 304);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(128, 42);
            UsernameText.TabIndex = 15;
            UsernameText.Text = "Username:";
            UsernameText.UseVisualStyleBackColor = true;
            // 
            // PasswordText
            // 
            PasswordText.FlatStyle = FlatStyle.Popup;
            PasswordText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PasswordText.Location = new Point(12, 374);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(128, 45);
            PasswordText.TabIndex = 16;
            PasswordText.Text = "Password:";
            PasswordText.UseVisualStyleBackColor = true;
            // 
            // UsernameTxt
            // 
            UsernameTxt.BorderStyle = BorderStyle.FixedSingle;
            UsernameTxt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameTxt.Location = new Point(160, 310);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(153, 29);
            UsernameTxt.TabIndex = 17;
            UsernameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordTxt.Location = new Point(160, 380);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(153, 29);
            PasswordTxt.TabIndex = 18;
            PasswordTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginBtn
            // 
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(191, 427);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(108, 30);
            LoginBtn.TabIndex = 19;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(404, 515);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTxt);
            Controls.Add(UsernameTxt);
            Controls.Add(PasswordText);
            Controls.Add(UsernameText);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button UsernameText;
        private Button PasswordText;
        private TextBox UsernameTxt;
        private TextBox PasswordTxt;
        private Button LoginBtn;
    }
}