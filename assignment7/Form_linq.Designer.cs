namespace assignment6
{
    partial class Form_linq
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_getRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id.Location = new System.Drawing.Point(219, 91);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(67, 25);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID：";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_id.Location = new System.Drawing.Point(475, 80);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 36);
            this.textBox_id.TabIndex = 1;
            // 
            // button_getRes
            // 
            this.button_getRes.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_getRes.Location = new System.Drawing.Point(332, 264);
            this.button_getRes.Name = "button_getRes";
            this.button_getRes.Size = new System.Drawing.Size(150, 49);
            this.button_getRes.TabIndex = 2;
            this.button_getRes.Text = "查询";
            this.button_getRes.UseVisualStyleBackColor = true;
            this.button_getRes.Click += new System.EventHandler(this.button_getRes_Click);
            // 
            // Form_linq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_getRes);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_id);
            this.Name = "Form_linq";
            this.Text = "Form_linq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_getRes;
    }
}