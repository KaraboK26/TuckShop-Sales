namespace TuckshopBC
{
    partial class StudentOrder
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.quantityNum = new System.Windows.Forms.NumericUpDown();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.grpBoxStudentsOrdering = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblunitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNum)).BeginInit();
            this.grpBoxStudentsOrdering.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(12, 30);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(150, 241);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(67, 34);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(96, 30);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(121, 20);
            this.txtStudentName.TabIndex = 2;
            // 
            // quantityNum
            // 
            this.quantityNum.Location = new System.Drawing.Point(96, 119);
            this.quantityNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityNum.Name = "quantityNum";
            this.quantityNum.Size = new System.Drawing.Size(121, 20);
            this.quantityNum.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 61);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(72, 13);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "ProductName";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(12, 92);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(44, 13);
            this.lblOrderID.TabIndex = 5;
            this.lblOrderID.Text = "OrderID";
            // 
            // grpBoxStudentsOrdering
            // 
            this.grpBoxStudentsOrdering.Controls.Add(this.cbxStatus);
            this.grpBoxStudentsOrdering.Controls.Add(this.lblStatus);
            this.grpBoxStudentsOrdering.Controls.Add(this.tbxDate);
            this.grpBoxStudentsOrdering.Controls.Add(this.lblDate);
            this.grpBoxStudentsOrdering.Controls.Add(this.btnCancel);
            this.grpBoxStudentsOrdering.Controls.Add(this.lblunitPrice);
            this.grpBoxStudentsOrdering.Controls.Add(this.btnFinish);
            this.grpBoxStudentsOrdering.Controls.Add(this.txtUnitPrice);
            this.grpBoxStudentsOrdering.Controls.Add(this.txtOrderID);
            this.grpBoxStudentsOrdering.Controls.Add(this.txtProductName);
            this.grpBoxStudentsOrdering.Controls.Add(this.lblQuantity);
            this.grpBoxStudentsOrdering.Controls.Add(this.lblStudentName);
            this.grpBoxStudentsOrdering.Controls.Add(this.quantityNum);
            this.grpBoxStudentsOrdering.Controls.Add(this.lblOrderID);
            this.grpBoxStudentsOrdering.Controls.Add(this.txtStudentName);
            this.grpBoxStudentsOrdering.Controls.Add(this.lblProductName);
            this.grpBoxStudentsOrdering.Location = new System.Drawing.Point(139, 22);
            this.grpBoxStudentsOrdering.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxStudentsOrdering.Name = "grpBoxStudentsOrdering";
            this.grpBoxStudentsOrdering.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxStudentsOrdering.Size = new System.Drawing.Size(250, 291);
            this.grpBoxStudentsOrdering.TabIndex = 6;
            this.grpBoxStudentsOrdering.TabStop = false;
            this.grpBoxStudentsOrdering.Text = "Student\'s Ordering";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(37, 241);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 34);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblunitPrice
            // 
            this.lblunitPrice.AutoSize = true;
            this.lblunitPrice.Location = new System.Drawing.Point(12, 152);
            this.lblunitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblunitPrice.Name = "lblunitPrice";
            this.lblunitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblunitPrice.TabIndex = 10;
            this.lblunitPrice.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(96, 150);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.txtUnitPrice.TabIndex = 7;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(96, 88);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(121, 20);
            this.txtOrderID.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(96, 57);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(121, 20);
            this.txtProductName.TabIndex = 9;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 119);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 182);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 13);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Order Date";
            // 
            // tbxDate
            // 
            this.tbxDate.Location = new System.Drawing.Point(95, 179);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(122, 20);
            this.tbxDate.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 209);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Delivery Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Not Delivered",
            "Delivered"});
            this.cbxStatus.Location = new System.Drawing.Point(96, 205);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 16;
            // 
            // StudentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 365);
            this.Controls.Add(this.grpBoxStudentsOrdering);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentOrder";
            this.Text = "StudentOrder";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNum)).EndInit();
            this.grpBoxStudentsOrdering.ResumeLayout(false);
            this.grpBoxStudentsOrdering.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.NumericUpDown quantityNum;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.GroupBox grpBoxStudentsOrdering;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblunitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}