using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public class Facture
    {
        


        [Key,Column(Order =0)]
        [ForeignKey("Product")]
        public int ProductFk { get; set; }
        [Key, Column(Order = 1)]
        public String ClientFk { get; set; }
        [Key, Column(Order = 2)]
        public DateTime DateFacture { get; set; }
        public float prix { get; set; }
        [ForeignKey("ClientFk")]
        public Client Client { get; set; }
        public Product Product { get; set; }
    }
}
