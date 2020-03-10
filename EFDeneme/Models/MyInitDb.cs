using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeneme.Models
{
    public class MyInitDb : DropCreateDatabaseAlways<PazarContext>
    {
        protected override void Seed(PazarContext context)
        {
            context.Categories.Add(new Category
            { CategoryName = "Refreshments",
                Products = new List<Product>
                { new Product { ProductName = "Cola", UnitPrice=3.99m },
                    new Product {ProductName="Fanta" } }
            });
            context.Categories.Add(new Category
            {
                CategoryName="Snacks",
                Products=new List<Product>
                { new Product { ProductName="Cips",UnitPrice=7.99m},
                new Product { ProductName="Nuts"} }
            });
            context.Categories.Add(new Category
            {
                CategoryName = "Electronics",
                
            });
        }
    }
}
