using ASPPatterns.Chap3.Layered.Model;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Repository.Mappers
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Product");
            Id(x => x.Id).GeneratedBy.Sequence("SQ_PRODUCT");
            Map(x => x.Name).Column("Name");
            Component(x => x.Price,
                m => {
                    m.Map(x => x.SellingPrice).Column("SellingPrice");
                    m.Map(x => x.Savings).Column ("Savings");
                    m.Map(x => x.RRP).Column("RRP");
                   

                    });


        }
    }
}
