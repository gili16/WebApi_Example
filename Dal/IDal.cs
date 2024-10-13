using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDal
{
    public interface IDal<T>
    {
        public List<T> getAll();
        public T getById(int id);
        public void AddItem(T item);
        public void RemoveItem(int id);
        public void UpdateItem(int id, T item);
    }
}
