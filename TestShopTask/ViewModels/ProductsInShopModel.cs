using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShopTask.ViewModels
{
    public class ProductsInShopModel
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Количество")]
        public int Count { get; set; }

        [DisplayName("Идентификатор магазина")]
        public int ShopId { get; set; }

        [DisplayName("Наименование магазина")]
        public string ShopName { get; set; }

        [DisplayName("Идентификатор продукта")]
        public int ProductId { get; set; }

        [DisplayName("Название продукта")]
        public string ProductName { get; set; }

        [DisplayName("Цена продукта")]
        public decimal Price { get; set; }
    }
}
