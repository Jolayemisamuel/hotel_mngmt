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
    public partial class Kitchen : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;
        List<string> FoodItems = new List<string>();
        LinkedList<string> Description = new LinkedList<string>();
        List<double> Price = new List<double>();
        List<string> Quantity = new List<string>();     //to get at index
        double totalPrice=0.0;
        LogIn globalForm;
        FrontDeskSwitcher frontGlobalForm;
        private bool isKitchen;

        public Kitchen(LogIn global, MySqlConnection connection)
        {
            isKitchen = true;
            InitializeComponent();
            globalForm = global;
            conn = connection;
            globalForm.Hide();
            FinishOrder.Enabled = true;
            KitchenNote.Visible = false;
        }
        public Kitchen(FrontDeskSwitcher global, MySqlConnection connection)
        {
            isKitchen = false;
            InitializeComponent();
            frontGlobalForm = global;
            conn = connection;
            frontGlobalForm.Hide();
            FinishOrder.Enabled = false;
            KitchenNote.Visible = true;
            this.CenterToScreen();
            IsEdit.Visible = false;
        }
        private void Kitchen_Load(object sender, EventArgs e)
        {
            TotPrice.Text ="Total Price: "+ String.Format("{0:C}", totalPrice);
            MenuItems.Items.Clear();
            FoodItems.Clear();              //check if we need these
            Description.Clear();            //check if we need these
            Price.Clear();                  //check if we need these
            cmd = new MySqlCommand("select * from menu", conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    FoodItems.Add(rdr.GetString("item_name"));
                    Description.AddLast(rdr.GetString("description"));
                    Price.Add(rdr.GetDouble("price"));
                    MenuItems.Items.Add(rdr.GetString("item_name") + " : " + String.Format("{0:C}", rdr.GetDouble("price")));
                }
            }
            rdr.Close();
            cmd = new MySqlCommand("select room_num from rooms where vacant=0", conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    OpenRooms.Items.Add(rdr[0].ToString());
                }
            }
            rdr.Close();
        }
        private void Kitchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isKitchen)
                globalForm.Show();
            else
                frontGlobalForm.Show();
        }

        private void BackToLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescriptionOrder.Text = Description.ElementAt(MenuItems.SelectedIndex);
            
        }



        private void AddToOrder_Click(object sender, EventArgs e)
        {
 
            if (MenuItems.SelectedItem == null)
            {
                MessageBox.Show("No item selected to add to order.");
                MenuItems.Text = "Menu Items";
            }
            else
            {
                for (decimal i = QuantityItems.Value; i>0; i--)
                {
                    int indexOfItem = MenuItems.SelectedIndex;
                    //maybe i need a check here
                    OpenOrderItems.Items.Add(FoodItems[indexOfItem]);
                    totalPrice += Price[indexOfItem];
                    TotPrice.Text = "Total Price: " + String.Format("{0:C}", totalPrice);
                }
                QuantityItems.Value = 1;
            }
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            for ( i = 0; i < OpenOrderItems.Items.Count; i++)
            {
                if (!OpenOrderItems.GetItemChecked(i))
                {
                    OpenOrderItems.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        private void DeSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OpenOrderItems.Items.Count; i++)
            {
                if (OpenOrderItems.GetItemChecked(i))
                {
                    OpenOrderItems.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {

            while (OpenOrderItems.CheckedIndices.Count > 0)
            {
                for (int i = 0; i < OpenOrderItems.CheckedIndices.Count; i++)
                {
                    int index = OpenOrderItems.CheckedIndices[i];
                    int foodListNumber = FoodItems.FindIndex(x => x == Convert.ToString(OpenOrderItems.Items[index]));
                    totalPrice -= Price[foodListNumber];
                    TotPrice.Text = "Total Price: " + String.Format("{0:C}", totalPrice);
                    OpenOrderItems.Items.RemoveAt(index);
                }
            }
        }

        private void MenuItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddToOrder_Click(sender, e);
            }
        }

        

        private void ChefFinishOrder_Click(object sender, EventArgs e)
        {
            if (ChefOpenOrders.SelectedItem != null)
            {

                //calculate price
                double priceprice = 0;
                int index = 0;
                for (int i=0; i<ChefItems.Items.Count; i++){
                    index = FoodItems.FindIndex(x => x == ChefItems.Items[i].ToString());
                    priceprice += Price[index];
                }
                //get record num from order_num from orders
                string recordNum = "";
                cmd = new MySqlCommand("SELECT record_num FROM orders where order_num='" 
                                        + ChefOpenOrders.Text + "'", conn);
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        recordNum=(rdr[0].ToString());
                    }
                }

                rdr.Close();
                double Foodprice =0.0;
                cmd = new MySqlCommand("select price from records where record_num='"
                                        + recordNum + "' and time_out='0000-00-00'", conn);
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Foodprice = (rdr.GetDouble(0));
                    }
                }
                rdr.Close();
                Foodprice += priceprice;

                cmd = new MySqlCommand("update records set price=" + Foodprice.ToString() +
                                        " where record_num='" + recordNum + "' and time_out='0000-00-00'", conn);
                //maybe i should get rid of the check?
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected < 1)
                {
                    MessageBox.Show("error threat level alpha");
                }

                cmd = new MySqlCommand("update orders set finished='1' where order_num='" + ChefOpenOrders.Text + "'", conn);
                rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected < 1)
                {
                    MessageBox.Show("error threat level beta");
                }




                //---------------------------------------------------ignore this
                //update the list
                ChefOpenOrders.Items.Clear();
                cmd = new MySqlCommand("SELECT order_num FROM orders where finished=0", conn);
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ChefOpenOrders.Items.Add(rdr[0].ToString());
                    }
                }
                rdr.Close();
                MessageBox.Show("Order finished, send to customer.");
            }

            ChefItems.Items.Clear();
        }

        private void FinishOrder_Enter(object sender, EventArgs e)
        {
            ChefOpenOrders.Items.Clear();
            ChefItems.Items.Clear();
            RoomOfOrder.Text = "Room";
           
            cmd = new MySqlCommand("SELECT order_num FROM orders where finished=0", conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    ChefOpenOrders.Items.Add(rdr[0].ToString());
                }
            }
            rdr.Close();

        }

        private void ChefOpenOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChefItems.Items.Clear();
            string orderNum = ChefOpenOrders.Text;
            cmd = new MySqlCommand("select * from order_items where order_num='" + orderNum + "'", conn);
            rdr = cmd.ExecuteReader();
            string temp = "";
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    temp = rdr.GetString("item");
                    ChefItems.Items.Add(temp);
                }
            }
            rdr.Close();
                                    //check that
            cmd = new MySqlCommand("select room_num from orders where order_num='" 
                                    + orderNum + "' and finished =0", conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    RoomOfOrder.Text = rdr.GetString("room_num");
                    
                }
            }
            rdr.Close();
        }
        private void OpenRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalPrice = 0;
            TotPrice.Text = "Total Price: " + String.Format("{0:C}", totalPrice);
            IsEdit.Visible = false;
            OpenOrderItems.Items.Clear();
            //if room room has an open order,
            cmd = new MySqlCommand("select order_num from orders where finished=0 and room_num="+ OpenRooms.Text , conn);
            rdr = cmd.ExecuteReader();
            string order_num = "";
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    order_num = rdr.GetString(0);
                }
            }
            rdr.Close();
            if (order_num != "")
            {
                totalPrice = 0;
                TotPrice.Text = "Total Price: " + String.Format("{0:C}", totalPrice);
                IsEdit.Visible = true;
                cmd = new MySqlCommand("select * from order_items where order_num='" + order_num + "'", conn);
                rdr = cmd.ExecuteReader();
                string temp = "";
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        temp = rdr.GetString("item");
                        OpenOrderItems.Items.Add(temp);
                        int foodListNumber = FoodItems.FindIndex(x => x == temp);
                        totalPrice += Price[foodListNumber];
                        
                    }
                }
                TotPrice.Text = "Total Price: " + String.Format("{0:C}", totalPrice);
                rdr.Close();
            }
        }

        private void SendOutOrder_Click(object sender, EventArgs e)
        {
            if (OpenRooms.SelectedItem == null || OpenOrderItems.Items.Count < 1)
            {
                MessageBox.Show("You didn't add an item to the list!\nMaybe you are looking to cancel your order.\nThere is a button for that!");
            }


            else
            {
                cmd = new MySqlCommand("SELECT record_num FROM hotel.records where time_out='0000-00-00' and room_num='" + OpenRooms.Text + "'", conn);
                rdr = cmd.ExecuteReader();
                string record_num = "";
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        record_num = rdr.GetString(0);
                    }
                }
                rdr.Close();

                if (!IsEdit.Visible)
                {
                    //diff-----------------------
                    cmd = new MySqlCommand("insert into orders (room_num,record_num,finished) values('" +
                                            OpenRooms.Text + "','" + record_num + "', 0)", conn);
                    cmd.ExecuteNonQuery();
                    //diff-----------------------
                }
                cmd = new MySqlCommand("select order_num from orders where room_num='"+ OpenRooms.Text + 
                                        "' and record_num='" + record_num+ "' and finished='0'", conn);
                rdr = cmd.ExecuteReader();
                string order_num = "";
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        order_num = rdr[(0)].ToString();
                    }
                }
                rdr.Close();
                if (IsEdit.Visible)
                {
                    cmd = new MySqlCommand("delete from order_items where order_num='" + order_num + "'", conn);
                    cmd.ExecuteNonQuery();
                }

                foreach (string item in OpenOrderItems.Items)
                {
                    cmd = new MySqlCommand("insert into order_items (order_num,item) values('" + order_num + "','" + item + "')", conn);
                    cmd.ExecuteNonQuery();
                }

                if (!IsEdit.Visible) 
                    MessageBox.Show("Order sent to kitchen!");
                else
                    MessageBox.Show("Updated order sent to kitchen.");
                OpenOrderItems.Items.Clear();
                OpenRooms.Text = "";
                MenuItems.Text = "Menu Items";
            }
            this.Update();
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            if (OpenRooms.SelectedItem != null)
            {
                cmd = new MySqlCommand("select order_num from orders where room_num=" + OpenRooms.Text + " and finished=0", conn);
                //back to checkout
                rdr = cmd.ExecuteReader();
                string order_num = "";
                if (!rdr.HasRows)
                {
                    MessageBox.Show("There are no orders to cancel under this room");
                    rdr.Close();
                }
                else
                {
                    while (rdr.Read())
                    {
                        order_num = rdr.GetString(0);
                    }

                    rdr.Close();
                    //lol same thing
                    cmd = new MySqlCommand("delete from orders where room_num=" + OpenRooms.Text + " and finished=0", conn);
                    int numRowsAffected = cmd.ExecuteNonQuery();
                    if (numRowsAffected < 1)
                    {
                        MessageBox.Show("threat level midnight");
                    }
                    else
                    {
                        cmd = new MySqlCommand("delete from order_items where order_num=" + order_num, conn);
                        cmd.ExecuteNonQuery();
                        if (numRowsAffected < 1)
                        {
                            MessageBox.Show("threat level five o'clock");
                        }
                        OpenOrderItems.Items.Clear();   //why doesnt this work?
                        OpenRooms.Text = "";
                        IsEdit.Visible = false;
                    }
                }
            }
        }

        private void AddFood_Enter(object sender, EventArgs e)
        {
            IsEdit.Visible = false;
            DescriptionOrder.Text = "Descrition";
            OpenOrderItems.Items.Clear();
            MenuItems.Text = "Menu Items";
            OpenRooms.Text = "";
            QuantityItems.Value = 1;
            TotPrice.Text = "Total Price: ";
        }
    }
}
