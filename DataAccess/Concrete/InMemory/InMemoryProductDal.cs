using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
             new Product{ProductId=1, CategoryId=1, ProductName="Computer", UnitPrice=5000, UnitsInStock=10},
             new Product{ProductId=2, CategoryId=1, ProductName="Phone", UnitPrice=7000, UnitsInStock=15},
             new Product{ProductId=3, CategoryId=2, ProductName="Camera", UnitPrice=500, UnitsInStock=3},
             new Product{ProductId=4, CategoryId=2, ProductName="TV", UnitPrice=3000, UnitsInStock=5},
             new Product{ProductId=5, CategoryId=2, ProductName="Mouse", UnitPrice=85, UnitsInStock=8}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            //foreach (var p in _products)
            //{
              //  if(product.ProductId == p.ProductId)
               // {
                 //   productToDelete = p;
                //}
            //}
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);

        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
          return  _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void UpDate(Product product)
        {
            //gonderdigim urun id sine sahip olan listedeki urunu bul
            Product productToUpDate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpDate.ProductName = product.ProductName;
            productToUpDate.CategoryId = product.CategoryId;
            productToUpDate.UnitPrice = product.UnitPrice;
            productToUpDate.UnitsInStock = product.UnitsInStock;


        }
    }
}
