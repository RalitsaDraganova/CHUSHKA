using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using CHUSHKA.Data;
//using CHUSHKA.Models;

namespace CHUSHKA.Models
{
    public class OrderVM
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public List<SelectListItem> Users { get; set; }

        public int ProductId { get; set; }
        [Required(ErrorMessage = "This field is required")]

        public List<SelectListItem> Products { get; set; }

        public int Count { get; set; }
       
        [DataType(DataType.Date)]
         [Display(Name = "Date of order :")]
         [Required(ErrorMessage = "This field is required")]
         public DateTime OrderOn { get; set; }


    }
}
