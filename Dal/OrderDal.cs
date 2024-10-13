using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDal
{
    public class OrderDal:IDal<Order>
    {
        //הזרקת תלות
        private readonly IContext context;
        public OrderDal(IContext context)
        {
            this.context = context;
        }

        public void AddItem(Order book)
        {
            context.Orders.Add(book);
             context.Save();

        }

        public Order getById(int id)
        {
            return context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public List<Order> getAll()
        {
            return context.Orders.ToList();
        }

        public void RemoveItem(int id)
        {
            context.Orders.Remove(getById(id));
            context.Save();

        }

        public void UpdateItem(int id, Order book)
        {
            Order b = getById(id);
            b.Date = book.Date;
            
            b.Products.Clear();
            foreach(var item in book.Products)
            {
                b.Products.Add(item);
            }
            context.Save();

        }
    }
}
