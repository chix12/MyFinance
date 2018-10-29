using Domaine;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.MyConfiguration
{
 public   class ProductConfiguration:EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            //Configurer la relation * *
            HasMany(p => p.Providers).WithMany(pr => pr.Products).Map(m=> { m.ToTable("Provindings");
                m.MapLeftKey("ProductId");
                m.MapRightKey("ProviderId");
            });
            //Configurer la relation 1 *
            HasRequired(p => p.Category).WithMany(pr => pr.Products).HasForeignKey(d=>d.CategoryId)
                .WillCascadeOnDelete(false);
            //Configurer l'heritage
            Map<Biological>(b => b.Requires("IsBiological").HasValue(1));
            Map<Chemical>(b => b.Requires("IsBiological").HasValue(0));




        }
    }
}
