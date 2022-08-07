using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShopTask.Models;
using TestShopTask.ViewModels;

namespace TestShopTask
{
    public static class GetData
    {
        public const string UsedStr = "Использованные карты";
        public const string UnusedStr = "Неиспользованные карты";
        public static List<GiftCardModel> GetGiftCards(ShopContext context)
        {
            List<GiftCardModel> giftCards = context.GiftCards.Select(x => new GiftCardModel 
            { 
                Id=x.Id, 
                DateBought=x.DateBought,
                DateExpire=x.DateExpire,
                DateUsed=x.DateUsed,
                LeftSum=x.LeftSum,
                NominalSum=x.NominalSum
            }).ToList();

            return giftCards;
        }

        public static List<ProductModel> GetProducts(ShopContext context)
        {
            List<ProductModel> products = context.Products.Select(x => new ProductModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price
            }).ToList();

            return products;
        }

        public static List<ShopModel> GetShops(ShopContext context)
        {
            List<ShopModel> shops = context.Shops.Select(x => new ShopModel
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address
            }).ToList();

            return shops;
        }

        public static List<ProductsInShopModel> GetProductsInShops(ShopContext context)
        {
            List<ProductsInShopModel> products = context.ProductsInShop.Select(x => new ProductsInShopModel
            {
                Id = x.Id,
                ProductId=x.ProductId,
                ShopId=x.ShopId,
                Count =x.Count,
                Price=x.Product.Price,
                ProductName=x.Product.Name,
                ShopName=x.Shop.Name
            }).ToList();

            return products;
        }
        public static List<GiftCardProductModel> GetGiftCardProducts(ShopContext context)
        {
            List<GiftCardProductModel> products = context.GiftCardItems.Select(x => new GiftCardProductModel
            {
                Id = x.Id,
                ProductName = x.Product.Name,
                Price = x.Product.Price,
                Count =x.Count,
                DateBought=x.GiftCard.DateBought,
                DateExpire=x.GiftCard.DateExpire,
                DateUsed  =x.GiftCard.DateUsed,
                GiftCardId=x.GiftCardId,
                ProductId=x.ProductId,
                LeftSum=x.GiftCard.LeftSum,
                NominalSum=x.GiftCard.NominalSum
            }).ToList();

            return products;
        }

        /// <summary>
        /// Получать информацию о количестве использованных/неиспользованных карт за выбранный период.
        /// </summary>
        /// <param name="context">Контекст БД</param>
        /// <param name="from">Дата ОТ</param>
        /// <param name="till">Дата ДО</param>
        /// <returns></returns>
        public static List<GiftCardsCountModel> CountCardsPeriod(ShopContext context, DateTime from, DateTime till)
        {
            // проверяем есть ли пересечение временного промежутка. Считаем, что если в это время карта действовала
            // (использованная или нет), то считаем ее
            List<GiftCardsCountModel> giftCards = context.GiftCards.Where(a => a.DateBought <= till && a.DateExpire >= from)
                .GroupBy(c => c.IsUsed).Select(c=>new GiftCardsCountModel { Type = c.Key ? UsedStr : UnusedStr, Count = c.Count()}).ToList();
            return giftCards;
        }

        /// <summary>
        /// Получать Сумму использованных/неиспользованных карт за выбранный период.
        /// </summary>
        /// <param name="context">Контекст БД</param>
        /// <param name="from">Дата ОТ</param>
        /// <param name="till">Дата ДО</param>
        /// <returns></returns>
        public static List<GiftCardsCountModel> NominalSumsPeriod(ShopContext context, DateTime from, DateTime till)
        {
            // проверяем есть ли пересечение временного промежутка. Считаем, что если в это время карта действовала
            // (использованная или нет), то считаем ее
            List<GiftCardsCountModel> giftCards = context.GiftCards.Where(a => a.DateBought <= till && a.DateExpire >= from)
                .GroupBy(c => new { c.NominalSum , c.IsUsed}).Select(c => new GiftCardsCountModel { 
                    Type = c.Key.IsUsed ? "Использованная: " + c.Key.NominalSum.ToString(): "Неиспользованная: " + c.Key.NominalSum.ToString(), 
                    Count = c.Count() }).ToList();
            return giftCards;
        }

        /// <summary>
        /// Получать сгоревшую (неиспользованную) сумму за выбранный период или по выбранной карте.
        /// </summary>
        /// <param name="context">Контекст БД</param>
        /// <param name="from">Дата ОТ</param>
        /// <param name="till">Дата ДО</param>
        /// <returns></returns>
        public static List<GiftCardsCountModel> LeftSumsPeriod(ShopContext context, DateTime from, DateTime till)
        {
            List<GiftCardsCountModel> giftCards = context.GiftCards.Where(a => a.DateUsed >= from && a.DateUsed <= till)
                .GroupBy(c => c.LeftSum).Select(c => new GiftCardsCountModel { Type = c.Key.ToString(), Count = c.Count() }).ToList();
            return giftCards;
        }

        /// <summary>
        /// Получать сгоревшую (неиспользованную) сумму за выбранный период или по выбранной карте.
        /// </summary>
        /// <param name="context">Контекст БД</param>
        /// <param name="idCard">Идентификатор карты</param>
        /// <returns></returns>
        public static List<GiftCardsSelectModel> LeftSumsCardId(ShopContext context, int idCard)
        {
            List<GiftCardsSelectModel> giftCards = context.GiftCards.Where(a => a.Id == idCard)
                .GroupBy(c => c.LeftSum).Select(c => new GiftCardsSelectModel { Type = c.Key.ToString() }).ToList();
            return giftCards;
        }

        /// <summary>
        /// Получать информацию о товарах, оплаченных конкретной картой.
        /// </summary>
        /// <param name="context">Контекст БД</param>
        /// <param name="idCard">Идентификатор карты</param>
        /// <returns></returns>
        public static List<GiftCardProductModel> ProductsBought(ShopContext context, int idCard)
        {
            List<GiftCardProductModel> products = context.GiftCardItems.Where(a => a.GiftCardId == idCard).Select(x => new GiftCardProductModel
            {
                Id = x.Id,
                ProductName = x.Product.Name,
                Price = x.Product.Price,
                Count = x.Count,
                DateBought = x.GiftCard.DateBought,
                DateExpire = x.GiftCard.DateExpire,
                DateUsed = x.GiftCard.DateUsed,
                GiftCardId = x.GiftCardId,
                ProductId = x.ProductId,
                LeftSum = x.GiftCard.LeftSum,
                NominalSum = x.GiftCard.NominalSum
            }).ToList();
            return products;
        }
        /// <summary>
        /// Получать информацию о количестве использованных карт в разрезе магазинов
        /// </summary>
        /// <param name="context">Контекст БД</param>
        /// <returns></returns>
        public static List<GiftCardsCountModel> CountCardsUsedInShop(ShopContext context)
        {
            var cards = context.GiftCardItems.GroupBy(c => new { c.GiftCardId, c.ShopId }).GroupBy(a=>a.Key.ShopId).Select(c => new GiftCardsCountModel { 
                Type = c.Key.ToString() + " магазин", Count = c.Count() }).ToList();
            return cards;
        }
    }
}
