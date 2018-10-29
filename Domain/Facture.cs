using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Facture
    {
        [Key, Column (Order = 0)]
        [ForeignKey ("Product")]

        public int ProductFk { get; set; }
        [Key, Column(Order = 1)]

        public int ClientFk { get; set; }
        [Key, Column(Order = 1)]

        public Product Product { get; set; }
        [ForeignKey ("ClientFk")]

        public Client Client { get; set; }


    }
}
