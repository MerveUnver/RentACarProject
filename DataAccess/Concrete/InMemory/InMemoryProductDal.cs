using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{BrandId=1,ProductId=2,ColorId=4,DailyPrice=150,ModelYear=1995,Description="Kırmızı "},
            new Product{BrandId=2,ProductId=1,ColorId=1,DailyPrice=200,ModelYear=2005,Description="Gri"},
            new Product{BrandId=1,ProductId=3,ColorId=4,DailyPrice=150,ModelYear=2015,Description="Mavi"},
            new Product{BrandId=3,ProductId=5,ColorId=5,DailyPrice=300,ModelYear=2018,Description="Siyah"},
            new Product{BrandId=4,ProductId=4,ColorId=3,DailyPrice=100,ModelYear=2000,Description="Beyaz"},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product _productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

            _products.Remove(_productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product _productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _productToUpdate.DailyPrice = product.DailyPrice;

            _productToUpdate.Description = product.Description;

            _productToUpdate.ColorId = product.ColorId;

            _productToUpdate.BrandId = product.BrandId;
        }

        public List<Product> GetById(int ProductId)
        {
            return _products.Where(c => c.ProductId == ProductId).ToList();
        }
    }
}
