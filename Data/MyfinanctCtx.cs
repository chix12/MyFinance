
using Data.CustomConvantions;
using Data.MyConfiguration;
using Domaine;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public  class MyfinanctCtx: DbContext
    {
        public MyfinanctCtx():base("Name=Alias")
        {
         //   Database.SetInitializer(new contextinitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)//pour ajouter ou supprimer des convention 
        {
            // modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Conventions.Add(new DateTimeConvention());
            modelBuilder.Conventions.Add(new KeyConvention());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new AdresseConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }

    public class contextinitializer : DropCreateDatabaseIfModelChanges<MyfinanctCtx>
    {
        protected override void Seed(MyfinanctCtx context)//methode virtuelle dinjection des donnee
        {
            List<Category> categories= new List<Category>() {
                new Category { Name ="alimentaire"},
                new Category { Name="meuble"} ,
                new Category {Name ="medicament" }
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();


    }

    }

}
