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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "MC" && PasswordTxt.Text == "amlv08")
            {
                MessageBox.Show("Login successful!", "Success");

                // Ensure that AdminForm exists and is correctly referenced
                AdminForm adminForm = new AdminForm(); // Change from AdminBtn to AdminForm if needed
                adminForm.Show();

                // Hide the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
