using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.CustomConvantions
{
  public  class KeyConvention:Convention
    {
        public KeyConvention()
        {
            this.Properties().Where(k=>k.Name.EndsWith("key")).Configure(k=>k.IsKey());
           
        }
    }   
}
