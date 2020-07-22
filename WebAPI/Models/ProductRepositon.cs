using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebAPI.Models
{
    public class ProductRepositon
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;
        public ProductRepositon() {

            Add(new Product { Name = "Tomato soup", Category = "Groceries", Price = 1.39M });
            Add(new Product { Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            Add(new Product { Name = "Hammer", Category = "Hardware", Price = 16.99M });
            Add(new Product { Name = "a", Category = "a", Price = 1M });


        }
        public async Task<Product> Add(Product item)
        {
            return await Task.Run(() =>
            {
                //throw new NotImplementedException();
                item.Id = _nextId++;
                products.Add(item);
                return item;
            });
        }




        public async Task<Product> Get(int id) {

            return await Task.Run(() =>
            {
                return products.Find(s => s.Id == id);
            });


        }


        public async Task<List<Product>> GetAll()
        {
            return await Task.Run(() =>
            {
                return products;
            });

        }

        public async Task Remove(int id)
        {
            await Task.Run(() =>
            {
                products.RemoveAll(p => p.Id == id);
            });

        }

        public async Task<bool> Update(Product item)
        {
            return await Task.Run(() =>
            {
                int index = products.FindIndex(p => p.Id == item.Id);
                if (index == -1)
                {
                    return false;
                }
                products.RemoveAt(index);
                products.Add(item);
                return true;
            });
        }
    }



    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}