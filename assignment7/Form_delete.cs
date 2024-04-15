using MySql.Data.MySqlClient;
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
            using (MySqlConnection conn = GetConnection())
            {           
                using (MySqlCommand cmd = new MySqlCommand
                    ("delete from Goods where OrdersId =" + id.ToString(), conn))
                {
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand
                    ("delete from Details where OrdersId =" + id.ToString(), conn))
                {
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand
                    ("delete from Orders where OrdersId =" + id.ToString(), conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            Close();
        }
        private MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "server=localhost;user id=root;password=156278Lsk;database=orderdata");
            connection.Open();
            return connection;
        }
    }
}
