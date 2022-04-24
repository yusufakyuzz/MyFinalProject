using Business.Abstract;
using Business.Contants;
using Core.Utulities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }

            return new SuccessResult(Messages.ProductAdded);
            _productDal.Add(product);
        }

        public IResult Delete(Product product)
        {
            return new SuccessResult(Messages.ProductDeleted);
                _productDal.Delete(product);
        }

        public IDataResult<List<Product>> GetAll()
        {
            //if (DateTime.Now.Hour == 15)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MeintanceTime);
            //}
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductGetAll);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            // Listemdeki tüm kayıtlara bak daha sonra benim gönderdiğim id kategoriID ye eşitse onu bana ver
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.CategoryId==id),Messages.ProductGet);
        }

        public IDataResult<List<Product>> GetAllUnitPrice(decimal min, decimal max)
        {
           return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max),Messages.ProductGet);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MeintanceTime);
            }

            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(),Messages.ProductDetailDto);
        }

        public IResult Update(Product product)
        {
           return new SuccessResult(Messages.ProductUpdated);
            _productDal.Update(product);
        }
    }
}
