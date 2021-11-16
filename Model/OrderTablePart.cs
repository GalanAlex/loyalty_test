using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyTest.Model
{
    public class OrderTablePart
    {
        public Guid Id { get; set; }
        public int Position { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
