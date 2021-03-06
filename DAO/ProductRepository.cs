using System.Linq;
using Backend.DAO.Interface;
using System.Collections.Generic;
using Backend.Utils;
using Backend.Models;

namespace Backend.DAO
{
    public class ProductRepository : IProductRepository
    {
        private readonly DBContext DBContext;
        public ProductRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }

        public Product GetProductById(string productId)
        {
            Product product = this.DBContext.Product.FirstOrDefault(item => item.ProductId == productId);
            if (product != null)
            {
                this.DBContext.Entry(product).Reference(item => item.Category).Load();
            }
            return product;
        }

        public Product GetProductByProductName(string name)
        {
            Product product = this.DBContext.Product.FirstOrDefault(item => item.Name == name);
            if (product != null)
            {
                this.DBContext.Entry(product).Reference(item => item.Category).Load();
            }
            return product;
        }

        public (List<Product>, int) GetProducts(double min, double max, string name, string categoryId)
        {
            List<Product> products = this.DBContext.Product.Where(item => item.RetailPrice >= min && item.RetailPrice <= max && item.Name.Contains(name) && item.CategoryId.Contains(categoryId)).ToList();
            foreach (Product product in products)
            {
                if (product != null)
                {
                    this.DBContext.Entry(product).Reference(item => item.Category).Load();
                }
            }
            return (products, products.Count);
        }
    }
}