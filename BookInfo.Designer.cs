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
            textBox7 = new TextBox();
            bookidbtn = new TextBox();
            titlebtn = new TextBox();
            authoridbtn = new TextBox();
            yearbtn = new TextBox();
            publisherbtn = new TextBox();
            shelfbtn = new TextBox();
            isbnbtn = new TextBox();
            searchbtn = new TextBox();
            bckbtn = new TextBox();
            updtbtn = new TextBox();
            dltbtn = new TextBox();
            addbtn = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(605, 36);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "Book's Information";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
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
            textBox1.BackColor = Color.MediumSeaGreen;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(37, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 19);
            textBox1.TabIndex = 16;
            textBox1.Text = " Shelf Location :";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MediumSeaGreen;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(43, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 19);
            textBox2.TabIndex = 17;
            textBox2.Text = "Publisher :";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.MediumSeaGreen;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(42, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 19);
            textBox3.TabIndex = 18;
            textBox3.Text = "Published Year :";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.MediumSeaGreen;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(46, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(89, 19);
            textBox4.TabIndex = 19;
            textBox4.Text = "AuthorID :";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.MediumSeaGreen;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(43, 130);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(52, 19);
            textBox5.TabIndex = 20;
            textBox5.Text = "Title :";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.MediumSeaGreen;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(32, 102);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 19);
            textBox6.TabIndex = 21;
            textBox6.Text = "Book ID";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.MediumSeaGreen;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(45, 283);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(52, 19);
            textBox7.TabIndex = 29;
            textBox7.Text = "ISBN :";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // bookidbtn
            // 
            bookidbtn.Location = new Point(192, 98);
            bookidbtn.Name = "bookidbtn";
            bookidbtn.Size = new Size(139, 23);
            bookidbtn.TabIndex = 30;
            // 
            // titlebtn
            // 
            titlebtn.Location = new Point(192, 130);
            titlebtn.Name = "titlebtn";
            titlebtn.Size = new Size(139, 23);
            titlebtn.TabIndex = 31;
            // 
            // authoridbtn
            // 
            authoridbtn.Location = new Point(192, 161);
            authoridbtn.Name = "authoridbtn";
            authoridbtn.Size = new Size(139, 23);
            authoridbtn.TabIndex = 32;
            // 
            // yearbtn
            // 
            yearbtn.Location = new Point(192, 190);
            yearbtn.Name = "yearbtn";
            yearbtn.Size = new Size(139, 23);
            yearbtn.TabIndex = 33;
            // 
            // publisherbtn
            // 
            publisherbtn.Location = new Point(192, 220);
            publisherbtn.Name = "publisherbtn";
            publisherbtn.Size = new Size(139, 23);
            publisherbtn.TabIndex = 34;
            // 
            // shelfbtn
            // 
            shelfbtn.Location = new Point(192, 251);
            shelfbtn.Name = "shelfbtn";
            shelfbtn.Size = new Size(139, 23);
            shelfbtn.TabIndex = 35;
            // 
            // isbnbtn
            // 
            isbnbtn.Location = new Point(192, 283);
            isbnbtn.Name = "isbnbtn";
            isbnbtn.Size = new Size(139, 23);
            isbnbtn.TabIndex = 36;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.DarkSeaGreen;
            searchbtn.BorderStyle = BorderStyle.FixedSingle;
            searchbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            searchbtn.Location = new Point(62, 367);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(81, 29);
            searchbtn.TabIndex = 37;
            searchbtn.Text = "Search";
            searchbtn.TextAlign = HorizontalAlignment.Center;
            // 
            // bckbtn
            // 
            bckbtn.BackColor = Color.DarkSeaGreen;
            bckbtn.BorderStyle = BorderStyle.FixedSingle;
            bckbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bckbtn.Location = new Point(139, 461);
            bckbtn.Name = "bckbtn";
            bckbtn.Size = new Size(81, 29);
            bckbtn.TabIndex = 39;
            bckbtn.Text = "Back";
            bckbtn.TextAlign = HorizontalAlignment.Center;
            // 
            // updtbtn
            // 
            updtbtn.BackColor = Color.DarkSeaGreen;
            updtbtn.BorderStyle = BorderStyle.FixedSingle;
            updtbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            updtbtn.Location = new Point(213, 413);
            updtbtn.Name = "updtbtn";
            updtbtn.Size = new Size(81, 29);
            updtbtn.TabIndex = 40;
            updtbtn.Text = "Update";
            updtbtn.TextAlign = HorizontalAlignment.Center;
            // 
            // dltbtn
            // 
            dltbtn.BackColor = Color.DarkSeaGreen;
            dltbtn.BorderStyle = BorderStyle.FixedSingle;
            dltbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dltbtn.Location = new Point(62, 413);
            dltbtn.Name = "dltbtn";
            dltbtn.Size = new Size(81, 29);
            dltbtn.TabIndex = 41;
            dltbtn.Text = "Delete";
            dltbtn.TextAlign = HorizontalAlignment.Center;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.DarkSeaGreen;
            addbtn.BorderStyle = BorderStyle.FixedSingle;
            addbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addbtn.Location = new Point(213, 367);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(81, 29);
            addbtn.TabIndex = 42;
            addbtn.Text = "Add";
            addbtn.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(369, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(618, 400);
            dataGridView1.TabIndex = 43;
            // 
            // BookInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1049, 527);
            Controls.Add(dataGridView1);
            Controls.Add(addbtn);
            Controls.Add(dltbtn);
            Controls.Add(updtbtn);
            Controls.Add(bckbtn);
            Controls.Add(searchbtn);
            Controls.Add(isbnbtn);
            Controls.Add(shelfbtn);
            Controls.Add(publisherbtn);
            Controls.Add(yearbtn);
            Controls.Add(authoridbtn);
            Controls.Add(titlebtn);
            Controls.Add(bookidbtn);
            Controls.Add(textBox7);
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
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookInfo";
            Text = "BookInfo";
            Load += BookInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private TextBox textBox7;
        private TextBox bookidbtn;
        private TextBox titlebtn;
        private TextBox authoridbtn;
        private TextBox yearbtn;
        private TextBox publisherbtn;
        private TextBox shelfbtn;
        private TextBox isbnbtn;
        private TextBox searchbtn;
        private TextBox bckbtn;
        private TextBox updtbtn;
        private TextBox dltbtn;
        private TextBox addbtn;
        private DataGridView dataGridView1;
    }
}