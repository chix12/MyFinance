using Data;
using Domaine;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MyfinanctCtx ctx = new MyfinanctCtx();
            IServiceProduct sp = new ServiceProduct();
            IServiceCategory sc = new ServiceCategory();

            Category c = new Category { Name = "vetements" };
            ctx.Categories.Add(c);
           Product p1 = new Product()
            {
                Name = "Prod1",
                Description = "description",
                Price = 2200,
                Quantity = 5,
                DateProd = DateTime.Now,
                Category = c


            };

            Product p2 = new Product()
            {
                Name = "Produit 2",
                Description = "description du produit 2",
                Price = 100,
                Quantity = 10,
                DateProd = DateTime.Now,
                Category = c


            };


            sp.Add(p1);
            sp.Add(p2);
            sc.Add(c);
           // sc.Commit();
            sp.Commit();
           // ctx.Products.Add(p1);
           // ctx.SaveChanges();//ne perend pas cpt au niveau de la base de données 
            Console.WriteLine("base crée");
            Console.ReadKey();
        }
    }
}
