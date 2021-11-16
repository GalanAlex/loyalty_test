using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyTest.Model
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public Contact Contact { get; set; }
        public List<OrderTablePart> OrderTableParts { get; set; }
        
    }
}
 