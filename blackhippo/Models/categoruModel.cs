using System;
using System.ComponentModel.DataAnnotations;

namespace blackhippo.Models
{
    public class CategoryModel
    {
        [Key]
        public int ID { get; set; }
        public string Ttitle { get; set; }
    }
}