﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
    public class Price
    {
        private IDiscountStrategy _discountStrategy = new NullDiscountStrategy();
        private decimal _rrp;
        private decimal _sellingPrice;

        public Price(decimal RRP, decimal SellingPrice)
        {
            this._rrp = RRP;
            this._sellingPrice = SellingPrice;

        }

        public void SetDiscountStrategy(IDiscountStrategy DiscountStrategy)
        {
            _discountStrategy = DiscountStrategy;
        }

        public decimal SellingPrice
        {
            get { return this._sellingPrice; }
        }

        public decimal RRP
        {
            get
            {
                return this._rrp;
            }
        }

        public decimal Discount
        {
            get
            {
                if (RRP > SellingPrice)
                    return (RRP - SellingPrice);
                else
                    return 0;
            }
        }

        public decimal Savings
        {
            get
            {
                if (RRP > SellingPrice)
                {
                    return 1 - (SellingPrice / RRP);

                }
                else
                    return 0;


            }
        }


    }
}
