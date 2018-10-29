using Data;
using Data.Infrastructure;
using Domain;
using Infrastructure;
using MyFinance.Data.Infrastructure;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceProduct : Service<Product>, IServiceProduct
    {
        //MyFinanceCtx ctx = new MyFinanceCtx();
        static IDatabaseFactory dbf = new DatabaseFactory();

        //IRepositoryBase<Product> Repo = new RepositoryBase<Product>(dbf);
          
        //Unit Of work design pattern
        static IUnitOfWork uow = new UnitOfWork(dbf);
        public ServiceProduct() : base(uow)
        {
               
        }

        public IEnumerable<Product> GetProductByCategory(Category C)
        {
            // return GetMany(product => product.Category == C).
            //     OrderBy(product => product.Price);

            //Using Link
            var req = from product in GetMany()
                      where product.Category == C
                      select product;
            return req;
        }

        public IEnumerable<Product> Get5MostExpensiveProducts()
        {
            var req = from product in GetMany()
                      orderby product.Price descending
                      select product;

            return req.Take(5);
        }

        public IEnumerable<Product> ProductsByClients(Client Cl)
        {   
           var ListFacture = uow.getRepository<Facture>().
                GetMany().
                Where(facture => facture.Client == Cl);
            var req = from facture in ListFacture
                      select facture.Product;

            return req;
        }
    }
}
