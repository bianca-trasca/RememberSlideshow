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
    public partial class SignUpForm : Form
    {
        SqliteConnection Conn = new SqliteConnection();
        SqliteCommand cmd = new SqliteCommand();

        public SignUpForm(SqliteConnection connection)
        {
            Conn = connection;
            InitializeComponent();
        }

        private void showPwSignUpFormCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPwSignUpFormCheckBox.Checked)
            {
                pwSignUpFormTextBox.PasswordChar = '\0';
                cnfPwSignUpFormTextBox.PasswordChar = '\0';
            }
            else
            {
                pwSignUpFormTextBox.PasswordChar = '●';
                cnfPwSignUpFormTextBox.PasswordChar = '●';
            }
        }

        private void signUpSignUpFormButton_Click(object sender, EventArgs e)
        {
            if (usrSignUpFormTextBox.Text.Equals("") || pwSignUpFormTextBox.Text.Equals(""))
            {
                MessageBox.Show("Username or password field is empty!", "Registration faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pwSignUpFormTextBox.Text.Equals(cnfPwSignUpFormTextBox.Text))
            {
                Conn.Open();

                string verification = $"select * from tbl_users where username = '{usrSignUpFormTextBox.Text}'";
                cmd = new SqliteCommand(verification, Conn);
                SqliteDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    MessageBox.Show("This username is already taken! Please try another one!", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string loginQuery = "INSERT INTO tbl_users VALUES ('" + usrSignUpFormTextBox.Text + "', '" + 
                        pwSignUpFormTextBox.Text + "')";
                    cmd = new SqliteCommand(loginQuery, Conn);
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    MessageBox.Show("Your account has been successfully created! Go back to login page an log in!", "Registration succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Passwords does not match!", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pwSignUpFormTextBox.Text = "";
                cnfPwSignUpFormTextBox.Text = "";
                pwSignUpFormTextBox.Focus();
            }
        }

        private void backSignUpFormLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new MainForm(Conn).Show();
            this.Hide();
        }
    }
}
