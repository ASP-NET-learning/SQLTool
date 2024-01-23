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

            //------------------------------------

            double[] revenue = new double[3];
            for (int i = 0; i < years.Length; i++)
            {
                var queryRevenue = from re in context.Revenue(years[i]) select re;
                var yearRevenue = queryRevenue.First();
                double byYear = yearRevenue.Value;
                revenue[i] = byYear;
            }

            string y1996 = revenue[0].ToString("C0");
            re96.Text = y1996;

            string y1997 = revenue[1].ToString("C0");
            re97.Text = y1997;

            string y1998 = revenue[2].ToString("C0");
            re98.Text = y1998;

            double profit = revenue[2] - revenue[1];
            if(profit > 0) 
            {
                Growth.Text = $"有賺{profit:C0}元";
            }
            else if(profit < 0) 
            {
                Growth.Text = $"虧損{profit:C0}元";
            }
            else
            {
                Growth.Text = "沒賺沒賠";
            }


        }
        
    }
}
