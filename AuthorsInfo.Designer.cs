namespace Library
{
    partial class AuthorInfo
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
            dataGridView1 = new DataGridView();
            BackBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            RetrieveBtn = new TextBox();
            UpdateBtn = new TextBox();
            DeleteBtn = new TextBox();
            createBtn = new TextBox();
            AuthorInfoBtn = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Honeydew;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(658, 448);
            dataGridView1.TabIndex = 0;
            // 
            // BackBtn
            // 
            BackBtn.FlatStyle = FlatStyle.Popup;
            BackBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackBtn.Location = new Point(1, 1);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(42, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 19);
            textBox1.TabIndex = 2;
            textBox1.Text = "Author ID";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(42, 505);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 26);
            textBox2.TabIndex = 3;
            textBox2.Text = "SEX:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(42, 423);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 26);
            textBox3.TabIndex = 4;
            textBox3.Text = "WEBSITE:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(30, 329);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(128, 26);
            textBox4.TabIndex = 5;
            textBox4.Text = "BIRTH DATE:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(30, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(128, 26);
            textBox5.TabIndex = 6;
            textBox5.Text = "LAST NAME:";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(30, 163);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(128, 19);
            textBox6.TabIndex = 7;
            textBox6.Text = "FIRST NAME:";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // RetrieveBtn
            // 
            RetrieveBtn.BorderStyle = BorderStyle.None;
            RetrieveBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RetrieveBtn.Location = new Point(513, 566);
            RetrieveBtn.Name = "RetrieveBtn";
            RetrieveBtn.Size = new Size(100, 19);
            RetrieveBtn.TabIndex = 8;
            RetrieveBtn.Text = "Retrieve";
            RetrieveBtn.TextAlign = HorizontalAlignment.Center;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BorderStyle = BorderStyle.None;
            UpdateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(712, 566);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(100, 19);
            UpdateBtn.TabIndex = 9;
            UpdateBtn.Text = "Update";
            UpdateBtn.TextAlign = HorizontalAlignment.Center;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BorderStyle = BorderStyle.None;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(902, 566);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(100, 19);
            DeleteBtn.TabIndex = 10;
            DeleteBtn.Text = "Delete";
            DeleteBtn.TextAlign = HorizontalAlignment.Center;
            // 
            // createBtn
            // 
            createBtn.BorderStyle = BorderStyle.None;
            createBtn.Cursor = Cursors.IBeam;
            createBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.Location = new Point(344, 566);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(100, 19);
            createBtn.TabIndex = 11;
            createBtn.Text = "Create";
            createBtn.TextAlign = HorizontalAlignment.Center;
            // 
            // AuthorInfoBtn
            // 
            AuthorInfoBtn.AutoSize = true;
            AuthorInfoBtn.FlatStyle = FlatStyle.Popup;
            AuthorInfoBtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AuthorInfoBtn.Location = new Point(568, 41);
            AuthorInfoBtn.Name = "AuthorInfoBtn";
            AuthorInfoBtn.Size = new Size(222, 25);
            AuthorInfoBtn.TabIndex = 12;
            AuthorInfoBtn.Text = "Author's Information";
            AuthorInfoBtn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(190, 505);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(190, 423);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 24;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(190, 329);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 25;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(190, 240);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 26;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(190, 163);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 27;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(190, 81);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 28;
            // 
            // AuthorInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1167, 629);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(AuthorInfoBtn);
            Controls.Add(createBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(RetrieveBtn);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(BackBtn);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorInfo";
            Text = "AuthorsInfo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BackBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox RetrieveBtn;
        private TextBox UpdateBtn;
        private TextBox DeleteBtn;
        private TextBox createBtn;
        private Label AuthorInfoBtn;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
    }
}