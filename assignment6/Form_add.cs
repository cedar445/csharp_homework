using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;
namespace assignment6
{
    public partial class Form_add : System.Windows.Forms.Form
    {
        public Form_add()
        {
            InitializeComponent();         
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int id= int.Parse(textBox_id.Text);
            string cus = comboBox_customer.Text;
            Customer resc;
            if (cus == "customer1")
            {
                resc = new Customer(1, "customer1");
            }
            else
            {
                resc = new Customer(2, "customer2");
            }
            string gd = comboBox_good.Text;
            Goods resg;
            if (gd == "apple")
            {
                resg = new Goods(1, "apple", 10.0f);
            }
            else if(gd == "egg")
            {
                resg = new Goods(2, "egg", 1.2f);
            }
            else
            {
                resg = new Goods(3, "milk", 50.0f);
            }
            int quantity=int.Parse(textBox_quantity.Text);
            DateTime dt = DateTime.Now;
            Order od = new Order(id,resc,dt);
            Data.orderService.AddOrder(od);
            od.AddDetails(new OrderDetail(resg, quantity));
            Close();
        }
    }
}
