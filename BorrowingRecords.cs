using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class BorrowingRecords : Form
    {
        public BorrowingRecords()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(); // Create an instance of AdminForm
            adminForm.Show(); // Show the AdminForm
            this.Close();
        }

        private void CreateBtn_TextChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Borrowing (RecordID, AuthorID, BookID, MemberID) VALUES (@BookTitle, @BorrowerName, @BorrowDate)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookTitle", txtBookTitle.Text);
                    cmd.Parameters.AddWithValue("@BorrowerName", txtBorrowerName.Text);
                    cmd.Parameters.AddWithValue("@BorrowDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Added Successfully!");
                }
            }
        }
        private void RetrieveBtn_TextChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Borrowing";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void UpdateBtn_TextChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Borrowing SET BookTitle = @BookTitle, BorrowerName = @BorrowerName WHERE ID = @ID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@BookTitle", txtBookTitle.Text);
                    cmd.Parameters.AddWithValue("@BorrowerName", txtBorrowerName.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully!");
                }
            }
        }
        

        private void BorrowingRecords_Load(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_TextChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Borrowing WHERE ID = @ID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully!");
                }
            }
        
    }
    }
}
