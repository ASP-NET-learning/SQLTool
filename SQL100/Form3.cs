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
    public partial class Form3 : Form
    {
        NorthwindEntities context = new NorthwindEntities();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            int InputText = Convert.ToInt16(textBox1.Text);
            try
            {
                var query = from o in context.Orders
                            join c in context.Customers on o.CustomerID equals c.CustomerID
                            where o.OrderID == InputText
                            select new
                            {
                                customer = o.CustomerID,
                                company = c.CompanyName,
                                shipDate = o.ShippedDate,
                                recipient = c.ContactName,
                                address =
                                    o.ShipPostalCode + " " +
                                    o.ShipCountry + " " +
                                    o.ShipCity + " " +
                                    o.ShipRegion + " " +
                                    o.ShipAddress,
                            };

                var qFirst = query.First();
                customerName.Text = qFirst.customer.ToString();
                companyName.Text = qFirst.company.ToString();
                contactName.Text = qFirst.recipient.ToString();
                shipAddress.Text = qFirst.address.ToString();
                shipDate.Text = qFirst.shipDate.ToString();

                var query2 = from o in context.Orders
                             join od in context.Order_Details on o.OrderID equals od.OrderID
                             where o.OrderID == InputText
                             let TotalPrice =
                                (double?)od.Quantity * (double?)od.UnitPrice * (1 - (double?)od.Discount ?? 0)
                             select new
                             {
                                 o.OrderID,
                                 o.CustomerID,
                                 total = TotalPrice
                             };


                var t = query2.Sum(to => to.total);
                totalPrice.Text = t.ToString();
                dataGridView1.DataSource = query2.ToList();



            }
            catch
            {
                MessageBox.Show("查無此訂單");
            }

            

            
            
            



        }
    }
}

/*
 

 */