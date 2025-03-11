namespace Library
{
    partial class MembersInfocs
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
            dataGridView1 = new DataGridView();
            PhoneBtn = new ComboBox();
            emailBtn = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LastnameBox = new TextBox();
            FirstnameBox = new TextBox();
            textBox5 = new TextBox();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(635, 57);
            label1.Name = "label1";
            label1.Size = new Size(237, 25);
            label1.TabIndex = 0;
            label1.Text = "Member's Information";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Honeydew;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(440, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(688, 425);
            dataGridView1.TabIndex = 1;
            // 
            // PhoneBtn
            // 
            PhoneBtn.FlatStyle = FlatStyle.Popup;
            PhoneBtn.FormattingEnabled = true;
            PhoneBtn.Location = new Point(193, 427);
            PhoneBtn.Name = "PhoneBtn";
            PhoneBtn.Size = new Size(121, 33);
            PhoneBtn.TabIndex = 24;
            // 
            // emailBtn
            // 
            emailBtn.FlatStyle = FlatStyle.Popup;
            emailBtn.FormattingEnabled = true;
            emailBtn.Location = new Point(193, 347);
            emailBtn.Name = "emailBtn";
            emailBtn.Size = new Size(121, 33);
            emailBtn.TabIndex = 25;
            // 
            // comboBox4
            // 
            comboBox4.FlatStyle = FlatStyle.Popup;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(193, 268);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 33);
            comboBox4.TabIndex = 26;
            // 
            // comboBox5
            // 
            comboBox5.FlatStyle = FlatStyle.Popup;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(193, 187);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 33);
            comboBox5.TabIndex = 27;
            // 
            // comboBox6
            // 
            comboBox6.FlatStyle = FlatStyle.Popup;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(193, 104);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 33);
            comboBox6.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(35, 429);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 19);
            textBox1.TabIndex = 30;
            textBox1.Text = "PHONE NO.:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(35, 347);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 19);
            textBox2.TabIndex = 31;
            textBox2.Text = "EMAIL:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // LastnameBox
            // 
            LastnameBox.BorderStyle = BorderStyle.None;
            LastnameBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LastnameBox.Location = new Point(35, 268);
            LastnameBox.Name = "LastnameBox";
            LastnameBox.Size = new Size(114, 19);
            LastnameBox.TabIndex = 32;
            LastnameBox.Text = "LAST NAME:";
            LastnameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // FirstnameBox
            // 
            FirstnameBox.BorderStyle = BorderStyle.None;
            FirstnameBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FirstnameBox.Location = new Point(35, 187);
            FirstnameBox.Name = "FirstnameBox";
            FirstnameBox.Size = new Size(114, 19);
            FirstnameBox.TabIndex = 33;
            FirstnameBox.Text = "FIRST NAME:";
            FirstnameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(35, 106);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 19);
            textBox5.TabIndex = 34;
            textBox5.Text = "Member ID:";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // BackBtn
            // 
            BackBtn.FlatStyle = FlatStyle.Popup;
            BackBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackBtn.Location = new Point(-1, 0);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 35;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // MembersInfocs
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1220, 569);
            Controls.Add(BackBtn);
            Controls.Add(textBox5);
            Controls.Add(FirstnameBox);
            Controls.Add(LastnameBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(emailBtn);
            Controls.Add(PhoneBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "MembersInfocs";
            Text = "MembersInfocs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox PhoneBtn;
        private ComboBox emailBtn;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private TextBox textBox6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox LastnameBox;
        private TextBox FirstnameBox;
        private TextBox textBox5;
        private Button BackBtn;
    }
}