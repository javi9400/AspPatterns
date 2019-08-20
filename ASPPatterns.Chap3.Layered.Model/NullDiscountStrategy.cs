using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
    public class NullDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscountsTo(decimal OriginalSalePrices)
        {
            return OriginalSalePrices;
        }
    }
}
