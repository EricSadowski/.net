using Guitar.Models;

namespace Guitar.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Slug => Name.Replace(' ', '-');
    }
}