using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWind.Entities.POCOEntities
{
   public class OrderDetail
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public Order Order { get; set; }
    }
}
