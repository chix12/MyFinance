using Domaine;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.MyConfiguration
{
 public   class AdresseConfiguration: ComplexTypeConfiguration<Adresse>
    {

        public AdresseConfiguration()
        {
            Property(p => p.City).IsRequired();
            Property(p => p.StreetAddres).IsOptional().HasMaxLength(50);
        }


    }
}
