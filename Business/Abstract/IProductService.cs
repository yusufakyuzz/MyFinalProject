using Core.Utulities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllUnitPrice(decimal min,decimal max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IResult Add(Product product);
        IResult Update(Product product); 
        IResult Delete(Product product);
    }
}
