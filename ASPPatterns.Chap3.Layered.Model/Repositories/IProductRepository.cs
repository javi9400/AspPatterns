using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model.Repositories
{
    public interface IProductRepository
    {
        IList<Product> FindAll();
    }
}
