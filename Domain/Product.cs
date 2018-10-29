using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        [Display(Name="Production date"),DataType(DataType.Date)]
        public DateTime DateProd { get; set; }
        [Required(ErrorMessage = "champ obligatoire"),MaxLength(50,ErrorMessage = "Error"),StringLength(25,ErrorMessage = "Ne depasse pas 25 chars")]
        public String Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }
        [DataType(DataType.MultilineText)]
        public String Description { get; set; }
        public String ImageName { get; set; }
        public virtual Category Category { get; set; }
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
    }
}
