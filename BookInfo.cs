using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class BookInfo : Form
    {
        MySQLConnector mmm = new MySQLConnector();
        public BookInfo()
        {
            InitializeComponent();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(); // Create an instance of AdminForm
            adminForm.Show(); // Show the AdminForm
            this.Close();
        }

        private void BookInfo_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = mmm.FetchBooks();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
