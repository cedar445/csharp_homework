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
    public partial class Form_linq_res : Form
    {
        private readonly int id;
        public Form_linq_res(int id)
        {
            InitializeComponent();
            this.id = id;
            Order od=Data.orderService.GetById(id);
            label_id_res.Text = od.Id.ToString();
            label_customer_res.Text = od.Customer.Name;
            label_time_res.Text=od.CreateTime.ToString();
            label_good_res.Text = od.Details[0].Goods.Name.ToString();
            label_quantity_res.Text = od.Details[0].Quantity.ToString();
        }
    }
}
