namespace Hotel
{
    partial class Kitchen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitchen));
            this.BackToLogIn = new System.Windows.Forms.Button();
            this.FinishOrder = new System.Windows.Forms.TabPage();
            this.RoomOfOrder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChefItems = new System.Windows.Forms.ListBox();
            this.ChefOpenOrders = new System.Windows.Forms.ComboBox();
            this.ChefFinishOrder = new System.Windows.Forms.Button();
            this.KitchenNote = new System.Windows.Forms.Label();
            this.AddFood = new System.Windows.Forms.TabPage();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.IsEdit = new System.Windows.Forms.Label();
            this.DeSelect = new System.Windows.Forms.Button();
            this.OpenRooms = new System.Windows.Forms.ComboBox();
            this.SendOutOrder = new System.Windows.Forms.Button();
            this.TotPrice = new System.Windows.Forms.TextBox();
            this.SelectAll = new System.Windows.Forms.Button();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.AddToOrder = new System.Windows.Forms.Button();
            this.OpenOrderItems = new System.Windows.Forms.CheckedListBox();
            this.RoomNumber = new System.Windows.Forms.Label();
            this.QuantityItems = new System.Windows.Forms.NumericUpDown();
            this.MenuItems = new System.Windows.Forms.ComboBox();
            this.DescriptionOrder = new System.Windows.Forms.TextBox();
            this.KitchenSwitcher = new System.Windows.Forms.TabControl();
            this.FinishOrder.SuspendLayout();
            this.AddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityItems)).BeginInit();
            this.KitchenSwitcher.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackToLogIn
            // 
            this.BackToLogIn.Location = new System.Drawing.Point(8, 373);
            this.BackToLogIn.Name = "BackToLogIn";
            this.BackToLogIn.Size = new System.Drawing.Size(456, 50);
            this.BackToLogIn.TabIndex = 2;
            this.BackToLogIn.Text = "Back To Log In";
            this.BackToLogIn.UseVisualStyleBackColor = true;
            this.BackToLogIn.Click += new System.EventHandler(this.BackToLogIn_Click);
            // 
            // FinishOrder
            // 
            this.FinishOrder.Controls.Add(this.RoomOfOrder);
            this.FinishOrder.Controls.Add(this.label3);
            this.FinishOrder.Controls.Add(this.label2);
            this.FinishOrder.Controls.Add(this.ChefItems);
            this.FinishOrder.Controls.Add(this.ChefOpenOrders);
            this.FinishOrder.Controls.Add(this.ChefFinishOrder);
            this.FinishOrder.Controls.Add(this.KitchenNote);
            this.FinishOrder.Location = new System.Drawing.Point(4, 22);
            this.FinishOrder.Name = "FinishOrder";
            this.FinishOrder.Padding = new System.Windows.Forms.Padding(3);
            this.FinishOrder.Size = new System.Drawing.Size(448, 329);
            this.FinishOrder.TabIndex = 2;
            this.FinishOrder.Text = "Finish Order";
            this.FinishOrder.UseVisualStyleBackColor = true;
            this.FinishOrder.Enter += new System.EventHandler(this.FinishOrder_Enter);
            // 
            // RoomOfOrder
            // 
            this.RoomOfOrder.AutoSize = true;
            this.RoomOfOrder.Location = new System.Drawing.Point(400, 29);
            this.RoomOfOrder.Name = "RoomOfOrder";
            this.RoomOfOrder.Size = new System.Drawing.Size(35, 13);
            this.RoomOfOrder.TabIndex = 7;
            this.RoomOfOrder.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "in Room Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Open Orders: ";
            // 
            // ChefItems
            // 
            this.ChefItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChefItems.FormattingEnabled = true;
            this.ChefItems.ItemHeight = 25;
            this.ChefItems.Location = new System.Drawing.Point(9, 63);
            this.ChefItems.Name = "ChefItems";
            this.ChefItems.Size = new System.Drawing.Size(426, 104);
            this.ChefItems.TabIndex = 4;
            // 
            // ChefOpenOrders
            // 
            this.ChefOpenOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChefOpenOrders.FormattingEnabled = true;
            this.ChefOpenOrders.Location = new System.Drawing.Point(110, 26);
            this.ChefOpenOrders.Name = "ChefOpenOrders";
            this.ChefOpenOrders.Size = new System.Drawing.Size(121, 21);
            this.ChefOpenOrders.TabIndex = 3;
            this.ChefOpenOrders.SelectedIndexChanged += new System.EventHandler(this.ChefOpenOrders_SelectedIndexChanged);
            // 
            // ChefFinishOrder
            // 
            this.ChefFinishOrder.Location = new System.Drawing.Point(9, 215);
            this.ChefFinishOrder.Name = "ChefFinishOrder";
            this.ChefFinishOrder.Size = new System.Drawing.Size(426, 78);
            this.ChefFinishOrder.TabIndex = 2;
            this.ChefFinishOrder.Text = "Finish Order";
            this.ChefFinishOrder.UseVisualStyleBackColor = true;
            this.ChefFinishOrder.Click += new System.EventHandler(this.ChefFinishOrder_Click);
            // 
            // KitchenNote
            // 
            this.KitchenNote.AutoSize = true;
            this.KitchenNote.Location = new System.Drawing.Point(6, 3);
            this.KitchenNote.Name = "KitchenNote";
            this.KitchenNote.Size = new System.Drawing.Size(210, 13);
            this.KitchenNote.TabIndex = 0;
            this.KitchenNote.Text = "Only The Kitchen Staff Can Finish an Order";
            // 
            // AddFood
            // 
            this.AddFood.Controls.Add(this.CancelOrder);
            this.AddFood.Controls.Add(this.IsEdit);
            this.AddFood.Controls.Add(this.DeSelect);
            this.AddFood.Controls.Add(this.OpenRooms);
            this.AddFood.Controls.Add(this.SendOutOrder);
            this.AddFood.Controls.Add(this.TotPrice);
            this.AddFood.Controls.Add(this.SelectAll);
            this.AddFood.Controls.Add(this.RemoveItem);
            this.AddFood.Controls.Add(this.AddToOrder);
            this.AddFood.Controls.Add(this.OpenOrderItems);
            this.AddFood.Controls.Add(this.RoomNumber);
            this.AddFood.Controls.Add(this.QuantityItems);
            this.AddFood.Controls.Add(this.MenuItems);
            this.AddFood.Controls.Add(this.DescriptionOrder);
            this.AddFood.Location = new System.Drawing.Point(4, 22);
            this.AddFood.Name = "AddFood";
            this.AddFood.Padding = new System.Windows.Forms.Padding(3);
            this.AddFood.Size = new System.Drawing.Size(448, 329);
            this.AddFood.TabIndex = 0;
            this.AddFood.Text = "Add Order";
            this.AddFood.UseVisualStyleBackColor = true;
            this.AddFood.Enter += new System.EventHandler(this.AddFood_Enter);
            // 
            // CancelOrder
            // 
            this.CancelOrder.Location = new System.Drawing.Point(342, 255);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(100, 31);
            this.CancelOrder.TabIndex = 18;
            this.CancelOrder.Text = "Cancel Order";
            this.CancelOrder.UseVisualStyleBackColor = true;
            this.CancelOrder.Click += new System.EventHandler(this.CancelOrder_Click);
            // 
            // IsEdit
            // 
            this.IsEdit.AutoSize = true;
            this.IsEdit.Location = new System.Drawing.Point(6, 243);
            this.IsEdit.Name = "IsEdit";
            this.IsEdit.Size = new System.Drawing.Size(234, 13);
            this.IsEdit.TabIndex = 14;
            this.IsEdit.Text = "This room has an open order. Now editing order.";
            this.IsEdit.Visible = false;
            // 
            // DeSelect
            // 
            this.DeSelect.Location = new System.Drawing.Point(6, 298);
            this.DeSelect.Name = "DeSelect";
            this.DeSelect.Size = new System.Drawing.Size(76, 25);
            this.DeSelect.TabIndex = 6;
            this.DeSelect.Text = "Deselect All";
            this.DeSelect.UseVisualStyleBackColor = true;
            this.DeSelect.Click += new System.EventHandler(this.DeSelect_Click);
            // 
            // OpenRooms
            // 
            this.OpenRooms.FormatString = "N0";
            this.OpenRooms.FormattingEnabled = true;
            this.OpenRooms.Location = new System.Drawing.Point(93, 9);
            this.OpenRooms.Name = "OpenRooms";
            this.OpenRooms.Size = new System.Drawing.Size(123, 21);
            this.OpenRooms.TabIndex = 1;
            this.OpenRooms.SelectedIndexChanged += new System.EventHandler(this.OpenRooms_SelectedIndexChanged);
            // 
            // SendOutOrder
            // 
            this.SendOutOrder.Location = new System.Drawing.Point(342, 292);
            this.SendOutOrder.Name = "SendOutOrder";
            this.SendOutOrder.Size = new System.Drawing.Size(100, 31);
            this.SendOutOrder.TabIndex = 5;
            this.SendOutOrder.Text = "Send Out Order";
            this.SendOutOrder.UseVisualStyleBackColor = true;
            this.SendOutOrder.Click += new System.EventHandler(this.SendOutOrder_Click);
            // 
            // TotPrice
            // 
            this.TotPrice.Location = new System.Drawing.Point(88, 267);
            this.TotPrice.Name = "TotPrice";
            this.TotPrice.ReadOnly = true;
            this.TotPrice.Size = new System.Drawing.Size(123, 20);
            this.TotPrice.TabIndex = 17;
            this.TotPrice.TabStop = false;
            this.TotPrice.Text = "Total Price:";
            // 
            // SelectAll
            // 
            this.SelectAll.Location = new System.Drawing.Point(6, 267);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(76, 25);
            this.SelectAll.TabIndex = 16;
            this.SelectAll.Text = "Select All";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // RemoveItem
            // 
            this.RemoveItem.Location = new System.Drawing.Point(90, 298);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(123, 25);
            this.RemoveItem.TabIndex = 5;
            this.RemoveItem.Text = "Remove Selected";
            this.RemoveItem.UseVisualStyleBackColor = true;
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // AddToOrder
            // 
            this.AddToOrder.Location = new System.Drawing.Point(225, 298);
            this.AddToOrder.Name = "AddToOrder";
            this.AddToOrder.Size = new System.Drawing.Size(100, 25);
            this.AddToOrder.TabIndex = 4;
            this.AddToOrder.Text = "Add To Order";
            this.AddToOrder.UseVisualStyleBackColor = true;
            this.AddToOrder.Click += new System.EventHandler(this.AddToOrder_Click);
            // 
            // OpenOrderItems
            // 
            this.OpenOrderItems.BackColor = System.Drawing.SystemColors.Control;
            this.OpenOrderItems.FormattingEnabled = true;
            this.OpenOrderItems.Location = new System.Drawing.Point(8, 41);
            this.OpenOrderItems.Name = "OpenOrderItems";
            this.OpenOrderItems.Size = new System.Drawing.Size(206, 199);
            this.OpenOrderItems.TabIndex = 14;
            // 
            // RoomNumber
            // 
            this.RoomNumber.AutoSize = true;
            this.RoomNumber.Location = new System.Drawing.Point(6, 12);
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Size = new System.Drawing.Size(81, 13);
            this.RoomNumber.TabIndex = 12;
            this.RoomNumber.Text = "Room Number: ";
            // 
            // QuantityItems
            // 
            this.QuantityItems.Location = new System.Drawing.Point(379, 11);
            this.QuantityItems.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityItems.Name = "QuantityItems";
            this.QuantityItems.Size = new System.Drawing.Size(56, 20);
            this.QuantityItems.TabIndex = 3;
            this.QuantityItems.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MenuItems
            // 
            this.MenuItems.FormattingEnabled = true;
            this.MenuItems.Location = new System.Drawing.Point(225, 10);
            this.MenuItems.MaxDropDownItems = 100;
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Size = new System.Drawing.Size(148, 21);
            this.MenuItems.TabIndex = 2;
            this.MenuItems.Text = "Menu Items";
            this.MenuItems.SelectedIndexChanged += new System.EventHandler(this.MenuItems_SelectedIndexChanged);
            this.MenuItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuItems_KeyDown);
            // 
            // DescriptionOrder
            // 
            this.DescriptionOrder.Location = new System.Drawing.Point(225, 41);
            this.DescriptionOrder.Multiline = true;
            this.DescriptionOrder.Name = "DescriptionOrder";
            this.DescriptionOrder.ReadOnly = true;
            this.DescriptionOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionOrder.Size = new System.Drawing.Size(210, 199);
            this.DescriptionOrder.TabIndex = 1;
            this.DescriptionOrder.TabStop = false;
            this.DescriptionOrder.Text = "Description";
            // 
            // KitchenSwitcher
            // 
            this.KitchenSwitcher.Controls.Add(this.AddFood);
            this.KitchenSwitcher.Controls.Add(this.FinishOrder);
            this.KitchenSwitcher.Location = new System.Drawing.Point(8, 12);
            this.KitchenSwitcher.Name = "KitchenSwitcher";
            this.KitchenSwitcher.SelectedIndex = 0;
            this.KitchenSwitcher.Size = new System.Drawing.Size(456, 355);
            this.KitchenSwitcher.TabIndex = 1;
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 429);
            this.Controls.Add(this.BackToLogIn);
            this.Controls.Add(this.KitchenSwitcher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(487, 467);
            this.MinimumSize = new System.Drawing.Size(487, 467);
            this.Name = "Kitchen";
            this.Text = "Kitchen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kitchen_FormClosing);
            this.Load += new System.EventHandler(this.Kitchen_Load);
            this.FinishOrder.ResumeLayout(false);
            this.FinishOrder.PerformLayout();
            this.AddFood.ResumeLayout(false);
            this.AddFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityItems)).EndInit();
            this.KitchenSwitcher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToLogIn;
        private System.Windows.Forms.TabPage FinishOrder;
        private System.Windows.Forms.TabPage AddFood;
        private System.Windows.Forms.Button SendOutOrder;
        private System.Windows.Forms.TextBox DescriptionOrder;
        private System.Windows.Forms.TabControl KitchenSwitcher;
        private System.Windows.Forms.ComboBox MenuItems;
        private System.Windows.Forms.NumericUpDown QuantityItems;
        private System.Windows.Forms.Label RoomNumber;
        private System.Windows.Forms.Button AddToOrder;
        private System.Windows.Forms.Label KitchenNote;
        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.Button RemoveItem;
        private System.Windows.Forms.TextBox TotPrice;
        private System.Windows.Forms.ComboBox OpenRooms;
        private System.Windows.Forms.Button DeSelect;
        private System.Windows.Forms.CheckedListBox OpenOrderItems;
        private System.Windows.Forms.Button ChefFinishOrder;
        private System.Windows.Forms.ComboBox ChefOpenOrders;
        private System.Windows.Forms.Label IsEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ChefItems;
        private System.Windows.Forms.Label RoomOfOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelOrder;
    }
}