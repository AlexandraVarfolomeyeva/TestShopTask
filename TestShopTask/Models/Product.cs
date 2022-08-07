using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShopTask.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductsInShop> ProductsInShop { get; set; }
        public ICollection<GiftCardItem> GiftCardItems { get; set; }

        public Product()
        {
            GiftCardItems = new HashSet<GiftCardItem>();
            ProductsInShop = new HashSet<ProductsInShop>();
        }
    }
}
