namespace TuckshopBC
{
    partial class SalesRecord
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtQualitySold = new System.Windows.Forms.TextBox();
            this.Netprofittb = new System.Windows.Forms.TextBox();
            this.Grossvaluetb = new System.Windows.Forms.TextBox();
            this.Costpricetb = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(17, 54);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 22);
            this.txtID.TabIndex = 29;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(54, 16);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "Enter ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(17, 268);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 43);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMainPage
            // 
            this.btnMainPage.Location = new System.Drawing.Point(17, 210);
            this.btnMainPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(135, 43);
            this.btnMainPage.TabIndex = 27;
            this.btnMainPage.Text = "Main Page";
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(17, 159);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 38);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnMainPage);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(1155, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 325);
            this.panel1.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 107);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 38);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQualitySold
            // 
            this.txtQualitySold.Location = new System.Drawing.Point(202, 411);
            this.txtQualitySold.Name = "txtQualitySold";
            this.txtQualitySold.Size = new System.Drawing.Size(169, 22);
            this.txtQualitySold.TabIndex = 34;
            this.txtQualitySold.TextChanged += new System.EventHandler(this.Qualitysoldtb_TextChanged);
            // 
            // Netprofittb
            // 
            this.Netprofittb.Location = new System.Drawing.Point(967, 411);
            this.Netprofittb.Name = "Netprofittb";
            this.Netprofittb.Size = new System.Drawing.Size(169, 22);
            this.Netprofittb.TabIndex = 36;
            // 
            // Grossvaluetb
            // 
            this.Grossvaluetb.Location = new System.Drawing.Point(774, 411);
            this.Grossvaluetb.Name = "Grossvaluetb";
            this.Grossvaluetb.Size = new System.Drawing.Size(169, 22);
            this.Grossvaluetb.TabIndex = 37;
            // 
            // Costpricetb
            // 
            this.Costpricetb.Location = new System.Drawing.Point(581, 411);
            this.Costpricetb.Name = "Costpricetb";
            this.Costpricetb.Size = new System.Drawing.Size(169, 22);
            this.Costpricetb.TabIndex = 38;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(391, 411);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(169, 22);
            this.txtDescription.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Quantity Sold";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cost price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Gross value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(964, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "NetProfit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(27, 411);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 22);
            this.txtName.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 338);
            this.dataGridView1.TabIndex = 47;
            // 
            // SalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1343, 474);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.Costpricetb);
            this.Controls.Add(this.Grossvaluetb);
            this.Controls.Add(this.Netprofittb);
            this.Controls.Add(this.txtQualitySold);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalesRecord";
            this.Text = "SalesRecord";
            this.Load += new System.EventHandler(this.SalesRecord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQualitySold;
        private System.Windows.Forms.TextBox Netprofittb;
        private System.Windows.Forms.TextBox Grossvaluetb;
        private System.Windows.Forms.TextBox Costpricetb;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}