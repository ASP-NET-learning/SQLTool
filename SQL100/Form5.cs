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
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            
        }
    }
}
