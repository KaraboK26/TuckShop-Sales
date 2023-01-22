namespace TuckshopBC
{
    partial class PlaceOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblStud = new System.Windows.Forms.Label();
            this.tbxStudent = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(705, 257);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 6);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(103, 13);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "Enter Student Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMainPage);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(5, 293);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 119);
            this.panel1.TabIndex = 23;
            // 
            // btnMainPage
            // 
            this.btnMainPage.Location = new System.Drawing.Point(606, 65);
            this.btnMainPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(75, 36);
            this.btnMainPage.TabIndex = 17;
            this.btnMainPage.Text = "Main Page";
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(405, 65);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 36);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 65);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 36);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(197, 19);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 36);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(197, 65);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 36);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblStud
            // 
            this.lblStud.AutoSize = true;
            this.lblStud.Location = new System.Drawing.Point(749, 29);
            this.lblStud.Name = "lblStud";
            this.lblStud.Size = new System.Drawing.Size(75, 13);
            this.lblStud.TabIndex = 24;
            this.lblStud.Text = "Student Name";
            // 
            // tbxStudent
            // 
            this.tbxStudent.Location = new System.Drawing.Point(840, 26);
            this.tbxStudent.Name = "tbxStudent";
            this.tbxStudent.Size = new System.Drawing.Size(188, 20);
            this.tbxStudent.TabIndex = 25;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(749, 72);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(75, 13);
            this.lblProduct.TabIndex = 26;
            this.lblProduct.Text = "Product Name";
            // 
            // tbxProduct
            // 
            this.tbxProduct.Location = new System.Drawing.Point(840, 69);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(188, 20);
            this.tbxProduct.TabIndex = 27;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(771, 110);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(53, 13);
            this.lblUnit.TabIndex = 28;
            this.lblUnit.Text = "Unit Price";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(840, 110);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(188, 20);
            this.tbxPrice.TabIndex = 29;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(778, 154);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 30;
            this.lblQuantity.Text = "Quantity";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(840, 151);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(188, 20);
            this.tbxQuantity.TabIndex = 31;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(766, 196);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 13);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "Total Price";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(840, 193);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(188, 20);
            this.tbxTotal.TabIndex = 33;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(766, 239);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 13);
            this.lblDate.TabIndex = 34;
            this.lblDate.Text = "Order Date";
            // 
            // tbxDate
            // 
            this.tbxDate.Location = new System.Drawing.Point(840, 236);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(188, 20);
            this.tbxDate.TabIndex = 35;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(746, 280);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 13);
            this.lblStatus.TabIndex = 36;
            this.lblStatus.Text = "Delivery Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Not Delivered",
            "Delivered"});
            this.cbxStatus.Location = new System.Drawing.Point(840, 277);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(188, 21);
            this.cbxStatus.TabIndex = 37;
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1044, 429);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.tbxProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.tbxStudent);
            this.Controls.Add(this.lblStud);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlaceOrder";
            this.Text = "PlaceOrder";
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblStud;
        private System.Windows.Forms.TextBox tbxStudent;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox tbxProduct;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
    }
}