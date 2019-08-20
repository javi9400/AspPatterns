using ASPPatterns.Chap3.Layered.Model.Factory;
using ASPPatterns.Chap3.Layered.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model.Service
{
    public class ProductService
    {
        private IProductRepository _producRepository;
        public ProductService(IProductRepository productRepository)
        {
            _producRepository = productRepository;
        }

        public IList<Product> GetAllProductsFor(CustomerType customerType)
        {
            IDiscountStrategy discountStrategy = DiscountFactory.GetDiscountStrategyFor(customerType);
            IList<Product> products = _producRepository.FindAll();
            products.Apply(discountStrategy);

            return products;
        }
    }
}
