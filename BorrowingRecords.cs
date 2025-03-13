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
            
            }
        
        private void RetrieveBtn_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void UpdateBtn_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void BorrowingRecords_Load(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_TextChanged(object sender, EventArgs e)
        {
            
        
    }
    }
}
