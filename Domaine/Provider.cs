using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
  public  class Provider
    {
        public int Providerkey { get; set; }
        public String UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsApproved { get; set; }
        [Required(ErrorMessage = "Forma Email")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required(ErrorMessage ="Password obligatoir")]
        public String Password { get; set; }
        [Required(ErrorMessage = "Password obligatoir")]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password",ErrorMessage ="Comfirme mdp")] 
        public String ConfimPassword { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
