using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class Form_delete : Form
    {
        public Form_delete()
        {
            InitializeComponent();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_id.Text);
            Data.orderService.RemoveOrder(id);
            Close();
        }
    }
}
