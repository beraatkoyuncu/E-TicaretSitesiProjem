using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Dal : Data Access Layer  , Dao aynı anlamda kullanılıyor
    //Product tablosunun veri erişim katmanı
    //interface metotlari default public
    public interface IProductDal : IEntityRepository<Product> //IEntityRepository'i Product için yapılandırmış olduk
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
