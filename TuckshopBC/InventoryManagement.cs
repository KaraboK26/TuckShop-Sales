using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuckshopBC
{
    public partial class InventoryManagement : Form
    {
        public List<InventoryInfo> inventory = new List<InventoryInfo>();
        
        public InventoryManagement()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtProductName.Text;
            string description = txtDescription.Text;
            int price = int.Parse(txtUnitPrice.Text);
            int quantity = int.Parse(txtQuantityInStock.Text);
            string reorderLevel = txtReOrderLevel.Text;
            string discontinue = txtDiscontinued.Text;


            inventory.Add(new InventoryInfo
            {
                inventoryID = id,
                inventoryName = name,
                inventoryDescribtion = description,
                inventoryPrice = price,
                inventoryQuantityInStock = quantity,
                inventoryReorderLevel = reorderLevel,
                inventoryDiscontinue = discontinue
            });
                
            
             

   
            dataGridViewInventory.Update();
            dataGridViewInventory.Refresh();
            
            
            //foreach (InventoryInfo item in inventory)
            //{

            //    //if (id != item.inventoryID)
            //    //{
            //    //    DataTable dt = (DataTable)dataGridViewInventory.DataSource;
            //    //    DataRow dr = dt.NewRow();
            //    //    dr["id"] = item.inventoryID;
            //    //    dr["name"] = item.inventoryName;
            //    //    dr["describtion"] = item.inventoryDescribtion;
            //    //    dr["price"] = item.inventoryPrice;
            //    //    dr["quantity"] = item.inventoryQuantityInStock;
            //    //    dr["reorderLevel"] = item.inventoryReorderLevel;
            //    //    dr["discontinue"] = item.inventoryDiscontinue;
            //    //    //dataGridViewInventory.Rows.Add(id, name, description, price, quantity, reorderLevel, discontinue);
            //    //    dt.Rows.Add(dr);
            //    //    dt.AcceptChanges();
            //    //}
            //    //else
            //    //{
            //    //    MessageBox.Show("ID already exists, plz try again");
            //    //    txtID.Text = "";
            //    }
            //}

            /*DataTable dataTable = (DataTable)dataGridView.DataSource;
            DataRow drToAdd = dataTable.NewRow();

            drToAdd["Field1"] = "Value1";
            drToAdd["Field2"] = "Value2";

            dataTable.Rows.Add(drToAdd);
            dataTable.AcceptChanges();
             * 
             * 
             */
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          
            foreach (InventoryInfo item in inventory)
            {
                if (int.Parse(txtID.Text) == item.inventoryID)
                {
                    txtProductName.Text = item.inventoryName;
                    txtDescription.Text = item.inventoryDescribtion;
                    txtUnitPrice.Text = item.inventoryPrice.ToString();
                    txtQuantityInStock.Text = item.inventoryQuantityInStock.ToString();
                    txtReOrderLevel.Text = item.inventoryReorderLevel.ToString();
                    txtDiscontinued.Text = item.inventoryDiscontinue;
                    break;

                }

            }

            //(dataGridViewInventory.DataSource as DataTable).DefaultView.RowFilter =
            //   String.Format("inventoryName like '%" + txtProductName.Text + "%'");

            //name = info.inventoryName;
            //description = info.inventoryDescribtion;
            //price = (int)info.inventoryPrice;
            //quantity = (int)info.inventoryQuantityInStock;
            //reorderLevel = (string)info.inventoryReorderLevel;
            //discontinue = info.inventoryDiscontinue;

        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
           

            inventory.Add(new InventoryInfo
            {
                inventoryID = 1,
                inventoryName = "coke",
                inventoryDescribtion = "coke zero",
                inventoryPrice = 20,
                inventoryQuantityInStock = 50,
                inventoryReorderLevel = "Standard",
                inventoryDiscontinue = "no"
            });

            inventory.Add(new InventoryInfo
            {
                inventoryID = 2,
                inventoryName = "sprite",
                inventoryDescribtion = "550ml sprite and cucumber flavour",
                inventoryPrice = 15,
                inventoryQuantityInStock = 90,
                inventoryReorderLevel = "Standard",
                inventoryDiscontinue = "yes"
            });
            inventory.Add(new InventoryInfo
            {
                inventoryID = 3,
                inventoryName = "Fanta",
                inventoryDescribtion = "1.5l fanta orange can",
                inventoryPrice = 10,
                inventoryQuantityInStock = 70,
                inventoryReorderLevel = "Standard",
                inventoryDiscontinue = "no"
            });

            inventory.Add(new InventoryInfo
            {
                inventoryID = 4,
                inventoryName = "pie",
                inventoryDescribtion = "salami and cheese",
                inventoryPrice = 25,
                inventoryQuantityInStock = 88,
                inventoryReorderLevel = "Standard",
                inventoryDiscontinue = "no"
            });
            inventory.Add(new InventoryInfo
            {
                inventoryID = 5,
                inventoryName = "pie",
                inventoryDescribtion = "pepper steak",
                inventoryPrice = 25,
                inventoryQuantityInStock = 42,
                inventoryReorderLevel = "Standard",
                inventoryDiscontinue = "no"
            });

            inventory.Add(new InventoryInfo
            {
                inventoryID = 6,
                inventoryName = "meat",
                inventoryDescribtion = "beef",
                inventoryPrice = 35,
                inventoryQuantityInStock = 10,
                inventoryReorderLevel = "Low",
                inventoryDiscontinue = "yes"
            });

            inventory.Add(new InventoryInfo
            {
                inventoryID = 7,
                inventoryName = "burger",
                inventoryDescribtion = "cheese burger",
                inventoryPrice = 45,
                inventoryQuantityInStock = 50,
                inventoryReorderLevel = "priority",
                inventoryDiscontinue = "no"
            });

            inventory.Add(new InventoryInfo
            {
                inventoryID = 8,
                inventoryName = "pizza",
                inventoryDescribtion = "large mexican",
                inventoryPrice = 90,
                inventoryQuantityInStock = 20,
                inventoryReorderLevel = "Low",
                inventoryDiscontinue = "yes"
            });
            inventory.Add(new InventoryInfo
            {
                inventoryID = 9,
                inventoryName = "chocolate",
                inventoryDescribtion = "lunch bar",
                inventoryPrice = 11,
                inventoryQuantityInStock = 72,
                inventoryReorderLevel = "Standard",
                inventoryDiscontinue = "no"
            });
            inventory.Add(new InventoryInfo
            {
                inventoryID = 10,
                inventoryName = "chips",
                inventoryDescribtion = "onion lays",
                inventoryPrice = 28,
                inventoryQuantityInStock = 66,
                inventoryReorderLevel = "Standard",
                inventoryDiscontinue = "no"
            });
            //dataGridViewInventory.DataSource = null;
            dataGridViewInventory.DataSource = inventory;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            foreach (InventoryInfo item in inventory)
            {
                if (int.Parse(txtID.Text) == item.inventoryID)
                {

                    item.inventoryName = txtProductName.Text;
                    item.inventoryDescribtion = txtDescription.Text;
                    item.inventoryPrice = int.Parse(txtUnitPrice.Text);
                    item.inventoryQuantityInStock = int.Parse(txtQuantityInStock.Text);
                    item.inventoryReorderLevel = txtReOrderLevel.Text;
                    item.inventoryDiscontinue = txtDiscontinued.Text;
                    dataGridViewInventory.DataSource = inventory;
                    break;

                }
            }
            dataGridViewInventory.Update();
            dataGridViewInventory.Refresh();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (InventoryInfo item in inventory)
            {
                if (int.Parse(txtID.Text) == item.inventoryID)
                {
                    inventory.Remove(item);
                    break;

                }
            }
            dataGridViewInventory.Update();
            dataGridViewInventory.Refresh();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }
    }

    
}
