using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDal
{
    public class ProductDal:IDal<Product>
    {
        //הזרקת תלות
        private readonly IContext context;
        public ProductDal(IContext context)
        {
            this.context = context;
        }

        public void AddItem(Product book)
        {
            context.Products.Add(book);
            context.Save();
        }

        public Product getById(int id)
        {
            return context.Products.FirstOrDefault(x => x.Id == id);
        }

        public List<Product> getAll()
        {
            return context.Products.ToList();
        }

        public void RemoveItem(int id)
        {
            context.Products.Remove(getById(id));
            context.Save();

        }

        public void UpdateItem(int id, Product book)
        {
            Product b = getById(id);
            b.Price = book.Price;
            b.Description = book.Description;
            b.Name = book.Name;
            b.ExpiryDate = book.ExpiryDate;
            context.Save();

        }
    }
}
