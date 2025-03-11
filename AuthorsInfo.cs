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
    public partial class AuthorInfo : Form
    {
        public AuthorInfo()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(); // Create an instance of AdminForm
            adminForm.Show(); // Show the AdminForm
            this.Close();
        }
    }
}
