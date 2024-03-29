﻿using ASPPatterns.Chap3.Layered.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Service
{
    public static class ProductMapperExtensionMethods
    {
        public static IList<ProductViewModel> ConvertToProductListViewModel( this IList<Model.Product> products)
        {
            IList<ProductViewModel> productViewModel = new List<ProductViewModel>();

            foreach (Model.Product p in products)
            {
                productViewModel.Add(p.ConvertToProductViewModel());

            }

            return productViewModel;
        }

        public static ProductViewModel ConvertToProductViewModel(this Model.Product product)
        {
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.ProductId = product.Id;
            productViewModel.Name = product.Name;
            productViewModel.RRP = String.Format("{0:C}",product.Price.RRP);
            productViewModel.SellingPrice = String.Format("{0:C}", product.Price.SellingPrice);

            if(product.Price.Discount>0)
            {
                productViewModel.Discount = String.Format("{0:C}", product.Price.Discount);
            }
            if(product.Price.Savings<1 && product.Price.Savings>0)
            {
                productViewModel.Savings = product.Price.Savings.ToString("#%");
            }

            return productViewModel;

        }
    }
}
