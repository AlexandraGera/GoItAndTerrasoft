using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    class RepositoryProducts
    {
        public List<Product> repository;
        public RepositoryProducts()
        {
            repository = new List<Product>()
            {
                new Product() { Id = 1, Name = "new Olympus", Price = 594.99, Amount = 12, Discount = 25 },
                new Product() { Id = 2, Name = "Canon EOS Rebel Xti", Price = 120.00, Amount = 12, Discount = 0 },
                new Product() { Id = 3, Name = "new Sony Alpha", Price = 187.88, Amount = 7, Discount = 10 },
                new Product() { Id = 4, Name = "New Vision 30 x 60", Price = 5.99, Amount = 9, Discount = 6 },
                new Product() { Id = 5, Name = "Telescope HD Night Vision", Price = 30.31, Amount = 5, Discount = 0 },
                new Product() { Id = 6, Name = "new Camera Drone FPV 2.4Ghz", Price = 56.04, Amount = 3, Discount = 12 },
                new Product() { Id = 7, Name = "New Rokinon 24mm", Price = 399, Amount = 1, Discount = 0 },
                new Product() { Id = 8, Name = "new Vintage Polaroid J33 Land", Price = 8.88, Amount = 2, Discount = 3 },
                new Product() { Id = 9, Name = "Action Camera Full HD", Price = 28.29, Amount = 6, Discount = 15 },
                new Product() { Id = 10, Name = "new Explorers RC Quadcopter", Price = 8485, Amount = 5, Discount = 5 }
            };
        }

      
    }
}
