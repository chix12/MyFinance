using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Provider
    {
        public int ProviderKey { get; set; }
        public String UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsApproved { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
