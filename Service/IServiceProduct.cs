using Domaine;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
  public interface IServiceProduct:IService<Product>
    {
         //void Commit();
        //void Add(Product p);
        IEnumerable<Product> GetProductsByCategory(Category C);
        IEnumerable<Product> Get5MosExpensiveProducts();
        IEnumerable<Product> GetProductByClient(Client c);
    }
}
