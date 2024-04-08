namespace assignment6
{
    partial class Form_add
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_customer = new System.Windows.Forms.Label();
            this.label_good = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_details = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_customer = new System.Windows.Forms.ComboBox();
            this.comboBox_good = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id.Location = new System.Drawing.Point(192, 30);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(67, 25);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID：";
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_customer.Location = new System.Drawing.Point(108, 93);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(151, 25);
            this.label_customer.TabIndex = 1;
            this.label_customer.Text = "Customer：";
            // 
            // label_good
            // 
            this.label_good.AutoSize = true;
            this.label_good.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_good.Location = new System.Drawing.Point(357, 205);
            this.label_good.Name = "label_good";
            this.label_good.Size = new System.Drawing.Size(95, 25);
            this.label_good.TabIndex = 2;
            this.label_good.Text = "Good：";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_quantity.Location = new System.Drawing.Point(301, 280);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(151, 25);
            this.label_quantity.TabIndex = 4;
            this.label_quantity.Text = "Quantity：";
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_details.Location = new System.Drawing.Point(122, 205);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(137, 25);
            this.label_details.TabIndex = 5;
            this.label_details.Text = "Details：";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_id.Location = new System.Drawing.Point(306, 25);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(134, 30);
            this.textBox_id.TabIndex = 8;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_quantity.Location = new System.Drawing.Point(478, 275);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(134, 30);
            this.textBox_quantity.TabIndex = 10;
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_add.Location = new System.Drawing.Point(612, 71);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(120, 47);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "确定";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Items.AddRange(new object[] {
            "customer1",
            "customer2"});
            this.comboBox_customer.Location = new System.Drawing.Point(306, 87);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(153, 31);
            this.comboBox_customer.TabIndex = 14;
            // 
            // comboBox_good
            // 
            this.comboBox_good.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_good.FormattingEnabled = true;
            this.comboBox_good.Items.AddRange(new object[] {
            "apple",
            "egg",
            "milk"});
            this.comboBox_good.Location = new System.Drawing.Point(478, 199);
            this.comboBox_good.Name = "comboBox_good";
            this.comboBox_good.Size = new System.Drawing.Size(153, 31);
            this.comboBox_good.TabIndex = 15;
            // 
            // Form_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_good);
            this.Controls.Add(this.comboBox_customer);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_details);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_good);
            this.Controls.Add(this.label_customer);
            this.Controls.Add(this.label_id);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_add";
            this.Text = "Form_add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.Label label_good;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_details;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private System.Windows.Forms.ComboBox comboBox_good;
    }
}