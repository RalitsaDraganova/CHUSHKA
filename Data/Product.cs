using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Data
{
    public enum ProductType { Food , Health , Cosmetic , Other}
    public class Product
    {
        public int Id { get; set; }

        public string Name{ get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public ProductType Products { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
