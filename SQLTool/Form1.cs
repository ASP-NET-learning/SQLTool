using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 將要查詢的表名稱加入到下拉選單中
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
                "CustomerCustomerDemo" ,
                "CustomerDemographics" ,
                "Region" ,
                "Territories" ,
                "EmployeeTerritories" 
            };

            foreach ( string comboBox in comboBoxArray ) 
            {
                comboBox1.Items.Add( comboBox );
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            // 取得選取的表單名稱
            string item = (string)comboBox1.SelectedItem;
            //使用者輸入要找前筆資料 || 直接找全部資料 0是預設避免空值使用
            int length = Convert.ToInt32(textBox1.Text);
            //用LINQ查找結果顯示在dataGridView上

            if (item == "Products")
            {
                // 邏輯 : 讓使用者輸入要查找前幾筆如果不是該表總筆數就查詢指定的值，否則查整張表

                // 查找原始表有幾筆
                var defaultLength = context.Products.Count();
                var query = from p in context.Products select p;
                // 如果不是要找全部訂單就找使用者輸入的筆數，判斷條件 : 資料總筆數不等於使用者輸入以及輸入0情下預設是總筆數
                if (defaultLength != length && length != 0)
                { 
                    dataGridView1.DataSource = query.Take(length).ToList();
                }
                else
                {
                    dataGridView1.DataSource = query.Take(defaultLength).ToList();
                }

            }
            else if (item == "Orders")
            {
                var defaultLength = context.Orders.Count();
                var query = from o in context.Orders select o;
                if (defaultLength != length && length != 0) 
                {
                    dataGridView1.DataSource = query.Take(length).ToList();
                }
                else
                {
                    dataGridView1.DataSource = query.Take(defaultLength).ToList();
                }
            }
            else if(item == "Employees")
            {
                var defaultLength = context.Employees.Count();
                var query = from emp in context.Employees select emp;

                if (defaultLength != length && length!=0)
                {
                    dataGridView1.DataSource= query.Take(length).ToList();
                }
                else
                {
                    dataGridView1.DataSource = query.Take(defaultLength).ToList();
                }
            }
            else if (item == "Categories")
            {
                var defaultLength = context.Categories.Count();
                var query = from category in context.Categories select category;

                if(defaultLength != length && length != 0)
                {
                    dataGridView1.DataSource = query.Take(length).ToList() ;
                }
                else
                {
                    dataGridView1.DataSource = query.Take(defaultLength).ToList() ;
                }
            }
            else if(item == "Customers") 
            {
                var defaultLength = context.Customers.Count();
                var query = from customer in context.Customers select customer;

                if(defaultLength != length && length != 0)
                {
                    dataGridView1.DataSource = query.Take(length).ToList() ;
                }
                else
                {
                    dataGridView1.DataSource = query.Take(defaultLength).ToList();
                }
            }
            else if (item == "Shippers") 
            {
                var defaultLength = context.Shippers.Count();
                var query = from shipers in context.Shippers select shipers;
                if(defaultLength != length && length !=0) 
                {
                    dataGridView1.DataSource=query.Take(length).ToList() ;
                }
                else
                {
                    dataGridView1.DataSource = query.Take(defaultLength).ToList() ;
                }
            }
            else if (item == "Suppliers") 
            {
                var defaultLength = context.Suppliers.Count();
                var query = from supplier in context.Suppliers select supplier;
                if(defaultLength != length && length !=0) 
                {
                    dataGridView1.DataSource = query.Take(length).ToList();
                }
                else
                {
                    dataGridView1.DataSource = query.Take(defaultLength).ToList();
                }
            }
            else if (item == "OrderDetails") 
            {
                var defaultLength = context.Order_Details.Count();
                var query = from od in context.Order_Details select od;
                if(defaultLength != length && length !=0)
                {
                    dataGridView1.DataSource = query.Take(length).ToList();
                }
                else
                {
                    dataGridView1.DataSource = query.Take(defaultLength).ToList();
                }
            }
            else if (item == "Region") 
            {
                var defaultLength = context.Regions.Count();
                var query = from region in context.Regions select region;
                if(defaultLength != length && length !=0)
                {
                    dataGridView1.DataSource= query.Take(length).ToList();
                }
                else
                {
                    dataGridView1.DataSource = query.Take(defaultLength).ToList();
                }
            }
            else if (item == "Territories") // 領土
            {
                var defaultLength = context.Territories.Count();
                var query = from ter in context.Territories select ter;
                if(defaultLength != length && length !=0)
                {
                    dataGridView1.DataSource = query.Take(length).ToList();
                }
                else
                {
                    dataGridView1.DataSource = query.Take(defaultLength).ToList();
                }
            }
            else
            {
                button1.Text = "沒有資料!";
            }

            
        }

        private NorthwindEntities context = new NorthwindEntities();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
