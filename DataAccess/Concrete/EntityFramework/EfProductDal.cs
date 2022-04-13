﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {   
        // using ile tab tab yapıp içine contextimizi tanımlıyoruz.
        // addedEntity isminde bir değişken tanımlayıp burada ilk sırada listede olan kayıdın referansını
        // alıyoruz. State ile durumu alıyoruz. EntityState ile de added yapıyoruz. Sonra "EntityState"
        // hata verecek onu using veriyoruz.
        // orayıda yazdıktan sonra Save yapıyoruz.

       

        public void Add(Product entity)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                var addedEntity=context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
           
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
                // tek kayıt döndüreceği için SingleOrDefault kullanıyoruz. Tek sonuç döndürmesi için
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
              return  filter == null 
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
                //Where şart demektir.

            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
