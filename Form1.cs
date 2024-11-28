using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystemFinals
{
    public partial class Form1 : Form
    {

        private Dictionary<string, string> userCredentials = new Dictionary<string, string>
        {
           { "user1", "password1" },
           { "user2", "password2" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (userCredentials.ContainsKey(username) && userCredentials[username] == password)
            {
                MessageBox.Show("Login successful!");
                this.Hide(); 
                VotingForm votingForm = new VotingForm();
                votingForm.Show(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
