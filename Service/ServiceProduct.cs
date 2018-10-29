using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domaine;
using Data;
using Data.Infrastructure;
using Infrastructure;
using MyFinance.Data.Infrastructure;
using ServicePattern;

namespace Service
{
    public class ServiceProduct : Service<Product> , IServiceProduct 
    {
        // MyfinanctCtx ctx = new MyfinanctCtx();
       static IDatabaseFactory dbf = new DatabaseFactory();
        // IRepositoryBase<Product> repo = new RepositoryBase<Product>(dbf);
       static IUnitOfWork uow = new UnitOfWork(dbf);
        public ServiceProduct():base(uow)
        {

        }

        public IEnumerable<Product> Get5MosExpensiveProducts()
        {
            var req = from p in GetMany()
                      orderby p.Price descending
                      select p;
            return req.Take(5);

        }

        public IEnumerable<Product> GetProductByClient(Client c)
        {
          var facture= uow.getRepository<Facture>().GetMany(f=>f.Client==c);

            var req = from f in facture
                    select f.Product;
            return req;

            
        }

        public IEnumerable<Product> GetProductsByCategory(Category C)
        {
            //return GetMany(p=>p.Category==C).OrderBy(p=>p.Price);
            var req = from p in GetMany()
                      where p.Category == C
                      select p;
            return req;
            
        }
        



        /* public void Add(Product p)
         {
             // ctx.Products.Add(p);
             //dbf.DataContext.Products.Add(p);
             //repo.Add(p);
             uow.getRepository<Product>().Add(p);
         }

         public void Commit()
         {
             //dbf.DataContext.SaveChanges();
             //  ctx.SaveChanges();
             uow.Commit();
         }*/
    }
}
