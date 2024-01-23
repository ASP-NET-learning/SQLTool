using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SQL100
{
    public partial class Form4 : Form
    {
        NorthwindEntities context = new NorthwindEntities();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            string[] years = new string[] {"1996", "1997", "1998"};
            string[] productArray = new string[3];
            string[] saleArray = new string[3];

            for (int i = 0; i < years.Length; i++) 
            {
                var query = from year in context.HotProduct(years[i])
                            select year;
                            
                var hotProduct = query.First();
                string name = hotProduct.ProductName.ToString();
                string volume = hotProduct.total.ToString();

                productArray[i] = name;
                saleArray[i] = volume;
            }

            textBox1.Text = productArray[0];
            saleText1.Text = saleArray[0];

            textBox2.Text = productArray[1];
            saleText2.Text = saleArray[1];

            textBox3.Text = productArray[2];
            saleText3.Text = saleArray[2];
        }


    }
}
