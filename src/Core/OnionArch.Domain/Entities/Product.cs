using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
        public int? Sale { get; set; }

        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<ProductImage> Images { get; set; }
    }
}
