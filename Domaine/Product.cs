using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Product
    {
        public int ProductId { get; set; }
        [Display(Name="Production Date")]
        [DataType(DataType.Date)]
        public DateTime DateProd  { get; set; }
        [Required (ErrorMessage ="le nom est obligatoire ")]
        [StringLength(25,ErrorMessage = ("le nom ne doit pas deppase 50 caractere"))]
        [MaxLength(50)]
        public String Name { get; set; }
        [DataType(DataType.MultilineText)]
        public String Description { get; set; }
        public String ImageName { get; set; }
        public double Price { get; set; }
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }
       // [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("Category")]
        public  int? CategoryId { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
        public ICollection<Facture> Factures { get; set; }
    }
}
 