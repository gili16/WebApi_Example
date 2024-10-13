using OrderDal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CustomerBL:IBL<Customer>
    {
        private readonly IDal<Customer> bookDal;
        public CustomerBL(IDal<Customer> bookDal)
        {
            this.bookDal = bookDal;
        }
        public void AddItem(Customer book)
        {
            bookDal.AddItem(book);
        }

        public void deleteById(int id)
        {
            bookDal.RemoveItem(id);
        }

        //public int getAge(int id)
        //{

        //    return DateTime.Now.Year - bookDal.getById(id).YearPublish;
        //}

        public List<Customer> getAll()
        {

            return bookDal.getAll();
            

        }

        public Customer getById(int id)
        {
            return bookDal.getById(id);
        }

        public void update(int id, Customer book)
        {
            bookDal.UpdateItem(id, book);
        }
    }
}
