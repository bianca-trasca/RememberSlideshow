using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remember
{
    public partial class mainForm : Form
    {
        SqliteConnection Conn = new SqliteConnection();

        public mainForm(SqliteConnection connection)
        {
            Conn = connection;
            InitializeComponent();
        }

        SqliteCommand cmd = new SqliteCommand();

        private void logInMainFormButton_Click(object sender, EventArgs e)
        {
            if (usrMainFormTextBox.Text.Equals("") || pwMainFormTextBox.Text.Equals(""))
            {
                MessageBox.Show("Username or password field is empty", "Registration faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Conn.Open();
                string loginQuery = "Select * from tbl_users where username = '" + usrMainFormTextBox.Text + "' and password = '" + pwMainFormTextBox.Text + "'";
                cmd = new SqliteCommand(loginQuery, Conn);
                SqliteDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    new dashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again", "Login failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usrMainFormTextBox.Text = "";
                    pwMainFormTextBox.Text = "";
                    usrMainFormTextBox.Focus();
                }

            }
        }

        private void signUpMainFormButton_Click(object sender, EventArgs e)
        {
            new signUpForm(Conn).Show();
            this.Hide();
        }

        private void showPwMainFormCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPwMainFormCheckBox.Checked)
            {
                pwMainFormTextBox.PasswordChar = '\0';
            }
            else
            {
                pwMainFormTextBox.PasswordChar = '●';
            }
        }
    }
}
