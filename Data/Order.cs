using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Data
{
    public class Order
    {
        public int Id{ get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Count{ get; set; }

        public DateTime OrderOn { get; set; }

        
    }
}
