using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;
namespace assignment6
{
    public partial class Form_total : System.Windows.Forms.Form
    {

                         
        public Form_total()
        {
            InitializeComponent();
            Data dt = new Data();
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
