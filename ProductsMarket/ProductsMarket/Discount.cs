using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsMarket
{
    enum DiscountTypes
    {
        Fix,
        Procent
    }
    class Discount
    {
        public DiscountTypes Type { get; set; }
        public decimal DiscountAmount { get;set; }
        public Discount(DiscountTypes Type,decimal DiscountAmount)
        {
            this.Type = Type;
            this.DiscountAmount = DiscountAmount;
        }
    }
}
