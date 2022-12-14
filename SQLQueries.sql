/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/

DECLARE @first_date date= '2022-06-01';  
DECLARE @second_date date= '2022-08-08';  
DECLARE @card_id int = 1;

---1.	Получать информацию о количестве использованных/неиспользованных карт за выбранный период.
SELECT gc.IsUsed, COUNT(*) AS cardsInTerms
  FROM [Shop].[dbo].[GiftCards] AS gc
  WHERE gc.DateBought <= @second_date 
  AND gc.DateExpire >= @first_date
  GROUP BY gc.IsUsed

--- 2.	Получать Сумму использованных/неиспользованных карт за выбранный период.
SELECT gc.NominalSum, gc.IsUsed
  FROM [Shop].[dbo].[GiftCards] AS gc
  WHERE gc.DateBought <= @second_date 
  AND gc.DateExpire >= @first_date
  GROUP BY gc.NominalSum, gc.IsUsed

---3.	Получать сгоревшую (неиспользованную) сумму за выбранный период или по выбранной карте.
--- получить сгоревшие суммы по датам
SELECT Count(*) as count, gc.LeftSum AS cardsInTerms
  FROM [Shop].[dbo].[GiftCards] AS gc
  WHERE gc.DateUsed BETWEEN @first_date AND @second_date
  GROUP BY gc.LeftSum
  
---получить сгоревшую сумму по карте
SELECT gc.Id, gc.LeftSum AS cardsInTerms
  FROM [Shop].[dbo].[GiftCards] AS gc
  WHERE gc.Id= @card_id

---4.	Получать информацию о товарах, оплаченных конкретной картой.
SELECT gc.Id, gc.NominalSum, gc.LeftSum, p.Name, p.Price, gci.Count
  FROM [Shop].[dbo].[GiftCards] AS gc
  inner join [Shop].[dbo].GiftCardItems as gci
  on gc.Id = gci.GiftCardId
  inner join [Shop].[dbo].Products as p 
  on p.Id = gci.ProductId
  where gc.Id = @card_id

---5.	Получать информацию о количестве использованных карт в разрезе магазинов.
SELECT COUNT(*) as count, c.ShopId
from (SELECT gci.ShopId, gci.GiftCardId 
  FROM [Shop].[dbo].GiftCardItems as gci
  GROUP BY gci.ShopId, gci.GiftCardId) as c
  GROUP BY c.ShopId
