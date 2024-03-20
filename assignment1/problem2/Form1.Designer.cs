namespace problem2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cul = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputOp = new System.Windows.Forms.ComboBox();
            this.outputRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cul
            // 
            this.cul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cul.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cul.Location = new System.Drawing.Point(262, 286);
            this.cul.Name = "cul";
            this.cul.Size = new System.Drawing.Size(188, 61);
            this.cul.TabIndex = 0;
            this.cul.Text = "culculate";
            this.cul.UseVisualStyleBackColor = false;
            this.cul.Click += new System.EventHandler(this.button1_Click);
            // 
            // input1
            // 
            this.input1.BackColor = System.Drawing.SystemColors.Menu;
            this.input1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input1.Location = new System.Drawing.Point(86, 149);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(120, 38);
            this.input1.TabIndex = 1;
            this.input1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input2
            // 
            this.input2.BackColor = System.Drawing.SystemColors.Menu;
            this.input2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input2.Location = new System.Drawing.Point(406, 149);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(120, 38);
            this.input2.TabIndex = 2;
            this.input2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(574, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // inputOp
            // 
            this.inputOp.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputOp.FormattingEnabled = true;
            this.inputOp.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.inputOp.Location = new System.Drawing.Point(236, 149);
            this.inputOp.Name = "inputOp";
            this.inputOp.Size = new System.Drawing.Size(121, 35);
            this.inputOp.TabIndex = 5;
            this.inputOp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // outputRes
            // 
            this.outputRes.AutoSize = true;
            this.outputRes.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outputRes.Location = new System.Drawing.Point(664, 142);
            this.outputRes.Name = "outputRes";
            this.outputRes.Size = new System.Drawing.Size(96, 28);
            this.outputRes.TabIndex = 6;
            this.outputRes.Text = "result";
            this.outputRes.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputRes);
            this.Controls.Add(this.inputOp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.cul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cul;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputOp;
        private System.Windows.Forms.Label outputRes;
    }
}

