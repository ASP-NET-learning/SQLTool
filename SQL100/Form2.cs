using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL100
{
    public partial class Form2 : Form
    {
        NorthwindEntities context = new NorthwindEntities();
        public Form2()
        {
            InitializeComponent();
            string[] comboBoxArray = new[]
            {
                "Employees" ,
                "Categories" ,
                "Customers" ,
                "Shippers" ,
                "Suppliers" ,
                "Orders" ,
                "Products" ,
                "OrderDetails" ,
                "Region" ,
                "Territories" ,
            };

            foreach (string comboBox in comboBoxArray)
            {
                comboBox1.Items.Add(comboBox);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            int length = Convert.ToInt32(textBox2.Text);

            try
            {
                Func<object> query = () =>
                {
                    switch(item)
                    {
                        case "Products":
                            var product = from p in context.Products select p;
                            return product.Take(length).ToList();

                        case "Orders":
                            var order = from o in context.Orders select o;
                            return order.Take(length).ToList();

                        case "Employees":
                            var employee = from emp in context.Employees select emp;
                            return employee.Take(length).ToList();

                        case "Categories":
                            var category = from cat in context.Categories select cat;
                            return category.Take(length).ToList();

                        case "Customers":
                            var customer = from cust in context.Customers select cust;
                            return customer.Take(length).ToList();

                        case "Shippers":
                            var ship = from s in context.Shippers select s;
                            return ship.Take(length).ToList();

                        case "Suppliers":
                            var supple = from sup in context.Suppliers select sup;
                            return supple.Take(length).ToList();

                        case "OrderDetails":
                            var detail = from od in context.Order_Details select od;
                            return detail.Take(length).ToList();

                        case "Region":
                            var region = from r in context.Regions select r;
                            return region.Take(length).ToList();

                        case "Territories":
                            var territory = from t in context.Territories select t;
                            return territory.Take(length).ToList();

                        default: return 0;
                    }
                };

                var reslut = query();
                dataGridView1.DataSource = reslut;
            } 
            catch 
            {
                textBox2.Text = "Not Find!";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string item = comboBox1.SelectedItem.ToString();

                // 定義一個委派，用於獲取表的總筆數

                Func<int> getDefaultLength = () =>
                {
                    switch (item)
                    {
                        case "Products": return context.Products.Count();
                        case "Orders": return context.Orders.Count();
                        case "Employees": return context.Employees.Count();
                        case "Categories": return context.Categories.Count();
                        case "Customers": return context.Customers.Count();
                        case "Shippers": return context.Shippers.Count();
                        case "Suppliers": return context.Suppliers.Count();
                        case "OrderDetails": return context.Order_Details.Count();
                        case "Region": return context.Regions.Count();
                        case "Territories": return context.Territories.Count();
                        default: return 0;
                    }
                };

                int result = getDefaultLength();
                textBox1.Text = result.ToString();


            }
            catch
            {
                textBox1.Text = "Error!";
            }

        }


    }
}

