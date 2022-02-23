using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using CHUSHKA.Data;
using CHUSHKA.Models;

namespace CHUSHKA.Models
{
    public class UserVM
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]

        public string Username { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required")]

        [EnumDataType(typeof(RoleType))]

        public RoleType Role { get; set; }

        [NotMapped]
        public List<SelectListItem> Orders { get; set; }
    }
}
