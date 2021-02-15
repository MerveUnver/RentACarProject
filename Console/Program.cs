using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var products in productManager.GetAll())
            {
                System.Console.WriteLine(products.Description);
            }
        }
    }
}
