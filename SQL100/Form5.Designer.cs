namespace SQL100
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ynTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.howMany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyPhoneTextBox = new System.Windows.Forms.TextBox();
            this.compyContactTextBox = new System.Windows.Forms.TextBox();
            this.query = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "返回首頁";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "查詢產品:";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(134, 17);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(248, 39);
            this.ProductNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "補充否?";
            // 
            // ynTextBox
            // 
            this.ynTextBox.Location = new System.Drawing.Point(134, 75);
            this.ynTextBox.Name = "ynTextBox";
            this.ynTextBox.ReadOnly = true;
            this.ynTextBox.Size = new System.Drawing.Size(57, 39);
            this.ynTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "補充多少?";
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(134, 123);
            this.howMany.Name = "howMany";
            this.howMany.ReadOnly = true;
            this.howMany.Size = new System.Drawing.Size(111, 39);
            this.howMany.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "供應商資訊";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "公司名稱:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "公司電話:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "聯絡人:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(691, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 31);
            this.label9.TabIndex = 7;
            this.label9.Text = "推薦補充清單";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(615, 123);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(290, 94);
            this.textBox2.TabIndex = 5;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(373, 119);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.ReadOnly = true;
            this.companyNameTextBox.Size = new System.Drawing.Size(198, 39);
            this.companyNameTextBox.TabIndex = 8;
            // 
            // companyPhoneTextBox
            // 
            this.companyPhoneTextBox.Location = new System.Drawing.Point(373, 168);
            this.companyPhoneTextBox.Name = "companyPhoneTextBox";
            this.companyPhoneTextBox.ReadOnly = true;
            this.companyPhoneTextBox.Size = new System.Drawing.Size(198, 39);
            this.companyPhoneTextBox.TabIndex = 9;
            // 
            // compyContactTextBox
            // 
            this.compyContactTextBox.Location = new System.Drawing.Point(373, 213);
            this.compyContactTextBox.Name = "compyContactTextBox";
            this.compyContactTextBox.ReadOnly = true;
            this.compyContactTextBox.Size = new System.Drawing.Size(198, 39);
            this.compyContactTextBox.TabIndex = 10;
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(388, 17);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(76, 39);
            this.query.TabIndex = 11;
            this.query.Text = "查詢";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(470, 17);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(76, 39);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "清空";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 347);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.query);
            this.Controls.Add(this.compyContactTextBox);
            this.Controls.Add(this.companyPhoneTextBox);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.howMany);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ynTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ynTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox howMany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox companyPhoneTextBox;
        private System.Windows.Forms.TextBox compyContactTextBox;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.Button Clear;
    }
}