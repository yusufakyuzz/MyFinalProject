using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{   // REPOSITORY 'i kısıtlama
    // class anahtarı : Burada referans tip olabilir anlamına gelir
    // IENTITY : IENTITY de olabilir veya bu veritabanı sınıflarını içeren sınıflar olabilir
    // new()   : new 'lenebilir olmalı 
    // böylelikle kısıtımız tam bir şekilde sadece veritabanı sınıflarını içeren classları getirilebilir oldu
    public interface IEntityRepository<T> where T:class,IEntity,new() 
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
