using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_17_EFCoreCRUDRelationships
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
