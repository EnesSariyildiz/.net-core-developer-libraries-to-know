using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.SRP
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static List<Product> products = new List<Product>();
        public Product()
        {
            products = new()
            {
                new(){Id=1,Name="Kalem 1"},
                new(){Id=1,Name="Kalem 2"},
                new(){Id=1,Name="Kalem 3"},
                new(){Id=1,Name="Kalem 4"},
                new(){Id=1,Name="Kalem 5"},
            };
        }
    }
}
