using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domaine;
using Data;
using ServicePattern;
using Data.Infrastructure;

namespace Service
{
    public class ServiceCategory : Service<Category>
    {
         MyfinanctCtx ctx = new MyfinanctCtx();
        static DatabaseFactory dbf = new DatabaseFactory();
        static  UnitOfWork uow = new UnitOfWork(dbf);

        public ServiceCategory() : base(uow)
        {
                
        }
        public void Add(Category c)
        {
            ctx.Categories.Add(c);
        }

        public void Commit()
        {
            ctx.SaveChanges();
        }
    }
}
