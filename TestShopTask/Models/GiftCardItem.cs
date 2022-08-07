using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShopTask.Models
{
    public class GiftCardItem
    {
        public int Id { get; set; }
        public int Count    { get; set; }
        public int GiftCardId { get; set; }
        public int ProductId    { get; set; }

        public int ShopId { get; set; }

        public Product Product { get; set; }   
        public GiftCard GiftCard { get; set; }

        public Shop Shop { get; set; }
    }
}
