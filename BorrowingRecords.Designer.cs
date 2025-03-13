namespace Library
{
    partial class BorrowingRecords
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
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            search = new Button();
            BACK = new Button();
            UPDATE = new Button();
            DELETE = new Button();
            ADD = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.MediumSeaGreen;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(55, 275);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(118, 19);
            textBox5.TabIndex = 35;
            textBox5.Text = "Return Date:";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MediumSeaGreen;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(55, 235);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 19);
            textBox1.TabIndex = 36;
            textBox1.Text = "Borrow Date:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MediumSeaGreen;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(55, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 19);
            textBox2.TabIndex = 37;
            textBox2.Text = "Book ID:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.MediumSeaGreen;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(55, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 19);
            textBox3.TabIndex = 38;
            textBox3.Text = "Record ID:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.MediumSeaGreen;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(55, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 19);
            textBox4.TabIndex = 39;
            textBox4.Text = "Member ID:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Honeydew;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(358, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(696, 587);
            dataGridView1.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(622, 29);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
            label1.TabIndex = 41;
            label1.Text = "Borrowing Records";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(218, 117);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 52;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(218, 156);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 53;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(218, 193);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 54;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(218, 231);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 55;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(218, 276);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 56;
            // 
            // search
            // 
            search.BackColor = Color.DarkSeaGreen;
            search.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            search.Location = new Point(71, 384);
            search.Name = "search";
            search.Size = new Size(86, 32);
            search.TabIndex = 57;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            // 
            // BACK
            // 
            BACK.BackColor = Color.DarkSeaGreen;
            BACK.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BACK.Location = new Point(143, 565);
            BACK.Name = "BACK";
            BACK.Size = new Size(86, 32);
            BACK.TabIndex = 58;
            BACK.Text = "Back";
            BACK.UseVisualStyleBackColor = false;
            // 
            // UPDATE
            // 
            UPDATE.BackColor = Color.DarkSeaGreen;
            UPDATE.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UPDATE.Location = new Point(200, 452);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(86, 32);
            UPDATE.TabIndex = 59;
            UPDATE.Text = "Update";
            UPDATE.UseVisualStyleBackColor = false;
            // 
            // DELETE
            // 
            DELETE.BackColor = Color.DarkSeaGreen;
            DELETE.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DELETE.Location = new Point(71, 452);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(86, 32);
            DELETE.TabIndex = 60;
            DELETE.Text = "Delete";
            DELETE.UseVisualStyleBackColor = false;
            // 
            // ADD
            // 
            ADD.BackColor = Color.DarkSeaGreen;
            ADD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ADD.Location = new Point(200, 384);
            ADD.Name = "ADD";
            ADD.Size = new Size(86, 32);
            ADD.TabIndex = 61;
            ADD.Text = "Add";
            ADD.UseVisualStyleBackColor = false;
            // 
            // BorrowingRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1259, 696);
            Controls.Add(ADD);
            Controls.Add(DELETE);
            Controls.Add(UPDATE);
            Controls.Add(BACK);
            Controls.Add(search);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrowingRecords";
            Text = "BorrowingRecords";
            Load += BorrowingRecords_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox DeleteBtn;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button search;
        private Button BACK;
        private Button UPDATE;
        private Button DELETE;
        private Button ADD;
    }
}