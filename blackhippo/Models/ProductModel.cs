using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace blackhippo.Models
{
    
    public class ProductModel : DbContext
    {

        public ProductModel(DbContextOptions<ProductModel> options)
            : base(options)
        { }

        public DbSet<Product> Product { get; set; }
    }

    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }

        private IEquatable<CategoryModel> category;

        public virtual IEquatable<CategoryModel> GetCategory()
        {
            return category;
        }

        public virtual void SetCategory(IEquatable<CategoryModel> value)
        {
            category = value;
        }
    }
}