using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDal
{
    public class CustomerDal:IDal<Customer>
    {
        //הזרקת תלות
        private readonly IContext context;
        public CustomerDal(IContext context)
        {
            this.context = context;
        }

        public void AddItem(Customer book)
        {
            context.Customers.Add(book);
            context.Save();

        }

        public Customer getById(int id)
        {
            return context.Customers.FirstOrDefault(x => x.Id == id);
        }

        public List<Customer> getAll()
        {
            return context.Customers.ToList();
        }

        public void RemoveItem(int id)
        {
            context.Customers.Remove(getById(id));
            context.Save();

        }

        public void UpdateItem(int id, Customer book)
        {
            Customer b = getById(id);
            b.Name = book.Name;
            b.Age = book.Age;
            context.Save();

        }
    }
}
