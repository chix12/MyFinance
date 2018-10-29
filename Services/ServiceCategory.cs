using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceCategory : IServiceCategory
    {
        MyFinanceCtx ctx = new MyFinanceCtx();

        public void AddCategory (Category C)
        {
            ctx.Category.Add(C);
        }

        public void Commit ()
        {
            ctx.SaveChanges();
        }
    }
}
