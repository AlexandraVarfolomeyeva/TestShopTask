using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShopTask.ViewModels
{
    public class ProductModel
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }
    }
}
