namespace Library
{
    partial class AdminForm
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
            AuthorBtn = new Button();
            BookBtn = new Button();
            MembersBtn = new Button();
            CrossBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.oo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(115, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 174);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AuthorBtn
            // 
            AuthorBtn.Location = new Point(33, 325);
            AuthorBtn.Name = "AuthorBtn";
            AuthorBtn.Size = new Size(124, 36);
            AuthorBtn.TabIndex = 5;
            AuthorBtn.Text = "Author";
            AuthorBtn.UseVisualStyleBackColor = true;
            AuthorBtn.Click += AuthorBtn_Click;
            // 
            // BookBtn
            // 
            BookBtn.Location = new Point(227, 325);
            BookBtn.Name = "BookBtn";
            BookBtn.Size = new Size(124, 36);
            BookBtn.TabIndex = 6;
            BookBtn.Text = "Books";
            BookBtn.UseVisualStyleBackColor = true;
            BookBtn.Click += BookBtn_Click;
            // 
            // MembersBtn
            // 
            MembersBtn.Location = new Point(139, 398);
            MembersBtn.Name = "MembersBtn";
            MembersBtn.Size = new Size(124, 36);
            MembersBtn.TabIndex = 7;
            MembersBtn.Text = "Members";
            MembersBtn.UseVisualStyleBackColor = true;
            MembersBtn.Click += MembersBtn_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.FlatStyle = FlatStyle.Popup;
            CrossBtn.Location = new Point(374, 0);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(47, 30);
            CrossBtn.TabIndex = 8;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = true;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(419, 543);
            Controls.Add(CrossBtn);
            Controls.Add(MembersBtn);
            Controls.Add(BookBtn);
            Controls.Add(AuthorBtn);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "AdminForm";
            Text = "Admin";
            Load += AdminBtn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button AuthorBtn;
        private Button BookBtn;
        private Button MembersBtn;
        private Button CrossBtn;
    }
}