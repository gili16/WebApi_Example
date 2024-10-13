using OrderDal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class OrderBL:IBL<Order>
    {
        private readonly IDal<Order> bookDal;
        public OrderBL(IDal<Order> bookDal)
        {
            this.bookDal = bookDal;
        }
        public void AddItem(Order book)
        {
            bookDal.AddItem(book);
            //book.Customer.Orders.Add(book);
        }

        public void deleteById(int id)
        {
            bookDal.RemoveItem(id);
        }

        //public int getAge(int id)
        //{

        //    return DateTime.Now.Year - bookDal.getById(id).YearPublish;
        //}

        public List<Order> getAll()
        {

            return bookDal.getAll();
            

        }

        public Order getById(int id)
        {
            return bookDal.getById(id);
        }

        public void update(int id, Order book)
        {
            bookDal.UpdateItem(id, book);
        }
    }
}
