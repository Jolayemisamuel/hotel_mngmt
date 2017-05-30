using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel
{
    public partial class LogIn : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;
        public LogIn()
        {
            InitializeComponent();

        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            conn = new MySqlConnection("SERVER=localhost;DATABASE=hotel;UID=root;PASSWORD=root;");
            if (!OpenConnection(ref conn))
            {
                MessageBox.Show("Error accessing server");
                Application.Exit();
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            try
            {
                cmd = new MySqlCommand("select emp_type from employees where user_name='"
                                        + UserName.Text + "' and password='" + Password.Text
                                        + "'", conn);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                if (!rdr.HasRows)
                {
                    MessageBox.Show("INVALID EMAIL/PASWORD. TRY AGAIN");
                    rdr.Close();
                }
                else
                {

                    UserName.ResetText();
                    Password.ResetText();

                    int isKitchen = rdr.GetInt32("emp_type");
                    rdr.Close();
                    this.Hide();
                    if (isKitchen == 1)
                    {
                        Kitchen n = new Kitchen(this, conn);
                        n.Show();
                    }
                    else
                    {
                        FrontDeskSwitcher n = new FrontDeskSwitcher(this, conn);
                        n.Show();
                    }
                }
            }
            catch (MySqlException x)
            {
                MessageBox.Show(x.ToString());
                rdr.Close();
            }
        }
        private bool OpenConnection(ref MySqlConnection connection)
        {
            try
            {
                connection.Open();
                return true;
            }

            catch (MySqlException ex)
            {
                var x = ex.ErrorCode;
                MessageBox.Show(x.ToString());
                connection.Close();
                return false;
            }
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the program?", "Hotel Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                // Cancel the Closing event
                e.Cancel = true;
            }
        }

        private void UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInButton_Click(sender, e);
            }

        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInButton_Click(sender, e);
            }
        }

        private void LogIn_Activated(object sender, EventArgs e)
        {
            UserName.Focus();
        }

        private void Password_MouseClick(object sender, MouseEventArgs e)
        {
            Password.Text = "";
        }

        private void UserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (UserName.Text == "User Name")
            {
                UserName.Text = "";
            }
        }
    }
}