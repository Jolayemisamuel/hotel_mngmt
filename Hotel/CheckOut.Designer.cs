namespace Hotel
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            this.Rooms = new System.Windows.Forms.ComboBox();
            this.room = new System.Windows.Forms.Label();
            this.recipt = new System.Windows.Forms.GroupBox();
            this.RecordNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameOfPerson = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TotAmnt = new System.Windows.Forms.Label();
            this.RmSvMny = new System.Windows.Forms.Label();
            this.PPN = new System.Windows.Forms.Label();
            this.DaysSpent = new System.Windows.Forms.Label();
            this.OutDay = new System.Windows.Forms.Label();
            this.InDay = new System.Windows.Forms.Label();
            this.RmNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.FoodLable = new System.Windows.Forms.Label();
            this.FoodItems = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.recipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rooms
            // 
            this.Rooms.FormattingEnabled = true;
            this.Rooms.Location = new System.Drawing.Point(56, 6);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(121, 21);
            this.Rooms.TabIndex = 0;
            this.Rooms.SelectedIndexChanged += new System.EventHandler(this.Rooms_SelectedIndexChanged);
            // 
            // room
            // 
            this.room.AutoSize = true;
            this.room.Location = new System.Drawing.Point(12, 9);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(38, 13);
            this.room.TabIndex = 1;
            this.room.Text = "Room:";
            // 
            // recipt
            // 
            this.recipt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.recipt.Controls.Add(this.RecordNumber);
            this.recipt.Controls.Add(this.label9);
            this.recipt.Controls.Add(this.NameOfPerson);
            this.recipt.Controls.Add(this.label8);
            this.recipt.Controls.Add(this.TotAmnt);
            this.recipt.Controls.Add(this.RmSvMny);
            this.recipt.Controls.Add(this.PPN);
            this.recipt.Controls.Add(this.DaysSpent);
            this.recipt.Controls.Add(this.OutDay);
            this.recipt.Controls.Add(this.InDay);
            this.recipt.Controls.Add(this.RmNum);
            this.recipt.Controls.Add(this.label6);
            this.recipt.Controls.Add(this.label5);
            this.recipt.Controls.Add(this.label4);
            this.recipt.Controls.Add(this.label3);
            this.recipt.Controls.Add(this.label2);
            this.recipt.Controls.Add(this.label1);
            this.recipt.Controls.Add(this.Total);
            this.recipt.Controls.Add(this.FoodLable);
            this.recipt.Controls.Add(this.FoodItems);
            this.recipt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recipt.Location = new System.Drawing.Point(15, 33);
            this.recipt.Name = "recipt";
            this.recipt.Size = new System.Drawing.Size(555, 421);
            this.recipt.TabIndex = 2;
            this.recipt.TabStop = false;
            this.recipt.Text = "Your recipt:";
            this.recipt.Enter += new System.EventHandler(this.recipt_Enter);
            // 
            // RecordNumber
            // 
            this.RecordNumber.AutoSize = true;
            this.RecordNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordNumber.Location = new System.Drawing.Point(474, 16);
            this.RecordNumber.Name = "RecordNumber";
            this.RecordNumber.Size = new System.Drawing.Size(65, 20);
            this.RecordNumber.TabIndex = 20;
            this.RecordNumber.Text = "Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Record Number: ";
            // 
            // NameOfPerson
            // 
            this.NameOfPerson.AutoSize = true;
            this.NameOfPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfPerson.Location = new System.Drawing.Point(72, 16);
            this.NameOfPerson.Name = "NameOfPerson";
            this.NameOfPerson.Size = new System.Drawing.Size(51, 20);
            this.NameOfPerson.TabIndex = 17;
            this.NameOfPerson.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name: ";
            // 
            // TotAmnt
            // 
            this.TotAmnt.AutoSize = true;
            this.TotAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAmnt.Location = new System.Drawing.Point(170, 392);
            this.TotAmnt.Name = "TotAmnt";
            this.TotAmnt.Size = new System.Drawing.Size(36, 20);
            this.TotAmnt.TabIndex = 15;
            this.TotAmnt.Text = "$$$";
            // 
            // RmSvMny
            // 
            this.RmSvMny.AutoSize = true;
            this.RmSvMny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmSvMny.Location = new System.Drawing.Point(170, 341);
            this.RmSvMny.Name = "RmSvMny";
            this.RmSvMny.Size = new System.Drawing.Size(36, 20);
            this.RmSvMny.TabIndex = 14;
            this.RmSvMny.Text = "$$$";
            // 
            // PPN
            // 
            this.PPN.AutoSize = true;
            this.PPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPN.Location = new System.Drawing.Point(171, 287);
            this.PPN.Name = "PPN";
            this.PPN.Size = new System.Drawing.Size(36, 20);
            this.PPN.TabIndex = 13;
            this.PPN.Text = "$$$";
            // 
            // DaysSpent
            // 
            this.DaysSpent.AutoSize = true;
            this.DaysSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysSpent.Location = new System.Drawing.Point(170, 230);
            this.DaysSpent.Name = "DaysSpent";
            this.DaysSpent.Size = new System.Drawing.Size(45, 20);
            this.DaysSpent.TabIndex = 12;
            this.DaysSpent.Text = "Days";
            // 
            // OutDay
            // 
            this.OutDay.AutoSize = true;
            this.OutDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutDay.Location = new System.Drawing.Point(170, 175);
            this.OutDay.Name = "OutDay";
            this.OutDay.Size = new System.Drawing.Size(37, 20);
            this.OutDay.TabIndex = 11;
            this.OutDay.Text = "Day";
            // 
            // InDay
            // 
            this.InDay.AutoSize = true;
            this.InDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InDay.Location = new System.Drawing.Point(169, 122);
            this.InDay.Name = "InDay";
            this.InDay.Size = new System.Drawing.Size(37, 20);
            this.InDay.TabIndex = 10;
            this.InDay.Text = "Day";
            // 
            // RmNum
            // 
            this.RmNum.AutoSize = true;
            this.RmNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmNum.Location = new System.Drawing.Point(171, 72);
            this.RmNum.Name = "RmNum";
            this.RmNum.Size = new System.Drawing.Size(65, 20);
            this.RmNum.TabIndex = 9;
            this.RmNum.Text = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Room Number: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Room Service Total: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price Per Night: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Nights Stayed: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Check Out Day:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Check In Day: ";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(6, 388);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(66, 25);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total:";
            // 
            // FoodLable
            // 
            this.FoodLable.AutoSize = true;
            this.FoodLable.Location = new System.Drawing.Point(368, 56);
            this.FoodLable.Name = "FoodLable";
            this.FoodLable.Size = new System.Drawing.Size(111, 13);
            this.FoodLable.TabIndex = 1;
            this.FoodLable.Text = "Room Service Orders:";
            // 
            // FoodItems
            // 
            this.FoodItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodItems.FormattingEnabled = true;
            this.FoodItems.ItemHeight = 16;
            this.FoodItems.Location = new System.Drawing.Point(362, 72);
            this.FoodItems.Name = "FoodItems";
            this.FoodItems.Size = new System.Drawing.Size(177, 340);
            this.FoodItems.TabIndex = 0;
            this.FoodItems.SelectedIndexChanged += new System.EventHandler(this.FoodItems_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back to previous screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(208, 460);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(170, 23);
            this.CheckOutButton.TabIndex = 4;
            this.CheckOutButton.Text = "Checkout ";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(400, 460);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(170, 23);
            this.Print.TabIndex = 5;
            this.Print.Text = "Print Recipt";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(591, 497);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recipt);
            this.Controls.Add(this.room);
            this.Controls.Add(this.Rooms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckOut_FormClosing);
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.recipt.ResumeLayout(false);
            this.recipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Rooms;
        private System.Windows.Forms.Label room;
        private System.Windows.Forms.GroupBox recipt;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label FoodLable;
        private System.Windows.Forms.ListBox FoodItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotAmnt;
        private System.Windows.Forms.Label RmSvMny;
        private System.Windows.Forms.Label PPN;
        private System.Windows.Forms.Label DaysSpent;
        private System.Windows.Forms.Label OutDay;
        private System.Windows.Forms.Label InDay;
        private System.Windows.Forms.Label RmNum;
        private System.Windows.Forms.Label NameOfPerson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label RecordNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Print;
    }
}