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
    public partial class SalesRecord : Form
    {
        public List<SalesInfo> sales = new List<SalesInfo>();
        public SalesRecord()
        {
            InitializeComponent();
        }

        private void SalesRecord_Load(object sender, EventArgs e)
        {
            sales.Add(new SalesInfo
            {
                InventoryID1 = 1,
                ProductName1 = "coke",
                Description1 = "coke zero",
                QuantitySold1 = 20,
                CostPrice1 = 20,
                GrossValue1 = 400,
                NetProfit1 = 200
            });

            sales.Add(new SalesInfo
            {
                InventoryID1 = 2,
                ProductName1 = "sprite",
                Description1 = "550ml sprite and cucumber flavour",
                QuantitySold1 = 20,
                CostPrice1 = 15,
                GrossValue1 = 300,
                NetProfit1 = 150
            });

            sales.Add(new SalesInfo
            {
                InventoryID1 = 3,
                ProductName1 = "Fanta",
                Description1 = "1.5l fanta orange can",
                QuantitySold1 = 30,
                CostPrice1 = 20,
                GrossValue1 = 600,
                NetProfit1 = 300
            });

            sales.Add(new SalesInfo
            {
                InventoryID1 = 4,
                ProductName1 = "Pie",
                Description1 = "salami and cheese",
                QuantitySold1 = 10,
                CostPrice1 = 25,
                GrossValue1 = 250,
                NetProfit1 = 125
            });
            sales.Add(new SalesInfo
            {
                InventoryID1 = 5,
                ProductName1 = "Pie",
                Description1 = "pepper steak",
                QuantitySold1 = 20,
                CostPrice1 = 25,
                GrossValue1 = 500,
                NetProfit1 = 250
            });
            sales.Add(new SalesInfo
            {
                InventoryID1 = 6,
                ProductName1 = "meat",
                Description1 = "beef",
                QuantitySold1 = 10,
                CostPrice1 = 35,
                GrossValue1 = 350,
                NetProfit1 = 175
            });

            sales.Add(new SalesInfo
            {
                InventoryID1 = 7,
                ProductName1 = "burger",
                Description1 = "cheese burger",
                QuantitySold1 = 50,
                CostPrice1 = 45,
                GrossValue1= 2250,
                NetProfit1 = 1125
            });

            sales.Add(new SalesInfo
            {
                InventoryID1 = 8,
                ProductName1 = "pizza",
                Description1 = "large mexican",
                QuantitySold1 = 20,
                CostPrice1 = 90,
                GrossValue1 = 1800,
                NetProfit1 = 900
            });
            sales.Add(new SalesInfo
            {
                InventoryID1 = 9,
                ProductName1 = "chocolate",
                Description1 = "lunch bar",
                QuantitySold1 = 72,
                CostPrice1 = 11,
                GrossValue1 = 792,
                NetProfit1 = 396
            });
            sales.Add(new SalesInfo
            {
                InventoryID1 = 10,
                ProductName1 = "chips",
                Description1 = "onion lays",
                QuantitySold1 = 66,
                CostPrice1 = 28,
                GrossValue1 = 1848,
                NetProfit1 = 924
            });
            dataGridView1.DataSource = sales;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (SalesInfo item in sales)
            {
                if (int.Parse(txtID.Text) == item.InventoryID1)
                {
                    item.ProductName1 = txtName.Text;
                    item.Description1 = txtDescription.Text;
                    item.QuantitySold1 = int.Parse(txtQualitySold.Text);
                    item.CostPrice1 = int.Parse(Costpricetb.Text);
                    item.GrossValue1 = int.Parse(Grossvaluetb.Text);
                    item.NetProfit1 = int.Parse(Netprofittb.Text);
                    break;

                }
            }
            dataGridView1.Update();
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (SalesInfo item in sales)
            {
                if (int.Parse(txtID.Text) == item.InventoryID1)
                {
                    txtName.Text = item.ProductName1;
                    txtDescription.Text = item.Description1;
                    txtQualitySold.Text = item.QuantitySold1.ToString();
                    Costpricetb.Text = item.CostPrice1.ToString();
                    Grossvaluetb.Text = item.GrossValue1.ToString();
                    Netprofittb.Text = item.NetProfit1.ToString();
                    break;

                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Qualitysoldtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
