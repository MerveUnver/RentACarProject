﻿using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),
                new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

      
    }

  
}
