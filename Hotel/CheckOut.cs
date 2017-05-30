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
using System.Drawing.Printing;
namespace Hotel
{
    public partial class CheckOut : Form
    {
        private MySqlCommand cmd;
        private MySqlDataReader rdr;
        private MySqlConnection conn;
        private FrontDeskSwitcher globalForm;
        private double total = 0;
        private string time_out;
        private List<string> QueueOfOrders = new List<string>();
        private List<string> QueueOfItems = new List<string>();
        private List<Decimal> QueueOfPrices = new List<Decimal>();
        public CheckOut(FrontDeskSwitcher foms, MySqlConnection connection)
        {
            InitializeComponent();
            globalForm = foms;
            conn = connection;
            this.CenterToScreen();
            globalForm.Hide();
        }

        private void Rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodItems.Items.Clear();
            QueueOfItems.Clear();
            QueueOfOrders.Clear();
            QueueOfPrices.Clear();
            RmNum.Text = Rooms.Text;                    //gets roomNumber
            total = 0;
            DateTime time_in = DateTime.Today, today = DateTime.Today;
            //string RoomServiceCost = "";
            time_out = today.Year + "-";
            string record_num = "";
            if (today.Month < 10)
            {
                time_out += "0";
            }
            time_out += today.Month + "-";
            if (today.Day < 10)
            {
                time_out += "0";
            }
            time_out += today.Day;
            OutDay.Text = time_out;                     //gets out date

            cmd = new MySqlCommand("select record_num,name,time_in,price from records where room_num='" + Rooms.Text + "' and time_out='0000-00-00'", conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    record_num = (rdr.GetString("record_num"));
                    NameOfPerson.Text = (rdr.GetString("name")).ToUpper();
                    time_in = rdr.GetDateTime("time_in");
                    //RoomServiceCost = rdr.GetString("price");
                }
            }

            //RmSvMny.Text = String.Format("{0:C}", Convert.ToDecimal(RoomServiceCost));
            RecordNumber.Text = record_num;

            string CheckInTime = time_in.Year + "-";
            if (time_in.Month < 10)
            {
                CheckInTime += "0";
            }
            CheckInTime += today.Month + "-";
            if (time_in.Day < 10)
            {
                CheckInTime += "0";
            }
            CheckInTime += time_in.Day;
            InDay.Text = CheckInTime;

            System.TimeSpan diff2 = today - time_in;
            int diff = diff2.Days;
            DaysSpent.Text = diff.ToString();
            rdr.Close();

