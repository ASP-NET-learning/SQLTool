using System;
using System.Data;
using System.Linq;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;
using ZXing;

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

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDocument PD = new PrintDocument();
            PD.PrintPage += new PrintPageEventHandler(PD_PrintPage);

            PrintPreviewDialog PPD = new PrintPreviewDialog
            {
                Document = PD,
                Width = 800,  // 設置視窗寬度
                Height = 600  // 設置視窗高度
            };
            ((Form)PPD).Controls.OfType<PrintPreviewControl>().First().Zoom = 2.0;

            PPD.ShowDialog();
        }

        void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 10;
            int y = 10;

            // Print text
            // Print individual text box values
            printText("是否補充: " + ynTextBox.Text, x, y, e);
            printText("供應商名稱: " + companyNameTextBox.Text, x, y + 20, e);
            printText("供應商電話: " + companyPhoneTextBox.Text, x, y + 40, e);
            printText("聯絡人: " + compyContactTextBox.Text, x, y + 60, e);

            //條碼
            string serialNo = "103114201610040001";
            printText("條碼: " + serialNo, x, y + 140, e);

            // Print barcode
            e.Graphics.DrawImage(GetCode128(serialNo), x, y + 155, 200, 25);

            // Print QRCode
            e.Graphics.DrawImage(GetQRCode("22312216,,123,31603023,103114,abc,10," + serialNo), x + 125, y + 50, 82, 82);
        }

        private void printText(string text, int intX, int intY, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("新細明體", 8);
            g.DrawString(text, font, Brushes.Black, intX, intY);
        }

        private Image GetQRCode(string sText)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 82,
                    Width = 82
                }
            };
            return writer.Write(sText);
        }

        private Image GetCode128(string sText)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 75,
                    Width = 200,
                    PureBarcode = true
                }
            };
            return writer.Write(sText);
        }
    }
}
