namespace Library
{
    partial class BookInfo
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
            BackBtn = new Button();
            createBtn = new TextBox();
            RetrieveBtn = new TextBox();
            UpdateBtn = new TextBox();
            DeleteBtn = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox7 = new ComboBox();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(655, 50);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 0;
            label1.Text = "Book's Information";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Honeydew;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(407, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(705, 409);
            dataGridView1.TabIndex = 1;
            // 
            // BackBtn
            // 
            BackBtn.FlatStyle = FlatStyle.Popup;
            BackBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackBtn.Location = new Point(-2, -3);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 2;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // createBtn
            // 
            createBtn.BorderStyle = BorderStyle.None;
            createBtn.Cursor = Cursors.IBeam;
            createBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.Location = new Point(407, 548);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(100, 19);
            createBtn.TabIndex = 12;
            createBtn.Text = "Create";
            createBtn.TextAlign = HorizontalAlignment.Center;
            // 
            // RetrieveBtn
            // 
            RetrieveBtn.BorderStyle = BorderStyle.None;
            RetrieveBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RetrieveBtn.Location = new Point(576, 548);
            RetrieveBtn.Name = "RetrieveBtn";
            RetrieveBtn.Size = new Size(100, 19);
            RetrieveBtn.TabIndex = 13;
            RetrieveBtn.Text = "Retrieve";
            RetrieveBtn.TextAlign = HorizontalAlignment.Center;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BorderStyle = BorderStyle.None;
            UpdateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(812, 548);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(100, 19);
            UpdateBtn.TabIndex = 14;
            UpdateBtn.Text = "Update";
            UpdateBtn.TextAlign = HorizontalAlignment.Center;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BorderStyle = BorderStyle.None;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.Location = new Point(1012, 548);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(100, 19);
            DeleteBtn.TabIndex = 15;
            DeleteBtn.Text = "Delete";
            DeleteBtn.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(21, 420);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 26);
            textBox1.TabIndex = 16;
            textBox1.Text = "SHELF LOCATION:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(48, 359);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 26);
            textBox2.TabIndex = 17;
            textBox2.Text = "PUBLISHER:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(21, 299);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 19);
            textBox3.TabIndex = 18;
            textBox3.Text = "PUBLISHED YEAR:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(48, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(111, 19);
            textBox4.TabIndex = 19;
            textBox4.Text = "AUTHOR ID:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(63, 169);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(64, 19);
            textBox5.TabIndex = 20;
            textBox5.Text = "TITLE:";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(48, 99);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 19);
            textBox6.TabIndex = 21;
            textBox6.Text = "Book ID";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(239, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 22;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(239, 165);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 23;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(239, 229);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 24;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(239, 295);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 25;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(239, 359);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 26;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(239, 423);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 27;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(239, 486);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(121, 23);
            comboBox7.TabIndex = 28;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(48, 483);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(111, 19);
            textBox7.TabIndex = 29;
            textBox7.Text = "ISBN:";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // BookInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1208, 691);
            Controls.Add(textBox7);
            Controls.Add(comboBox7);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(RetrieveBtn);
            Controls.Add(createBtn);
            Controls.Add(BackBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookInfo";
            Text = "BookInfo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button BackBtn;
        private TextBox createBtn;
        private TextBox RetrieveBtn;
        private TextBox UpdateBtn;
        private TextBox DeleteBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private TextBox textBox7;
    }
}