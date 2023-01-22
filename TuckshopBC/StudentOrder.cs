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
    public partial class StudentOrder : Form
    {
        public static List<InventoryInfo> inv = new List<InventoryInfo>();
        public StudentOrder()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            PlaceOrder track = new PlaceOrder();
            string name = txtStudentName.Text;
            string ProdName = txtProductName.Text;
            double Unit = double.Parse(txtUnitPrice.Text);
            int quantity = ((int)quantityNum.Value);
            double TotalPrice = Unit * quantity;
            string Date = tbxDate.Text;
            string Status = cbxStatus.Text;
            track.Show();
            track.NewOrder(name, ProdName, Unit, quantity, TotalPrice, Date, Status);
            this.Hide();    

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PlaceOrder back = new PlaceOrder();
            this.Hide();
            back.Show();
        }

    }
}
