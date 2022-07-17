using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithTypesAndBrandsSpecification : BaseSpecifications<Product>
    {
        public ProductWithTypesAndBrandsSpecification()
        {
            AddIncludeI(x=>x.ProductBrand);
            AddIncludeI(x=>x.ProductType);
        }

        public ProductWithTypesAndBrandsSpecification(int id) 
        : base(x=>x.Id==id)
        {
            AddIncludeI(x=>x.ProductBrand);
            AddIncludeI(x=>x.ProductType);
        }
    }
}