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
    public partial class PlaceOrder : Form
    {
        DataTable dt = new DataTable();
        string Stud, Prod, dte, Del;
        double price = 0;
        double tot = 0;
        int quan = 0;
       
        public PlaceOrder()
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentOrder studOrder = new StudentOrder();
            this.Hide();
            studOrder.Show();
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Student_Name", typeof(string));
            dt.Columns.Add("Product_Name", typeof(string));
            dt.Columns.Add("Unit_Price", typeof(double));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Total_Price", typeof(double));
            dt.Columns.Add("Order_Date", typeof(string));
            dt.Columns.Add("Delivery_Status", typeof(string));
        }

        public void NewOrder(string Studname, string Prodname, double unit, int quantity, double total, string date, string delivery)
        {
            dt.Rows.Add(Studname, Prodname, unit, quantity, total, date, delivery);
            dataGridView1.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                string nme = txtName.Text;
                DataRow dr = dt.Rows[i];
                if (dr["Student_Name"] == nme)
                {
                    dr.Delete();
                }
            }
            dt.AcceptChanges();
            dataGridView1.Refresh();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            this.Hide();
            main.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(name))
                    {
                        row.Selected = true;
                        EventReftxt();
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = tbxStudent.Text;
            string product = tbxProduct.Text;
            double unit = double.Parse(tbxPrice.Text);
            int quantity = int.Parse(tbxQuantity.Text);
            double Total = 0;
            if ((unit != price) || (quantity != quan))
            {
                Total = unit * quantity;
                tbxTotal.Text = Convert.ToString(Total);
            }
            else
            {
                Total = double.Parse(tbxTotal.Text);
            }
            string date = tbxDate.Text;
            string delivery = cbxStatus.Text;
            DataRow dr = dt.AsEnumerable().Where(r => ((string)r["Student_Name"]).Equals(Stud)).First();
            dr["Student_Name"] = name;
            dr["Product_Name"] = product;
            dr["Unit_Price"] = unit;
            dr["Quantity"] = quantity;
            dr["Total_Price"] = Total;
            dr["Order_Date"] = date;
            dr["Delivery_Status"] = delivery;
            dataGridView1.Refresh();

        }

        public void EventReftxt()
        {
            tbxStudent.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxProduct.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxQuantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxTotal.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxDate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbxStatus.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Stud = tbxStudent.Text;
            Prod = tbxProduct.Text;
            price = double.Parse(tbxPrice.Text);
            quan = int.Parse(tbxQuantity.Text);
            tot = double.Parse(tbxTotal.Text);
            dte = tbxDate.Text;
            Del = cbxStatus.Text;
        }
    }
}
