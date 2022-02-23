using CHUSHKA.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Models
{
    public class ProductVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public double Price { get; set; }

        public string Description { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public ProductType Products { get; set; }

        public virtual ICollection<SelectListItem> Orders { get; set; }
    }
}
