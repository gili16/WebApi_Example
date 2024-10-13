using OrderDal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductBL:IBL<Product>
    {
        private readonly IDal<Product> bookDal;
        public ProductBL(IDal<Product> bookDal)
        {
            this.bookDal = bookDal;
        }
        public void AddItem(Product book)
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

        public List<Product> getAll()
        {

            List<Product> books = bookDal.getAll();
            foreach (var item in books)
            {
                item.Price = (int)(item.Price * 0.9);
            }
            return books;

        }

        public Product getById(int id)
        {
            return bookDal.getById(id);
        }

        public void update(int id, Product book)
        {
            bookDal.UpdateItem(id,book);
        }
    }
}
