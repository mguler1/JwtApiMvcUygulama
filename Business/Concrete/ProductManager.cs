using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class ProductManager:GenericManager<Products>,IProductService
    {
        public ProductManager(IGenericDal<Products> genericDal) : base(genericDal)
        {

        }
    }
}
