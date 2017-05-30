namespace Hotel
{
    partial class FrontDeskSwitcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontDeskSwitcher));
            this.CheckIn = new System.Windows.Forms.Button();
            this.CheckOut = new System.Windows.Forms.Button();
            this.RoomService = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckIn
            // 
            this.CheckIn.Location = new System.Drawing.Point(142, 12);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(75, 50);
            this.CheckIn.TabIndex = 0;
            this.CheckIn.Text = "Check In";
            this.CheckIn.UseVisualStyleBackColor = true;
            this.CheckIn.Click += new System.EventHandler(this.CheckIn_Click);
            // 
            // CheckOut
            // 
            this.CheckOut.Location = new System.Drawing.Point(142, 68);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(75, 50);
            this.CheckOut.TabIndex = 1;
            this.CheckOut.Text = "Check Out";
            this.CheckOut.UseVisualStyleBackColor = true;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // RoomService
            // 
            this.RoomService.Location = new System.Drawing.Point(12, 12);
            this.RoomService.Name = "RoomService";
            this.RoomService.Size = new System.Drawing.Size(75, 50);
            this.RoomService.TabIndex = 2;
            this.RoomService.Text = "Room Service";
            this.RoomService.UseVisualStyleBackColor = true;
            this.RoomService.Click += new System.EventHandler(this.RoomService_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(12, 68);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 50);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // FrontDeskSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 133);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.RoomService);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.CheckIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(245, 171);
            this.MinimumSize = new System.Drawing.Size(245, 171);
            this.Name = "FrontDeskSwitcher";
            this.Text = "FrontDeskSwitcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrontDeskSwitcher_FormClosing);
            this.Load += new System.EventHandler(this.FrontDeskSwitcher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckIn;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.Button RoomService;
        private System.Windows.Forms.Button LogOut;
    }
}