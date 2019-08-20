using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model.Factory
{
    public static class DiscountFactory
    {
        public static  IDiscountStrategy GetDiscountStrategyFor(CustomerType customerType)
        {
            switch(customerType)
            {
                case CustomerType.Trade:
                    return new TradeDiscountStrategy();
                default:
                    return new NullDiscountStrategy();
            }
        }
    }
}
