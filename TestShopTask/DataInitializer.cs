using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShopTask.Models;

namespace TestShopTask
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var shopsList = new List<Shop>()
            {
                new Shop(){ Name="first shop", Address="first address" },
                new Shop(){ Name="second shop", Address="second address" },
                new Shop(){ Name="third shop", Address="third address" }
            };
            shopsList.ForEach(s => context.Shops.Add(s));
            context.SaveChanges();
            
            //добавлены id для удобства дальшейшего заполнения бд
            var cardsList = new List<GiftCard>()
            {
                new GiftCard(){ Id = 1, NominalSum=1000, LeftSum=400, DateBought=DateTime.Now.AddDays(-10), DateExpire=DateTime.Now.AddDays(70), DateUsed=DateTime.Now, IsUsed=true},
                new GiftCard(){ Id = 2,NominalSum=5000, LeftSum=5000, DateBought=DateTime.Now.AddDays(-60), DateExpire=DateTime.Now.AddDays(20)},
                new GiftCard(){ Id = 3,NominalSum=1000, LeftSum=1000, DateBought=DateTime.Now, DateExpire=DateTime.Now.AddDays(80)},
                new GiftCard(){ Id = 4,NominalSum=5000, LeftSum=1, DateBought=DateTime.Now.AddDays(-10), DateExpire=DateTime.Now.AddDays(70), DateUsed=DateTime.Now.AddDays(-51), IsUsed=true},
                new GiftCard(){ Id = 5,NominalSum=500, LeftSum=500, DateBought=DateTime.Now.AddDays(-60), DateExpire=DateTime.Now.AddDays(20)},
                new GiftCard(){ Id = 6,NominalSum=1000, LeftSum=1000, DateBought=DateTime.Now, DateExpire=DateTime.Now.AddDays(80)},
                new GiftCard(){ Id = 7,NominalSum=1000, LeftSum=0, DateBought=DateTime.Now.AddDays(-70), DateExpire=DateTime.Now.AddDays(10), DateUsed=DateTime.Now.AddDays(-32), IsUsed=true},
                new GiftCard(){ Id = 8,NominalSum=5000, LeftSum=5000, DateBought=DateTime.Now.AddDays(-60), DateExpire=DateTime.Now.AddDays(20)},
                new GiftCard(){ Id = 9,NominalSum=1000, LeftSum=1000, DateBought=DateTime.Now, DateExpire=DateTime.Now.AddDays(80)},
                new GiftCard(){ Id = 10,NominalSum=500, LeftSum=200, DateBought=DateTime.Now.AddDays(-70), DateExpire=DateTime.Now.AddDays(10), DateUsed=DateTime.Now.AddDays(-4), IsUsed=true},
                new GiftCard(){ Id = 11,NominalSum=5000, LeftSum=400, DateBought=DateTime.Now.AddDays(-60), DateExpire=DateTime.Now.AddDays(20), DateUsed=DateTime.Now.AddDays(-20), IsUsed=true},
                new GiftCard(){ Id = 12,NominalSum=1000, LeftSum=1000, DateBought=DateTime.Now, DateExpire=DateTime.Now.AddDays(80)},
                new GiftCard(){ Id = 13,NominalSum=1000, LeftSum=0, DateBought=DateTime.Now.AddDays(-40), DateExpire=DateTime.Now.AddDays(40), DateUsed=DateTime.Now.AddDays(-32), IsUsed=true},
            };
            cardsList.ForEach(c => context.GiftCards.Add(c));
            context.SaveChanges();

            var productsList = new List<Product>()
            {
                new Product(){ Id = 1,Name="T-shirt", Price=300},
                new Product(){ Id = 2,Name="chair", Price=2000},
                new Product(){ Id = 3,Name="table", Price=4999},
                new Product(){ Id = 4,Name="lamp", Price=700},
                new Product(){ Id = 5,Name="mug", Price=100}
            };
            productsList.ForEach(e => context.Products.Add(e));
            context.SaveChanges();

            var productsInShopList = new List<ProductsInShop>()
            {
                new ProductsInShop(){Id = 1, Count=10, ProductId = 1, Product = productsList.Find(d=>d.Id == 1),
                Shop=shopsList.FirstOrDefault(), ShopId = shopsList.FirstOrDefault().Id},
                new ProductsInShop(){Id = 2, Count=20, ProductId = 2, Product = productsList.Find(d=>d.Id == 2),
                Shop=shopsList.FirstOrDefault(), ShopId = shopsList.FirstOrDefault().Id},
                new ProductsInShop(){Id = 3, Count=15, ProductId = 1, Product = productsList.Find(d=>d.Id == 1),
                Shop=shopsList.Find(d=>d.Id == 2), ShopId =2},
                new ProductsInShop(){Id = 4, Count=8, ProductId = 3, Product = productsList.Find(d=>d.Id == 3),
                Shop=shopsList.Find(d=>d.Id == 2), ShopId =2},
                new ProductsInShop(){Id = 5, Count=12, ProductId = 2, Product = productsList.Find(d=>d.Id == 2),
                Shop=shopsList.Find(d=>d.Id == 2), ShopId =2},
                new ProductsInShop(){Id = 6, Count=5, ProductId = productsList.FirstOrDefault().Id, Product = productsList.FirstOrDefault(),
                Shop=shopsList.Find(d=>d.Id == 3), ShopId =3}
            };
            productsInShopList.ForEach(e => context.ProductsInShop.Add(e));
            context.SaveChanges();


            var giftCardItemsList = new List<GiftCardItem>()
            {
                //2 T-shirt
                new GiftCardItem(){ Count=2, GiftCard=cardsList.Find(d=>d.Id == 1), GiftCardId=1,
                Product= productsList.Find(d=>d.Id == 1), ProductId= 1, ShopId = 1, Shop = shopsList.Find(d=>d.Id == 1)},
                // 1 table
                new GiftCardItem(){ Count=1, GiftCard=cardsList.Find(d=>d.Id == 4), GiftCardId=4,
                Product= productsList.Find(d=>d.Id == 3), ProductId= 3, ShopId = 2, Shop = shopsList.Find(d=>d.Id == 2)},
                // 1 product on two cards
                new GiftCardItem(){ Count=1, GiftCard=cardsList.Find(d=>d.Id == 13), GiftCardId=13,
                Product= productsList.Find(d=>d.Id == 2), ProductId= 2, ShopId = 2, Shop = shopsList.Find(d=>d.Id == 2)},
                new GiftCardItem(){ Count=1, GiftCard=cardsList.Find(d=>d.Id == 7), GiftCardId=7,
                Product= productsList.Find(d=>d.Id == 2), ProductId= 2, ShopId = 2, Shop = shopsList.Find(d=>d.Id == 2)},
                //1 T-shirt
                new GiftCardItem(){ Count=2, GiftCard=cardsList.Find(d=>d.Id == 10), GiftCardId=10,
                Product= productsList.Find(d=>d.Id == 1), ProductId= 1, ShopId = 1, Shop = shopsList.Find(d=>d.Id == 1)},
                // 1 chair and 2 t-shirts on one card
                new GiftCardItem(){ Count=2, GiftCard=cardsList.Find(d=>d.Id == 11), GiftCardId=11,
                Product= productsList.Find(d=>d.Id == 1), ProductId= 1, ShopId = 2, Shop = shopsList.Find(d=>d.Id == 2)},
                new GiftCardItem(){ Count=2, GiftCard=cardsList.Find(d=>d.Id == 11), GiftCardId=11,
                Product= productsList.Find(d=>d.Id == 2), ProductId= 2, ShopId = 2, Shop = shopsList.Find(d=>d.Id == 2)}
            };
            giftCardItemsList.ForEach(e => context.GiftCardItems.Add(e));
            context.SaveChanges();
        }
    }
}
