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
using MySql.Data.MySqlClient;
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
            int quantity = int.Parse(textBox_quantity.Text);
            int customerid;
            int goodid;
            //Customer resc;
            if (cus == "li")
            {
                //resc = new Customer(1, "customer1");
                customerid = 1;
            }
            else
            {
                //resc = new Customer(2, "customer2");
                customerid = 2;
            }
            string gd = comboBox_good.Text;
            //Goods resg;
            if (gd == "apple")
            {
                //resg = new Goods(1, "apple", 100.0f);
                goodid = 1;
            }
            else if(gd == "egg")
            {
                //resg = new Goods(2, "egg", 50.0f);
                goodid = 2;

            }
            else
            {
                //resg = new Goods(3, "milk", 200.0f);
                goodid = 3;
            }
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand
                ("insert into `Orders` values(@id,@customerid,@Time)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@customerid", customerid);
                    cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString());
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand
                ("insert into `Details` values(0,@orderid,@quantity)", conn))
                {
                    
                    cmd.Parameters.AddWithValue("@orderid", id);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.ExecuteNonQuery();
                }
            }
            DateTime dt = DateTime.Now;
            Close();
        }
        private MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "server=localhost;user id=root;password=156278Lsk;database=orderdata");
            connection.Open();
            return connection;
        }

        private void comboBox_customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
