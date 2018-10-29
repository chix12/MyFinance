using Domaine;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFinanceWeb.Models
{
    public class ProductModel
    {
        
        [Display(Name = "Production Date")]
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }


        [Required(ErrorMessage = "le nom est obligatoire ")]
        [StringLength(25, ErrorMessage = ("le nom ne doit pas deppase 50 caractere"))]
        [MaxLength(50)]
        public String Name { get; set; }
        [DataType(DataType.MultilineText)]

        public String Description { get; set; }

        public String ImageName { get; set; }

        public double Price { get; set; }
        [Range(0, int.MaxValue)]

        public int Quantity { get; set; }

        public int? CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        
    }
}