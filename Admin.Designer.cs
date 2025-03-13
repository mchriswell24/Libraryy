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
            records = new Button();
            button1 = new Button();
            authorbtn = new Button();
            Bookbtn = new Button();
            Bck = new Button();
            SuspendLayout();
            // 
            // records
            // 
            records.BackColor = Color.DarkSeaGreen;
            records.Location = new Point(67, 287);
            records.Name = "records";
            records.Size = new Size(193, 36);
            records.TabIndex = 8;
            records.Text = "BorrowingRecords";
            records.UseVisualStyleBackColor = false;
            records.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Location = new Point(317, 287);
            button1.Name = "button1";
            button1.Size = new Size(139, 36);
            button1.TabIndex = 9;
            button1.Text = "Member";
            button1.UseVisualStyleBackColor = false;
            // 
            // authorbtn
            // 
            authorbtn.BackColor = Color.DarkSeaGreen;
            authorbtn.Location = new Point(526, 287);
            authorbtn.Name = "authorbtn";
            authorbtn.Size = new Size(141, 36);
            authorbtn.TabIndex = 10;
            authorbtn.Text = "Author";
            authorbtn.UseVisualStyleBackColor = false;
            // 
            // Bookbtn
            // 
            Bookbtn.BackColor = Color.DarkSeaGreen;
            Bookbtn.Location = new Point(726, 287);
            Bookbtn.Name = "Bookbtn";
            Bookbtn.Size = new Size(124, 36);
            Bookbtn.TabIndex = 11;
            Bookbtn.Text = "Book";
            Bookbtn.UseVisualStyleBackColor = false;
            // 
            // Bck
            // 
            Bck.BackColor = Color.DarkSeaGreen;
            Bck.Location = new Point(448, 353);
            Bck.Name = "Bck";
            Bck.Size = new Size(92, 36);
            Bck.TabIndex = 12;
            Bck.Text = "Back";
            Bck.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(938, 543);
            Controls.Add(Bck);
            Controls.Add(Bookbtn);
            Controls.Add(authorbtn);
            Controls.Add(button1);
            Controls.Add(records);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "AdminForm";
            Text = "Admin";
            Load += AdminBtn_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button records;
        private Button button1;
        private Button authorbtn;
        private Button Bookbtn;
        private Button Bck;
    }
}