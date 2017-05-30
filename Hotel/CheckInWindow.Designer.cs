namespace Hotel
{
    partial class CheckInWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInWindow));
            this.ReturnToPrevScreen = new System.Windows.Forms.Button();
            this.Beds = new System.Windows.Forms.ComboBox();
            this.Baths = new System.Windows.Forms.ComboBox();
            this.Balcony = new System.Windows.Forms.CheckBox();
            this.OceanView = new System.Windows.Forms.CheckBox();
            this.Suite = new System.Windows.Forms.CheckBox();
            this.AvailRoom = new System.Windows.Forms.ComboBox();
            this.CheckInRoom = new System.Windows.Forms.Button();
            this.GetAvailRooms = new System.Windows.Forms.Button();
            this.CheckIn = new System.Windows.Forms.TabControl();
            this.FindRoom = new System.Windows.Forms.TabPage();
            this.ShowAllOpen = new System.Windows.Forms.Button();
            this.GetInfo = new System.Windows.Forms.TabPage();
            this.RmNum = new System.Windows.Forms.Label();
            this.RoomNum = new System.Windows.Forms.Label();
            this.ExpLabel = new System.Windows.Forms.Label();
            this.ExpDate = new System.Windows.Forms.MaskedTextBox();
            this.CCNumLbl = new System.Windows.Forms.Label();
            this.CreditNum = new System.Windows.Forms.MaskedTextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PerName = new System.Windows.Forms.MaskedTextBox();
            this.CheckIn.SuspendLayout();
            this.FindRoom.SuspendLayout();
            this.GetInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnToPrevScreen
            // 
            this.ReturnToPrevScreen.Location = new System.Drawing.Point(12, 102);
            this.ReturnToPrevScreen.Name = "ReturnToPrevScreen";
            this.ReturnToPrevScreen.Size = new System.Drawing.Size(204, 46);
            this.ReturnToPrevScreen.TabIndex = 8;
            this.ReturnToPrevScreen.Text = "Return to Previous Screen";
            this.ReturnToPrevScreen.UseVisualStyleBackColor = true;
            this.ReturnToPrevScreen.Click += new System.EventHandler(this.ReturnToPrevScreen_Click);
            // 
            // Beds
            // 
            this.Beds.FormatString = "N0";
            this.Beds.FormattingEnabled = true;
            this.Beds.Location = new System.Drawing.Point(6, 6);
            this.Beds.Name = "Beds";
            this.Beds.Size = new System.Drawing.Size(74, 21);
            this.Beds.TabIndex = 1;
            this.Beds.Text = "Bedrooms";
            // 
            // Baths
            // 
            this.Baths.FormatString = "N0";
            this.Baths.FormattingEnabled = true;
            this.Baths.Location = new System.Drawing.Point(86, 6);
            this.Baths.Name = "Baths";
            this.Baths.Size = new System.Drawing.Size(74, 21);
            this.Baths.TabIndex = 2;
            this.Baths.Text = "Bathrooms";
            // 
            // Balcony
            // 
            this.Balcony.AutoSize = true;
            this.Balcony.Location = new System.Drawing.Point(256, 8);
            this.Balcony.Name = "Balcony";
            this.Balcony.Size = new System.Drawing.Size(64, 17);
            this.Balcony.TabIndex = 4;
            this.Balcony.Text = "Balcony";
            this.Balcony.UseVisualStyleBackColor = true;
            // 
            // OceanView
            // 
            this.OceanView.AutoSize = true;
            this.OceanView.Location = new System.Drawing.Point(166, 8);
            this.OceanView.Name = "OceanView";
            this.OceanView.Size = new System.Drawing.Size(84, 17);
            this.OceanView.TabIndex = 3;
            this.OceanView.Text = "Ocean View";
            this.OceanView.UseVisualStyleBackColor = true;
            // 
            // Suite
            // 
            this.Suite.AutoSize = true;
            this.Suite.Location = new System.Drawing.Point(326, 8);
            this.Suite.Name = "Suite";
            this.Suite.Size = new System.Drawing.Size(50, 17);
            this.Suite.TabIndex = 5;
            this.Suite.Text = "Suite";
            this.Suite.UseVisualStyleBackColor = true;
            // 
            // AvailRoom
            // 
            this.AvailRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvailRoom.FormattingEnabled = true;
            this.AvailRoom.Location = new System.Drawing.Point(6, 33);
            this.AvailRoom.Name = "AvailRoom";
            this.AvailRoom.Size = new System.Drawing.Size(169, 21);
            this.AvailRoom.TabIndex = 6;
            this.AvailRoom.SelectedIndexChanged += new System.EventHandler(this.AvailRoom_SelectedIndexChanged);
            // 
            // CheckInRoom
            // 
            this.CheckInRoom.Location = new System.Drawing.Point(224, 102);
            this.CheckInRoom.Name = "CheckInRoom";
            this.CheckInRoom.Size = new System.Drawing.Size(204, 46);
            this.CheckInRoom.TabIndex = 9;
            this.CheckInRoom.Text = "Check In";
            this.CheckInRoom.UseVisualStyleBackColor = true;
            this.CheckInRoom.Click += new System.EventHandler(this.CheckInRoom_Click);
            // 
            // GetAvailRooms
            // 
            this.GetAvailRooms.Location = new System.Drawing.Point(184, 33);
            this.GetAvailRooms.Name = "GetAvailRooms";
            this.GetAvailRooms.Size = new System.Drawing.Size(93, 21);
            this.GetAvailRooms.TabIndex = 7;
            this.GetAvailRooms.Text = "Show Matches";
            this.GetAvailRooms.UseVisualStyleBackColor = true;
            this.GetAvailRooms.Click += new System.EventHandler(this.GetAvailRooms_Click);
            // 
            // CheckIn
            // 
            this.CheckIn.Controls.Add(this.FindRoom);
            this.CheckIn.Controls.Add(this.GetInfo);
            this.CheckIn.Location = new System.Drawing.Point(12, 7);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.SelectedIndex = 0;
            this.CheckIn.Size = new System.Drawing.Size(416, 89);
            this.CheckIn.TabIndex = 10;
            // 
            // FindRoom
            // 
            this.FindRoom.BackColor = System.Drawing.SystemColors.Control;
            this.FindRoom.Controls.Add(this.ShowAllOpen);
            this.FindRoom.Controls.Add(this.Beds);
            this.FindRoom.Controls.Add(this.GetAvailRooms);
            this.FindRoom.Controls.Add(this.Baths);
            this.FindRoom.Controls.Add(this.Balcony);
            this.FindRoom.Controls.Add(this.AvailRoom);
            this.FindRoom.Controls.Add(this.OceanView);
            this.FindRoom.Controls.Add(this.Suite);
            this.FindRoom.Location = new System.Drawing.Point(4, 22);
            this.FindRoom.Name = "FindRoom";
            this.FindRoom.Padding = new System.Windows.Forms.Padding(3);
            this.FindRoom.Size = new System.Drawing.Size(408, 63);
            this.FindRoom.TabIndex = 0;
            this.FindRoom.Text = "Find Room";
            // 
            // ShowAllOpen
            // 
            this.ShowAllOpen.Location = new System.Drawing.Point(283, 33);
            this.ShowAllOpen.Name = "ShowAllOpen";
            this.ShowAllOpen.Size = new System.Drawing.Size(93, 21);
            this.ShowAllOpen.TabIndex = 8;
            this.ShowAllOpen.Text = "Show All Open";
            this.ShowAllOpen.UseVisualStyleBackColor = true;
            this.ShowAllOpen.Click += new System.EventHandler(this.ShowAllOpen_Click);
            // 
            // GetInfo
            // 
            this.GetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.GetInfo.Controls.Add(this.RmNum);
            this.GetInfo.Controls.Add(this.RoomNum);
            this.GetInfo.Controls.Add(this.ExpLabel);
            this.GetInfo.Controls.Add(this.ExpDate);
            this.GetInfo.Controls.Add(this.CCNumLbl);
            this.GetInfo.Controls.Add(this.CreditNum);
            this.GetInfo.Controls.Add(this.NameLabel);
            this.GetInfo.Controls.Add(this.PerName);
            this.GetInfo.ForeColor = System.Drawing.Color.Black;
            this.GetInfo.Location = new System.Drawing.Point(4, 22);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Padding = new System.Windows.Forms.Padding(3);
            this.GetInfo.Size = new System.Drawing.Size(408, 63);
            this.GetInfo.TabIndex = 1;
            this.GetInfo.Text = "Get Information";
            // 
            // RmNum
            // 
            this.RmNum.AutoSize = true;
            this.RmNum.Location = new System.Drawing.Point(81, 29);
            this.RmNum.Name = "RmNum";
            this.RmNum.Size = new System.Drawing.Size(0, 13);
            this.RmNum.TabIndex = 16;
            // 
            // RoomNum
            // 
            this.RoomNum.AutoSize = true;
            this.RoomNum.Location = new System.Drawing.Point(6, 29);
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.Size = new System.Drawing.Size(81, 13);
            this.RoomNum.TabIndex = 15;
            this.RoomNum.Text = "Room Number: ";
            // 
            // ExpLabel
            // 
            this.ExpLabel.AutoSize = true;
            this.ExpLabel.Location = new System.Drawing.Point(176, 32);
            this.ExpLabel.Name = "ExpLabel";
            this.ExpLabel.Size = new System.Drawing.Size(86, 13);
            this.ExpLabel.TabIndex = 14;
            this.ExpLabel.Text = "Experation Date:";
            // 
            // ExpDate
            // 
            this.ExpDate.Location = new System.Drawing.Point(283, 29);
            this.ExpDate.Mask = "00/0000";
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(56, 20);
            this.ExpDate.TabIndex = 13;
            this.ExpDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExpDate_MouseClick);
            // 
            // CCNumLbl
            // 
            this.CCNumLbl.AutoSize = true;
            this.CCNumLbl.Location = new System.Drawing.Point(176, 9);
            this.CCNumLbl.Name = "CCNumLbl";
            this.CCNumLbl.Size = new System.Drawing.Size(105, 13);
            this.CCNumLbl.TabIndex = 12;
            this.CCNumLbl.Text = "Credit Card Number: ";
            // 
            // CreditNum
            // 
            this.CreditNum.Location = new System.Drawing.Point(283, 6);
            this.CreditNum.Mask = "0000-0000-0000-0000";
            this.CreditNum.Name = "CreditNum";
            this.CreditNum.Size = new System.Drawing.Size(119, 20);
            this.CreditNum.TabIndex = 11;
            this.CreditNum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CreditNum_MouseClick);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name: ";
            // 
            // PerName
            // 
            this.PerName.Location = new System.Drawing.Point(53, 6);
            this.PerName.Mask = "?????????????????????????????";
            this.PerName.Name = "PerName";
            this.PerName.Size = new System.Drawing.Size(117, 20);
            this.PerName.SkipLiterals = false;
            this.PerName.TabIndex = 0;
            this.PerName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PerName_MouseClick);
            // 
            // CheckInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 156);
            this.Controls.Add(this.CheckIn);
            this.Controls.Add(this.CheckInRoom);
            this.Controls.Add(this.ReturnToPrevScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 194);
            this.MinimumSize = new System.Drawing.Size(455, 194);
            this.Name = "CheckInWindow";
            this.Text = "Check In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckInWindow_FormClosing);
            this.Load += new System.EventHandler(this.CheckInWindow_Load);
            this.CheckIn.ResumeLayout(false);
            this.FindRoom.ResumeLayout(false);
            this.FindRoom.PerformLayout();
            this.GetInfo.ResumeLayout(false);
            this.GetInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnToPrevScreen;
        private System.Windows.Forms.ComboBox Beds;
        private System.Windows.Forms.ComboBox Baths;
        private System.Windows.Forms.CheckBox Balcony;
        private System.Windows.Forms.CheckBox OceanView;
        private System.Windows.Forms.CheckBox Suite;
        private System.Windows.Forms.ComboBox AvailRoom;
        private System.Windows.Forms.Button CheckInRoom;
        private System.Windows.Forms.Button GetAvailRooms;
        private System.Windows.Forms.TabControl CheckIn;
        private System.Windows.Forms.TabPage FindRoom;
        private System.Windows.Forms.TabPage GetInfo;
        private System.Windows.Forms.Label CCNumLbl;
        private System.Windows.Forms.MaskedTextBox CreditNum;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.MaskedTextBox PerName;
        private System.Windows.Forms.Label RoomNum;
        private System.Windows.Forms.Label ExpLabel;
        private System.Windows.Forms.MaskedTextBox ExpDate;
        private System.Windows.Forms.Label RmNum;
        private System.Windows.Forms.Button ShowAllOpen;
    }
}