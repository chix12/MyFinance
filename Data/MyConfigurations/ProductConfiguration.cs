using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.MyConfigurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            //Configurer la relation many to many entre product et category
            HasMany(provider => provider.Providers).
                WithMany(product => product.Products).
                Map(m => {
                    m.ToTable("Providings");
                    m.MapLeftKey("ProductId"); // la classe que je suis entrain de configurer
                    m.MapRightKey("ProviderId");
                }); //m est la table d'association entre product et category
                   
            //Configurer la relation one to many entre product et category 
            HasRequired(category => category.Category).
                WithMany(product => product.Products).
                HasForeignKey(category => category.CategoryId).
                WillCascadeOnDelete(false);

            //Configurer l'héritage
            //Si on va mapper la classe product on n'indique pas la classe
            Map<Biological>(biological => biological.Requires("IsBiological").HasValue(1));
            Map<Chemical>(chemical => chemical.Requires("IsChemical").HasValue(0));
        }
    }
}
