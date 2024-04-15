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
    public partial class Form_linq : Form
    {
        public Form_linq()
        {
            InitializeComponent();
        }

        private void button_getRes_Click(object sender, EventArgs e)
        {
            int id=int.Parse(textBox_id.Text);
            Form_linq_res form_Linq_Res = new Form_linq_res(id);
            form_Linq_Res.Show();
        }
    }
}
