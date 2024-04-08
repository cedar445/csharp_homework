namespace assignment6
{
    partial class Form_total
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
            this.panel_add = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.panel_total = new System.Windows.Forms.Panel();
            this.panel_linq = new System.Windows.Forms.Panel();
            this.button_linq = new System.Windows.Forms.Button();
            this.panel_delete = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.panel_add.SuspendLayout();
            this.panel_total.SuspendLayout();
            this.panel_linq.SuspendLayout();
            this.panel_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_add
            // 
            this.panel_add.Controls.Add(this.button_add);
            this.panel_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_add.Location = new System.Drawing.Point(0, 0);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(259, 189);
            this.panel_add.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_add.Location = new System.Drawing.Point(77, 64);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(90, 37);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel_total
            // 
            this.panel_total.Controls.Add(this.panel_linq);
            this.panel_total.Controls.Add(this.panel_delete);
            this.panel_total.Controls.Add(this.panel_add);
            this.panel_total.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_total.Location = new System.Drawing.Point(0, 0);
            this.panel_total.Name = "panel_total";
            this.panel_total.Size = new System.Drawing.Size(800, 189);
            this.panel_total.TabIndex = 0;
            this.panel_total.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_linq
            // 
            this.panel_linq.Controls.Add(this.button_linq);
            this.panel_linq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_linq.Location = new System.Drawing.Point(259, 0);
            this.panel_linq.Name = "panel_linq";
            this.panel_linq.Size = new System.Drawing.Size(285, 189);
            this.panel_linq.TabIndex = 3;
            // 
            // button_linq
            // 
            this.button_linq.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_linq.Location = new System.Drawing.Point(95, 64);
            this.button_linq.Name = "button_linq";
            this.button_linq.Size = new System.Drawing.Size(91, 37);
            this.button_linq.TabIndex = 0;
            this.button_linq.Text = "查找";
            this.button_linq.UseVisualStyleBackColor = true;
            this.button_linq.Click += new System.EventHandler(this.button_linq_Click);
            // 
            // panel_delete
            // 
            this.panel_delete.Controls.Add(this.button_delete);
            this.panel_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_delete.Location = new System.Drawing.Point(544, 0);
            this.panel_delete.Name = "panel_delete";
            this.panel_delete.Size = new System.Drawing.Size(256, 189);
            this.panel_delete.TabIndex = 2;
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_delete.Location = new System.Drawing.Point(94, 64);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(95, 37);
            this.button_delete.TabIndex = 0;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form_total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_total);
            this.Name = "Form_total";
            this.Text = "Form1";
            this.panel_add.ResumeLayout(false);
            this.panel_total.ResumeLayout(false);
            this.panel_linq.ResumeLayout(false);
            this.panel_delete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.Panel panel_total;
        private System.Windows.Forms.Panel panel_linq;
        private System.Windows.Forms.Panel panel_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_linq;
        private System.Windows.Forms.Button button_delete;
    }
}

