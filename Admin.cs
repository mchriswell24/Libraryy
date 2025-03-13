using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminBtn_Load(object sender, EventArgs e)
        {

        }

        private void AuthorBtn_Click(object sender, EventArgs e)
        {
            searchbtn authorInfoForm = new searchbtn();
            authorInfoForm.Show();
            this.Hide();
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            BookInfo bookInfoForm = new BookInfo();

            // Show the BookInfo form
            bookInfoForm.Show();
        }

        private void MembersBtn_Click(object sender, EventArgs e)
        {
            MembersInfocs membersForm = new MembersInfocs(); // Create an instance of MembersInfo form
            membersForm.Show(); // Show the MembersInfo form
            this.Hide();
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