            cmd = new MySqlCommand("select ppn from rooms where room_num='" + Rooms.Text + "'", conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    PPN.Text = rdr.GetString("ppn");
                }

            }
            rdr.Close();

           


            cmd = new MySqlCommand("select order_num from orders where record_num='" + record_num + "'", conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    QueueOfOrders.Add(rdr[0].ToString());
                }
            }
            rdr.Close();

            for (int i = 0; i < QueueOfOrders.Count; i++)
            {
                cmd = new MySqlCommand("select item from order_items where order_num='" + QueueOfOrders[i] + "'", conn);
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        QueueOfItems.Add(rdr[0].ToString());
                    }

                }
                rdr.Close();
            }

            for (int j = 0; j < QueueOfItems.Count(); j++)
            {
                cmd = new MySqlCommand("select price from menu where item_name='" + QueueOfItems[j] + "'", conn);
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        QueueOfPrices.Add(rdr.GetDecimal(0));
                    }

                }
                rdr.Close();
            }
            decimal RoomServiceCost = 0;
            foreach (decimal item in QueueOfPrices)
            {
                RoomServiceCost += item;
            }
            for (int i = 0; i < QueueOfItems.Count; i++)
            {
                FoodItems.Items.Add((i + 1).ToString() + ") " + QueueOfItems[i] +
                                    " : " + String.Format("{0:C}", Convert.ToDecimal(QueueOfPrices[i])));
            }


            RmSvMny.Text = String.Format("{0:C}", RoomServiceCost);
            total = Convert.ToDouble(RoomServiceCost) + (Convert.ToDouble(PPN.Text) * Convert.ToDouble(diff));
            TotAmnt.Text = String.Format("{0:C}", Convert.ToDecimal(total));
            PPN.Text = String.Format("{0:C}", Convert.ToDecimal(PPN.Text));
        }


        private void CheckOut_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            UpdateRooms();
        }
        private void UpdateRooms()
        {
            Rooms.Items.Clear();
            cmd = new MySqlCommand("select room_num from rooms where vacant=0", conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Rooms.Items.Add(rdr[0].ToString());
                }
            }
            rdr.Close();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if (Rooms.SelectedItem != null)
            {
                //updating orders if there are any 
                //worked without the and finshed = 0 but i figured to not change more than we need
                cmd = new MySqlCommand("UPDATE orders SET finished='1' WHERE record_num='"
                                        + RecordNumber.Text + "' and finished='0'", conn);
                cmd.ExecuteNonQuery();

                //updating records to show the new price and day out
                cmd = new MySqlCommand("UPDATE records SET time_out='" + OutDay.Text + "', price='"
                                        + total + "' WHERE record_num='" + RecordNumber.Text + "'", conn);
                int te = cmd.ExecuteNonQuery();
                if (te < 1)
                {
                    MessageBox.Show("ERROR IN UPDATING FINAL RECORD");
                }

                cmd = new MySqlCommand("UPDATE rooms SET vacant=1 WHERE room_num='" + Rooms.Text + "'", conn);
                te = cmd.ExecuteNonQuery();
                if (te < 1)
                {
                    MessageBox.Show("ERROR IN UPDATING FINAL RECORD");
                }


                //UPDATING FEILDS TO ORIGIONAL
                FoodItems.Items.Clear();        //emptying food items
                QueueOfItems.Clear();
                QueueOfOrders.Clear();
                QueueOfPrices.Clear();
                RmNum.Text = "Number";          //updating room number label
                UpdateRooms();                  //updating list of rooms open
                Rooms.Text = "Rooms";
                TotAmnt.Text = "$$$";
                RmSvMny.Text = "$$$";
                PPN.Text = "$$$";
                DaysSpent.Text = "Days";
                OutDay.Text = "Day";
                InDay.Text = "Day";
                RmNum.Text = "Number";
                RecordNumber.Text = "Number";
                NameOfPerson.Text = "Name";
                total = 0;
            }
        }
        private void CheckOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            globalForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (Rooms.SelectedItem != null)
            {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument; //add the document to the dialog box...        

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
                MessageBox.Show("Reciept has been printed.");

            }
            else
            {
                MessageBox.Show("ERROR PRINTING RECIPT.");
            }
            }
            else
            {
                MessageBox.Show("No room selected to print recipt for!");
            }
        }
        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
                //this prints the reciept
                string last4Credit="";
                cmd = new MySqlCommand("select right(cc_num,4) from records where record_num='" + RecordNumber.Text + "'", conn);
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        last4Credit=rdr[0].ToString();
                    }
                }
                rdr.Close();

                string CreditCard = "****-****-****-" + last4Credit;


                Graphics graphic = e.Graphics;

                Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up

                float fontHeight = font.GetHeight();

                int startX = 10;
                int startY = 10;
                int offset = 40;

                graphic.DrawString(" The Best Hotel You Have Ever Stayed At!", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
                string top = "Item Name".PadRight(30) + "Price";
                graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight; //make the spacing consistent
                graphic.DrawString("------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5; //make the spacing consistent


                for (int i=0; i<QueueOfItems.Count; i++)
                {
                    graphic.DrawString(QueueOfItems[i].PadRight(30) + String.Format("{0:C}",QueueOfPrices[i]), 
                                        new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }



                //when we have drawn all of the items add the total

                offset = offset + 20; //make some room so that the total stands out.

                graphic.DrawString("Room Service Cost ".PadRight(30) + RmSvMny.Text, new Font("Courier New", 12, FontStyle.Bold), 
                                    new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + 30; //make some room so that the total stands out.
                graphic.DrawString("Customer Name ".PadRight(30) + NameOfPerson.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 15;
                graphic.DrawString("Room Number ".PadRight(30) + RmNum.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 15;
                graphic.DrawString("Price Per Night".PadRight(30) + PPN.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 15;
                graphic.DrawString("Total Nights Stayed ".PadRight(30) + DaysSpent.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 15;
                graphic.DrawString("Check In Day".PadRight(30) + InDay.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 15;
                graphic.DrawString("Check Out Day".PadRight(30) + OutDay.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 15;
               
                offset = offset + 30; //make some room so that the total stands out.
                
                //show last 4 of credit here
                graphic.DrawString("Total Cost of Stay".PadRight(30) + TotAmnt.Text, new Font("Courier New", 12, FontStyle.Bold),
                                   new SolidBrush(Color.Red), startX, startY + offset);
                offset = offset + 30;
                graphic.DrawString("Charge to Credit Card: "+CreditCard, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 90;
                graphic.DrawString("Sign Here X_______________________________________", font, new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + 30; //make some room so that the total stands out.
                graphic.DrawString("     Thank-you for your patronage,", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 15;
                graphic.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 40;

        }

        private void FoodItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void recipt_Enter(object sender, EventArgs e)
        {

        }
    }
}
