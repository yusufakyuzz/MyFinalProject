using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
    {   
        // using ile tab tab yapıp içine contextimizi tanımlıyoruz.
        // addedEntity isminde bir değişken tanımlayıp burada ilk sırada listede olan kayıdın referansını
        // alıyoruz. State ile durumu alıyoruz. EntityState ile de added yapıyoruz. Sonra "EntityState"
        // hata verecek onu using veriyoruz.
        // orayıda yazdıktan sonra Save yapıyoruz.

       

       
    }
}
