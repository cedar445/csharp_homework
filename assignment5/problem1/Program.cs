using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace problem1
{
    public class Order
    {
        public int id {  get; set; }
        public string name {  get; set; }
        public string customer {  get; set; }
        public int value {  get; set; }
        public Order() { }
        public Order(int  id, string name, string customer, int value)
        {
            this.id = id;
            this.name = name;
            this.customer = customer;
            this.value = value;
        }
        public override bool Equals(object obj)
        {
            Order other = obj as Order;
            return other != null && 
                other.id == id && 
                other.name == name && 
                other.customer == customer &&
                other.value == value;
        }
        public override string ToString()
        {
            return "id:" + id.ToString()
                +"\nname:"+name
                +"\ncustomer:"+customer
                +"\nvalue:"+value.ToString();
        }
    }
    public class OrderDetails
    {
        public Order order {  get; set; }
        public string orderDetails { get; set; }   
        public OrderDetails() { }
        public OrderDetails(Order od, string orderDetails)
        {
            this.order = od;
            this.orderDetails = orderDetails;
        }
        public override bool Equals(object obj)
        {
            OrderDetails other = obj as OrderDetails;
            return other != null && 
                other.order != null && 
                other.orderDetails == orderDetails;
        }
        public override string ToString()
        {
            return order.ToString()
                + "\notherDetails:" + orderDetails;
        }
    }
    public class OrderService
    {
        private List<OrderDetails> ods;
        public OrderService()
        {
            ods = new List<OrderDetails>();
        }
        public int FindOrder(OrderDetails od)//查
        {
            int i = 0;
            foreach(OrderDetails m in ods)
            {
                if (m.Equals(od))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public IEnumerable<OrderDetails> LinqID(int id)
        {
            return ods.Where(o => o.order.id == id).OrderByDescending(o => o.order.value);
        }
        public IEnumerable<OrderDetails> LinqName(string name)
        {
            return ods.Where(o => o.order.name == name).OrderByDescending(o => o.order.value);
        }
        public IEnumerable<OrderDetails> LinqCustomer(string customer)
        {
            return ods.Where(o => o.order.customer == customer).OrderByDescending(o => o.order.value);
        }
        public IEnumerable<OrderDetails> LinqValue(int value)
        {
            return ods.Where(o => o.order.value == value).OrderByDescending(o => o.order.value);
        }
        public void AddOrder(OrderDetails od)//增
        {
            if (FindOrder(od) != -1)
            {
                Console.WriteLine("Adding duplicated order");
            }
            else ods.Add(od); 
        }
        public void RemoveOrder(int index)//删
        {
            if (index >= ods.Count())
            {
                Console.WriteLine("Index is out if range");
            }
            else ods.RemoveAt(index);
        }
        public void ChangeOrderValue(OrderDetails od,int value)//改钱
        {
            if(FindOrder(od) == -1)
            {
                Console.WriteLine("Order not found");
            }
            ods[FindOrder(od)].order.value = value;
        }
        public void ChangeOrderDetails(OrderDetails od,string detail)//改细节
        {
            if (FindOrder(od) == -1)
            {
                Console.WriteLine("Order not found");
            }
            ods[FindOrder(od)].orderDetails = detail;
        }
    }

    internal class Program
    {
        
        public void Test1()
        {
            OrderService os = new OrderService();
            for (int i = 0; i <= 5; i++)
            {
                os.AddOrder(new OrderDetails(
                    new Order(i, "name", "customer" + i.ToString(), i * 100),
                    "detail" + i.ToString()
                    ));
            }
            OrderDetails ods = new OrderDetails(new Order(5, "name", "customer5", 500),"detail5");
            os.ChangeOrderValue(ods, 10);
            os.RemoveOrder(3);
            foreach (OrderDetails o in os.LinqName("name"))
            {
                Console.WriteLine(o.ToString()+"\n");
            }
        }
        public void Test2()
        {
            OrderService os = new OrderService();
            OrderDetails ods = new OrderDetails(new Order(5, "name", "customer5", 500), "detail5");
            os.AddOrder(ods);
            os.RemoveOrder(1);
            foreach(OrderDetails o in os.LinqName("name"))
            {
                Console.WriteLine(o.ToString() + "\n");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Test1();
            p.Test2();
            Console.ReadKey();
        }
    }
}
