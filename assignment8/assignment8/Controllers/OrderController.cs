using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderApp;
using System.Data;

namespace assignment8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        //private readonly OrderContext orderDb;
        private OrderService ods;
        public OrderController(OrderService ods)
        {
            this.ods = ods;
        }
        // GET: api/order/{id}  id为路径参数
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = ods.GetOrder(id.ToString());
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }
        // POST: api/order
        [HttpPost]
        public ActionResult<Order> PostOrder(Order od)
        {
            try
            {
                ods.AddOrder(od);
                //orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                String error = (e.InnerException == null) ? e.Message
                    : e.InnerException.Message;
                return BadRequest(error);
            }
            return od;
        }
        // PUT: api/order/{id}
        
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(string id, Order od)
        {
            if (ods.GetOrder(id) == null)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                ods.UpdateOrder(od);
            }
            catch (Exception e)
            {
                String error = (e.InnerException == null) ? e.Message
                    : e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }
        
        // DELETE: api/order/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(string id)
        {
            try
            {
                ods.RemoveOrder(id);
            }
            catch (Exception e)
            {
                String error = (e.InnerException == null) ? e.Message
                   : e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }
    }
}
