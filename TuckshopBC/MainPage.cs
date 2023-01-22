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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            InventoryManagement inventoryManagement = new InventoryManagement();
            this.Hide();
            inventoryManagement.Show();
        }

        private void btnRecordsales_Click(object sender, EventArgs e)
        {
            SalesRecord salesrecord = new SalesRecord();
            this.Hide();
            salesrecord.Show();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            PlaceOrder placeorder = new PlaceOrder();
            placeorder.Show();
            this.Hide();
        }

        private void btnTrackOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
