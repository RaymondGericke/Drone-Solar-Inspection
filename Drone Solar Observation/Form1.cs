using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drone_Solar_Observation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();

            if (dataHandler.ConnectToDatabase())
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                if (dataHandler.CheckCredentials(username, password))
                {
                    // Credentials are valid, perform the appropriate action (e.g., open a new form)
                    //MessageBox.Show("Login successful!");
                    // Other operations
                    Form2 mainMenu = new Form2();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.");
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
