using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL100
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();
        }

        NorthwindEntities context = new NorthwindEntities();
        private void query_Click(object sender, EventArgs e)
        {
            string userInput = ProductNameTextBox.Text.Trim();
            try
            {
                var query = from p in context.NewRestock()
                            where p.ProductName == userInput
                            select p;
                var q = query.First();
                int supNumber = Convert.ToInt16(q.Restocks);
                if (supNumber > 0)
                {
                    ynTextBox.Text = "Y";
                    howMany.Text = supNumber.ToString() + "單位";
                }
                else
                {
                    ynTextBox.Text = "N";
                }
                companyNameTextBox.Text = q.CompanyName;
                companyPhoneTextBox.Text = q.Phone;
                compyContactTextBox.Text = q.ContactName;

                var query2 = from od in context.Order_Details
                             join p in context.Products on od.ProductID equals p.ProductID
                             join o in context.Orders on od.OrderID equals o.OrderID
                             where p.ProductName == userInput
                             select new
                             {
                                 RequiredDate = o.RequiredDate,
                                 ShippedDate = o.ShippedDate,
                                 OrderId = od.OrderID,
                                 ProductName = p.ProductName,
                                 UnitsInStock = p.UnitsInStock,
                                 UnitsOnOrder = p.UnitsOnOrder,
                                 ReorderLevel = p.ReorderLevel,
                                 UnitPrice = od.UnitPrice,
                                 Quantity = od.Quantity,
                             };
                dataGridView1.DataSource = query2.ToList();
            }
            catch
            {
                MessageBox.Show("查無產品");
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
            }
        }
    }
}
