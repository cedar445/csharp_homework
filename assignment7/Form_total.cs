using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OrderApp;
namespace assignment6
{
    public partial class Form_total : System.Windows.Forms.Form
    {

                         
        public Form_total()
        {
            InitializeComponent();
            Data dt = new Data();
            InitOrder();       
        }
        private void InitOrder()
        {
            //Data dt = new Data();
            /*
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand
                    ("insert into `Customer` values(1,'li'),(2,'zhang')", connection))
                {
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand
                    ("insert into `Orders` values(1,1,@Time1),(2,2,@Time2)", connection))
                {
                    cmd.Parameters.AddWithValue("@Time1", DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@Time2", DateTime.Now.ToString());
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand
                    ("insert into `Details` values(1,1,10),(1,2,61),(2,2,10)", connection))
                {
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand
                    ("insert into `Goods` values(1,1,1,'apple',100.0),(1,1,2,'egg',50.0),(2,2,2,'egg',200.0)", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            */
            this.datas.Columns.Add("id", "id");
            this.datas.Columns.Add("customerid", "customerid");
            this.datas.Columns.Add("CreateTime", "CreateTime");
            //List<Order> res = Data.orderService.QueryAll();
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "select * from Orders";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            List<string> rowData = new List<string>();
                            foreach (object field in row.ItemArray)
                            {
                                rowData.Add(field.ToString());
                            }
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(this.datas);  // 这里假设 this.datas 是您的 DataGridView 的实例名
                            // 将 rowData 的元素分别设置到新行的单元格中
                            newRow.Cells[0].Value = rowData[0];
                            newRow.Cells[1].Value = rowData[1];
                            newRow.Cells[2].Value = rowData[2];
                            // 将完整的行添加到 DataGridView 中
                            this.datas.Rows.Add(newRow);
                        }
                    }
                }
            }
            /*
            for (int i = 0; i < res.Count; i++)
            {
                this.datas.Rows.Add(res[i].Id.ToString(),
                    res[i].Customer.Name.ToString(),
                    res[i].TotalPrice.ToString());
            }
            */

        }

        private MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "server=localhost;user id=root;password=156278Lsk;database=orderdata");
            connection.Open();
            return connection;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {

            Form_add form_Add = new Form_add();
            form_Add.Show();
        }

        private void button_linq_Click(object sender, EventArgs e)
        {
            Form_linq form_Linq = new Form_linq();
            form_Linq.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Form_delete form_Delete = new Form_delete();
            form_Delete.Show();
        }

        private void Form_total_Activated(object sender, EventArgs e)
        {
            this.datas.Rows.Clear();
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "select * from Orders";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            List<string> rowData = new List<string>();
                            foreach (object field in row.ItemArray)
                            {
                                rowData.Add(field.ToString());
                            }
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(this.datas);  // 这里假设 this.datas 是您的 DataGridView 的实例名
                            // 将 rowData 的元素分别设置到新行的单元格中
                            newRow.Cells[0].Value = rowData[0];
                            newRow.Cells[1].Value = rowData[1];
                            newRow.Cells[2].Value = rowData[2];
                            // 将完整的行添加到 DataGridView 中
                            this.datas.Rows.Add(newRow);
                        }
                    }
                }
            }
        }
    }
    public class Data
    {
        public static OrderService orderService=new OrderService();
        public static Goods apple = new Goods(1, "apple", 10.0f);
        public static Goods egg = new Goods(2, "egg", 1.2f);
        public static Goods milk = new Goods(3, "milk", 50f);
        public static Customer customer1 = new Customer(1, "Customer1");
        public static Customer customer2 = new Customer(2, "Customer2");
        public Data()
        {
            Order order1 = new Order(1, customer1, new DateTime(2021, 3, 21));
            order1.AddDetails(new OrderDetail(apple, 80));
            order1.AddDetails(new OrderDetail(egg, 200));
            order1.AddDetails(new OrderDetail(milk, 10));

            Order order2 = new Order(2, customer2, new DateTime(2021, 3, 21));
            order2.AddDetails(new OrderDetail(egg, 200));
            order2.AddDetails(new OrderDetail(milk, 10));

            Order order3 = new Order(3, customer2, new DateTime(2021, 3, 21));
            order3.AddDetails(new OrderDetail(apple, 80));
            order3.AddDetails(new OrderDetail(milk, 10));

            orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
        }
    }
}
