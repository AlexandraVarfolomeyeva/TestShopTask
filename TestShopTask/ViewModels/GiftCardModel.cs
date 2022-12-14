using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShopTask.ViewModels
{
    public class GiftCardModel
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }
        
        [DisplayName("Номинальная сумма")]
        public decimal NominalSum { get; set; }
        
        [DisplayName("Остаток суммы (Сгоревшая сумма)")]
        public decimal LeftSum { get; set; }
        
        [DisplayName("Дата покупки карты")]
        public DateTime DateBought { get; set; }
        
        [DisplayName("Дата использования карты")]
        public DateTime? DateUsed { get; set; }
        
        [DisplayName("Дата прекращения работы")]
        public DateTime DateExpire { get; set; }
    }
}
