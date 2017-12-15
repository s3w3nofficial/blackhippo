using System;
using System.ComponentModel.DataAnnotations;

namespace blackhippo.Models
{
    public class ProductModel
    {

        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public virtual CategoryModel Category { get; set; }
    }
}