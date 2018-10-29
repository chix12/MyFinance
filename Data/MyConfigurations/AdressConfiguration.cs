﻿using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.MyConfigurations
{
    class AdressConfiguration : ComplexTypeConfiguration<Adresse>
    {
        public AdressConfiguration()
        {
            Property(adresse => adresse.City).IsRequired();
            Property(adresse => adresse.StreetAddress).IsOptional().HasMaxLength(50);
        }
    }
}
