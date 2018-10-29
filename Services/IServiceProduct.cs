using Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IServiceProduct : IService<Product>
    {
        IEnumerable<Product> GetProductByCategory(Category C);
        IEnumerable<Product> Get5MostExpensiveProducts();
        IEnumerable<Product> ProductsByClients(Client Cl);

    }
}
