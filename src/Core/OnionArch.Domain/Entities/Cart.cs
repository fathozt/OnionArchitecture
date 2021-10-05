using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Domain.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Sale { get; set; }
        public int Quantity { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
