namespace TuckshopBC
{
    partial class InventoryManagement
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescribtion = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.lblDiscontinued = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtReOrderLevel = new System.Windows.Forms.TextBox();
            this.txtDiscontinued = new System.Windows.Forms.TextBox();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inventoryInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 62;
            this.dataGridViewInventory.RowTemplate.Height = 28;
            this.dataGridViewInventory.Size = new System.Drawing.Size(1074, 363);
            this.dataGridViewInventory.TabIndex = 0;
            this.dataGridViewInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1119, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(69, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Enter ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Product Name";
            // 
            // lblDescribtion
            // 
            this.lblDescribtion.AutoSize = true;
            this.lblDescribtion.Location = new System.Drawing.Point(14, 81);
            this.lblDescribtion.Name = "lblDescribtion";
            this.lblDescribtion.Size = new System.Drawing.Size(89, 20);
            this.lblDescribtion.TabIndex = 3;
            this.lblDescribtion.Text = "Description";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(14, 151);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(77, 20);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(14, 224);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(128, 20);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity In stock";
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Location = new System.Drawing.Point(14, 305);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(116, 20);
            this.lblReorderLevel.TabIndex = 6;
            this.lblReorderLevel.Text = "Re-Order Level";
            // 
            // lblDiscontinued
            // 
            this.lblDiscontinued.AutoSize = true;
            this.lblDiscontinued.Location = new System.Drawing.Point(14, 380);
            this.lblDiscontinued.Name = "lblDiscontinued";
            this.lblDiscontinued.Size = new System.Drawing.Size(102, 20);
            this.lblDiscontinued.TabIndex = 7;
            this.lblDiscontinued.Text = "Discontinued";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(18, 43);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(167, 26);
            this.txtProductName.TabIndex = 8;
            // 
            // txtReOrderLevel
            // 
            this.txtReOrderLevel.Location = new System.Drawing.Point(18, 337);
            this.txtReOrderLevel.Name = "txtReOrderLevel";
            this.txtReOrderLevel.Size = new System.Drawing.Size(167, 26);
            this.txtReOrderLevel.TabIndex = 9;
            // 
            // txtDiscontinued
            // 
            this.txtDiscontinued.Location = new System.Drawing.Point(18, 416);
            this.txtDiscontinued.Name = "txtDiscontinued";
            this.txtDiscontinued.Size = new System.Drawing.Size(167, 26);
            this.txtDiscontinued.TabIndex = 10;
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Location = new System.Drawing.Point(18, 261);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(167, 26);
            this.txtQuantityInStock.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(18, 113);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(167, 26);
            this.txtDescription.TabIndex = 12;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(18, 184);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(167, 26);
            this.txtUnitPrice.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(1208, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 55);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(231, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 55);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMainPage
            // 
            this.btnMainPage.Location = new System.Drawing.Point(605, 24);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(143, 55);
            this.btnMainPage.TabIndex = 17;
            this.btnMainPage.Text = "Main Page";
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(495, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 55);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(359, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 55);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblDescribtion);
            this.panel1.Controls.Add(this.lblUnitPrice);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.txtQuantityInStock);
            this.panel1.Controls.Add(this.txtDiscontinued);
            this.panel1.Controls.Add(this.lblReorderLevel);
            this.panel1.Controls.Add(this.lblDiscontinued);
            this.panel1.Controls.Add(this.txtReOrderLevel);
            this.panel1.Location = new System.Drawing.Point(1123, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 473);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnMainPage);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(284, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 100);
            this.panel2.TabIndex = 21;
            // 
            // inventoryInfoBindingSource
            // 
            this.inventoryInfoBindingSource.DataSource = typeof(TuckshopBC.InventoryInfo);
            // 
            // inventoryInfoBindingSource1
            // 
            this.inventoryInfoBindingSource1.DataSource = typeof(TuckshopBC.InventoryInfo);
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1353, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridViewInventory);
            this.Name = "InventoryManagement";
            this.Text = "InventoryManagement";
            this.Load += new System.EventHandler(this.InventoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescribtion;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.Label lblDiscontinued;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtReOrderLevel;
        private System.Windows.Forms.TextBox txtDiscontinued;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource inventoryInfoBindingSource;
        private System.Windows.Forms.BindingSource inventoryInfoBindingSource1;
    }
}