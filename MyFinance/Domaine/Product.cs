using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Product
    {
        public int ProductId { get; set; }
        public DateTime DateProd  { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public virtual Category Category { get; set; }
        public  int? CategoryId { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
    }
}
 