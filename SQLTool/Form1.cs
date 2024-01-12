using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            comboBox1.Items.Add("Customers");
            comboBox1.Items.Add("Products");
            comboBox1.Items.Add("Orders");

            
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
                // 
                if (defaultLength != length) 
                {
                    var query = from p in context.Products select p;
                    dataGridView1.DataSource = query.Take(length).ToList();
                }
                else
                {
                    var query = from p in context.Products select p;
                    dataGridView1.DataSource = query.Take(defaultLength).ToList();
                }

            }
            else if(item == "Orders")
            {
                var defaultLength = context.Orders.Count();
                if (defaultLength != length) 
                {
                    var query = from p in context.Orders select p;
                    dataGridView1.DataSource = query.Take(length).ToList();
                }
                else
                {
                    var query = from o in context.Orders select o;
                    dataGridView1.DataSource = query.ToList();
                }
                
            }
            else
            {
                var defaultLength = context.Customers.Count();
                if (defaultLength != length)
                {
                    var query = from p in context.Customers select p;
                    dataGridView1.DataSource = query.Take(length).ToList();
                }
                else
                {
                    var query = from o in context.Customers select o;
                    dataGridView1.DataSource = query.ToList();
                }
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
