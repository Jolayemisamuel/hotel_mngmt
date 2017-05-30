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
    public partial class CheckInWindow : Form
    {

        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;

        private Form globalForm;

        public CheckInWindow(FrontDeskSwitcher form, MySqlConnection connection)
        {
            globalForm = form;
            InitializeComponent();
            form.Hide();
            conn = connection;      //which is already set up and connected to the server/db
        }

        private void ReturnToPrevScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckInWindow_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            AvailRoom.Items.Clear();
            cmd = new MySqlCommand("select beds from rooms group by beds", conn);
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Beds.Items.Add(rdr.GetString("beds"));
                }
            }

            rdr.Close();

            cmd = new MySqlCommand("select baths from rooms group by baths", conn);

            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Baths.Items.Add(rdr.GetString("baths"));
                }
            }
            rdr.Close();
        }

        private void GetAvailRooms_Click(object sender, EventArgs e)
        {
            AvailRoom.Items.Clear();
            cmd = new MySqlCommand("select room_num, ppn from rooms where vacant=1 and beds='" + Beds.Text +
                                    "' and baths='" + Baths.Text + "' and balcony='" + Convert.ToInt32(Balcony.Checked).ToString() +
                                    "' and oceanV='" + Convert.ToInt32(OceanView.Checked).ToString() + "' and suite='" +
                                    Convert.ToInt32(Suite.Checked).ToString() + "'", conn);
           
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                    AvailRoom.Items.Add("Rm: " + rdr.GetString("room_num") + "   :   " 
                                        + String.Format("Price: {0:C}", rdr.GetDouble("ppn")));
            }

            if (AvailRoom.Items.Count <1) 
            {
                AvailRoom.Text = "Available Rooms";
            }
            rdr.Close();
            if (AvailRoom.Items.Count>0)
                AvailRoom.DroppedDown = true;
        }

        private void CheckInWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            globalForm.Show();
        }

        private void CheckInRoom_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime year_cc = DateTime.Now;
                string date = ExpDate.Text;
                int CCm=0, CCy=0;
                if (date.Length==7){
                string[] newdate = new string[2];
                newdate = date.Split('/');
                CCm = Convert.ToInt32(newdate[0]);
                CCy = Convert.ToInt32(newdate[1]);
                }
                string missing = string.Empty;
                if (PerName.Text == string.Empty)
                    missing += "Invalid Name.\n";
                if (CreditNum.Text == string.Empty || CreditNum.Text.Length < 19)
                    missing += "Invalid Credit Card Number.\n";
                if (ExpDate.Text == string.Empty || ExpDate.Text.Length < 7)
                    missing += "Invalid Experation Date.\n";
                if (AvailRoom.SelectedItem == null)
                    missing += "Please Select a Room.\n";
                
                if ( CCm < 1 || CCm > 12 )
                {
                    missing += "Please Select a Valid Experation Month.\n";
                }
                if ( CCy < year_cc.Year || CCy > year_cc.Year+3 )
                {
                    missing += "Please Select a Valid Experation Year.\n";
                }
                if (missing != string.Empty)
                {
                    MessageBox.Show(missing);
                    missing = string.Empty;
                }
                else
                {
                    string test = AvailRoom.SelectedItem.ToString();
                    string roomNum = "";
                    for (int i = 4; test[i] != ' '; i++)
                    {
                        roomNum += test[i].ToString();
                    }
                    DateTime time_in = DateTime.Now;
                    string formatedTime = time_in.Year + "-";
                    if (time_in.Month < 10)
                    {
                        formatedTime += "0";
                    }
                    formatedTime += time_in.Month + "-";
                    if (time_in.Day < 10)
                    {
                        formatedTime += "0";
                    }
                    formatedTime += time_in.Day;

                    cmd = new MySqlCommand("insert into records (name,cc_num,exp_date,room_num,time_in) values('" +
                                            PerName.Text + "','" + CreditNum.Text + "','" + ExpDate.Text + "','" + roomNum
                                            + "','" + formatedTime + "')", conn);
                    int numRowsAffect = cmd.ExecuteNonQuery();
                    if (numRowsAffect <= 0)
                    {
                        MessageBox.Show("Error in adding stay.");
                    }
                    else
                    {
                        MessageBox.Show("Checked In.");
                        cmd = new MySqlCommand("update rooms set vacant=0 where room_num='" + roomNum + "'", conn);
                        numRowsAffect = cmd.ExecuteNonQuery();
                        if (numRowsAffect <= 0)
                        {
                            MessageBox.Show("Error in adding stay.");
                        }
                    }
                    AvailRoom.Items.Clear();
                    AvailRoom.Text = "Available Rooms";
                    Beds.Text = "Beds";
                    Baths.Text = "baths";
                    OceanView.Checked = false;
                    Balcony.Checked = false;
                    Suite.Checked = false;
                }
                }
            catch (MySqlException eq)
            {
                MessageBox.Show(eq.ToString());
            }
        }

        private void AvailRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string test = AvailRoom.SelectedItem.ToString();
                string roomNum = string.Empty;
                for (int i = 4; test[i] != ' '; i++)
                {
                    roomNum += test[i].ToString();
                }
                RmNum.Text = roomNum;

                cmd = new MySqlCommand("select * from rooms where room_num='" + roomNum + "'", conn);
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();

                    Beds.Text = rdr.GetString("beds");
                    Baths.Text = rdr.GetString("baths");
                    OceanView.Checked = rdr.GetBoolean("oceanv");
                    Balcony.Checked = rdr.GetBoolean("balcony");
                    Suite.Checked = rdr.GetBoolean("suite");

                }
                else
                {
                    AvailRoom.Text = "Available Rooms.";
                }
                rdr.Close();
            }
            catch (MySqlException ssx)
            {
                MessageBox.Show(ssx.ToString());
            }
        }
        private void PerName_MouseClick(object sender, MouseEventArgs e)
        {
            PerName.SelectionStart = PerName.Text.Length;
        }

        private void CreditNum_MouseClick(object sender, MouseEventArgs e)
        {
            CreditNum.SelectionStart = 0;
        }

        private void ExpDate_MouseClick(object sender, MouseEventArgs e)
        {
            ExpDate.SelectionStart = 0;
        }

        private void ShowAllOpen_Click(object sender, EventArgs e)
        {
            AvailRoom.Items.Clear();
            cmd = new MySqlCommand("select room_num, ppn from rooms where vacant=1", conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    AvailRoom.Items.Add("Rm: " + rdr.GetString("room_num") +"   :   " + 
                                        String.Format("Price: {0:C}", rdr.GetDouble("ppn")));
                }
            }
            rdr.Close();
            if (AvailRoom.Items.Count>0)
                AvailRoom.DroppedDown = true;
        }
    }
}
