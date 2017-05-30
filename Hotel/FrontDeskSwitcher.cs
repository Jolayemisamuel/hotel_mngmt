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
    public partial class FrontDeskSwitcher : Form
    {
        private Form globalForm;
        private MySqlConnection conn;

        public FrontDeskSwitcher(LogIn form, MySqlConnection connection)
        {

            InitializeComponent();
            
            form.Hide();
            conn = connection;
            globalForm = form;
           
        }

        private void LogOut_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void FrontDeskSwitcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            globalForm.Show();
        }

        private void CheckIn_Click(object sender, EventArgs e)
        {
            CheckInWindow n = new CheckInWindow(this, conn);
            n.Show();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            CheckOut m = new CheckOut(this, conn);
            m.Show();
        }

        private void FrontDeskSwitcher_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void RoomService_Click(object sender, EventArgs e)
        {
            Kitchen m = new Kitchen(this, conn);
            m.Show();
        }
    }
}