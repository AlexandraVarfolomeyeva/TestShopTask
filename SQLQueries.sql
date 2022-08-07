/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/

DECLARE @first_date date= '2022-08-03';  
DECLARE @second_date date= '2022-08-05';  
DECLARE @card_id int = 1;
DECLARE @shop_id int = 1;

SELECT COUNT(*) AS cardsInTerms
  FROM [Shop].[dbo].[GiftCards] AS gc
  WHERE gc.DateUsed BETWEEN @first_date AND @second_date

SELECT gc.NominalSum, COUNT(*) AS cardsInTerms
  FROM [Shop].[dbo].[GiftCards] AS gc
  WHERE gc.DateUsed BETWEEN @first_date AND @second_date
  GROUP BY gc.NominalSum

SELECT gc.Id, gc.LeftSum AS cardsInTerms
  FROM [Shop].[dbo].[GiftCards] AS gc
  WHERE gc.DateUsed BETWEEN @first_date AND @second_date

SELECT gc.Id, gc.LeftSum AS cardsInTerms
  FROM [Shop].[dbo].[GiftCards] AS gc
  WHERE gc.Id= @card_id

SELECT gc.Id, sh.Name, gci.Count
  FROM [Shop].[dbo].[GiftCards] AS gc
  inner join [Shop].[dbo].GiftCardItems as gci
  on gc.Id = gci.GiftCardId
  inner join [Shop].[dbo].Products as p 
  on p.Id = gci.ProductId
  inner join [Shop].[dbo].ProductsInShops as pis
  on pis.ProductId = p.Id
  inner join [Shop].[dbo].Shops as sh
  on sh.id = pis.Id
  WHERE sh.Id= @shop_id
