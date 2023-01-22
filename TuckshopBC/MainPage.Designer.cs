namespace TuckshopBC
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnStudentOrder = new System.Windows.Forms.Button();
            this.btnInventoryManagement = new System.Windows.Forms.Button();
            this.btnRecordsales = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnTrackOrder = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnStudentOrder);
            this.panelMenu.Controls.Add(this.btnInventoryManagement);
            this.panelMenu.Controls.Add(this.btnRecordsales);
            this.panelMenu.Controls.Add(this.btnPlaceOrder);
            this.panelMenu.Controls.Add(this.btnTrackOrder);
            this.panelMenu.Location = new System.Drawing.Point(-1, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(187, 520);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 130);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(3, 470);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(178, 48);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnStudentOrder
            // 
            this.btnStudentOrder.Location = new System.Drawing.Point(3, 328);
            this.btnStudentOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentOrder.Name = "btnStudentOrder";
            this.btnStudentOrder.Size = new System.Drawing.Size(178, 48);
            this.btnStudentOrder.TabIndex = 6;
            this.btnStudentOrder.Text = "Student Orders";
            this.btnStudentOrder.UseVisualStyleBackColor = true;
            this.btnStudentOrder.Click += new System.EventHandler(this.btnStudentOrder_Click);
            // 
            // btnInventoryManagement
            // 
            this.btnInventoryManagement.Location = new System.Drawing.Point(3, 133);
            this.btnInventoryManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryManagement.Name = "btnInventoryManagement";
            this.btnInventoryManagement.Size = new System.Drawing.Size(178, 45);
            this.btnInventoryManagement.TabIndex = 1;
            this.btnInventoryManagement.Text = "Inventory Management";
            this.btnInventoryManagement.UseVisualStyleBackColor = true;
            this.btnInventoryManagement.Click += new System.EventHandler(this.btnInventoryManagement_Click);
            // 
            // btnRecordsales
            // 
            this.btnRecordsales.Location = new System.Drawing.Point(3, 277);
            this.btnRecordsales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecordsales.Name = "btnRecordsales";
            this.btnRecordsales.Size = new System.Drawing.Size(178, 47);
            this.btnRecordsales.TabIndex = 5;
            this.btnRecordsales.Text = "Record Sales";
            this.btnRecordsales.UseVisualStyleBackColor = true;
            this.btnRecordsales.Click += new System.EventHandler(this.btnRecordsales_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(3, 182);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(178, 42);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnTrackOrder
            // 
            this.btnTrackOrder.Location = new System.Drawing.Point(3, 230);
            this.btnTrackOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrackOrder.Name = "btnTrackOrder";
            this.btnTrackOrder.Size = new System.Drawing.Size(178, 43);
            this.btnTrackOrder.TabIndex = 3;
            this.btnTrackOrder.Text = "Track Orders";
            this.btnTrackOrder.UseVisualStyleBackColor = true;
            this.btnTrackOrder.Click += new System.EventHandler(this.btnTrackOrder_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1072, 392);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1411, 638);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnStudentOrder;
        private System.Windows.Forms.Button btnInventoryManagement;
        private System.Windows.Forms.Button btnRecordsales;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnTrackOrder;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}