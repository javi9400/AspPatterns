using ASPPatterns.Chap3.Layered.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Service
{
    public class ProductService
    {
        private Model.Service.ProductService _productService;
        public ProductService(Model.Service.ProductService productService)
        {
            _productService = productService;
        }

        public ProductListResponse GetAllProductsFor(ProductListRequest request)
        {

            ProductListResponse productListResponse = new ProductListResponse();
            try
            {
                IList<Product> productEntities = _productService.GetAllProductsFor(request.CustomerType);
                productListResponse.products = productEntities.ConvertToProductListViewModel();
                productListResponse.Success = true;
            }
            catch (Exception ex)
            {
                productListResponse.Success = false;
                productListResponse.Message = "An error ocurred";
            }

            return productListResponse;
        }
    }
}
