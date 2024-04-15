using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OrderApp;
namespace assignment6
{
    public partial class Form_linq_res : Form
    {
        private readonly int id;
        public Form_linq_res(int id)
        {
            InitializeComponent();
            this.id = id;
            
            int customerid = 1;
            string customername = "";
            int goodid = 1;
            string goodname = "";
            int detailsid= 1;
            int quantity = 1;
            string time = "";
            using (MySqlConnection conn = GetConnection())
            {
                String sql1 = "select * from Orders where OrdersId = "+id.ToString();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql1, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            customerid = int.Parse(row[1].ToString());
                            time = row[2].ToString();
                        }
                    }
                }
                String sql2 = "select * from Details where OrdersId = " + id.ToString();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql2, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            quantity = int.Parse(row[2].ToString());
                        }
                    }
                }
                String sql3 = "select * from Customer where CustomerId = " + customerid.ToString();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql3, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            customername = row[1].ToString();
                        }
                    }
                }
                String sql4 = "select * from Goods where OrdersId = " + id.ToString();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql4, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            goodname = row[3].ToString();
                        }
                    }
                }
            }
            label_id_res.Text = id.ToString();
            label_customer_res.Text = customername;
            label_time_res.Text = time;
            label_good_res.Text = goodname;
            label_quantity_res.Text = quantity.ToString();
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
