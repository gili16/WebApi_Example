using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Product> Products { get; set; }
       // public virtual Customer Customer { get; set; }
    }
}
