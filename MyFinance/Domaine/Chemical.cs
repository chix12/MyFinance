using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Chemical: Category
    {
        public int MyProperty { get; set; }
        public String City { get; set; }
        public String LabName { get; set; }
        public String StreetAddres { get; set; }
    }
}
