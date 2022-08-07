using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShopTask.Models
{
    public class GiftCard
    {
        public int Id { get; set; }
        public decimal NominalSum { get; set; }
        public decimal LeftSum { get; set; }
        public DateTime DateBought { get; set; }
        public DateTime? DateUsed { get; set; }
        public DateTime DateExpire { get; set; }

        public bool IsUsed { get; set; } = false;
        public ICollection<GiftCardItem> GiftCardItems { get; set; }

        public GiftCard()
        {
            GiftCardItems = new HashSet<GiftCardItem>();
        }
    }
}
