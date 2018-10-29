using Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using System.Threading.Tasks;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MyfinanceContex ctx = new MyfinanceContex();
            Product p1 = new Product()
            {
                Name = "Prod1",
                Description = "description",
                Price = 2200,
                Quantity = 5,
                DateProd = DateTime.Now


            };
            
            ctx.Products.Add(p1);
            ctx.SaveChanges();
        }
    }
}
