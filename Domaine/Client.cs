using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public class Client
    {
        [Key]
        public String CIN { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public virtual ICollection<Facture> Factures { get; set; }

    }
}
