using System;

namespace ASPPatterns.Chap3.Layered.Model
{
    public class TradeDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscountsTo(decimal OriginalSalePrices)
        {
            decimal price = OriginalSalePrices;
            price = price * 0.45M;

            return price;
        }
    }
}
