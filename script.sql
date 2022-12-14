USE [master]
GO

/****** Object:  Database [Shop]    Script Date: 10.08.2022 9:12:35 ******/
CREATE DATABASE [Shop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Shop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Shop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Shop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [Shop] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Shop] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Shop] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Shop] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Shop] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Shop] SET ARITHABORT OFF 
GO

ALTER DATABASE [Shop] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [Shop] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Shop] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Shop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Shop] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Shop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Shop] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Shop] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Shop] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Shop] SET  ENABLE_BROKER 
GO

ALTER DATABASE [Shop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Shop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Shop] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Shop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Shop] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Shop] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [Shop] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Shop] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Shop] SET  MULTI_USER 
GO

ALTER DATABASE [Shop] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Shop] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Shop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Shop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Shop] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Shop] SET QUERY_STORE = OFF
GO

USE [Shop]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [Shop] SET  READ_WRITE 
GO


USE [Shop]
GO
/****** Object:  Table [dbo].[GiftCardItems]    Script Date: 10.08.2022 9:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiftCardItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Count] [int] NOT NULL,
	[GiftCardId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.GiftCardItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiftCards]    Script Date: 10.08.2022 9:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiftCards](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NominalSum] [decimal](18, 2) NOT NULL,
	[LeftSum] [decimal](18, 2) NOT NULL,
	[DateBought] [datetime] NOT NULL,
	[DateUsed] [datetime] NULL,
	[DateExpire] [datetime] NOT NULL,
	[IsUsed] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.GiftCards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10.08.2022 9:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductsInShops]    Script Date: 10.08.2022 9:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsInShops](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Count] [int] NOT NULL,
	[ShopId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ProductsInShops] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shops]    Script Date: 10.08.2022 9:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shops](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Shops] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[GiftCardItems]  WITH CHECK ADD  CONSTRAINT [FK_dbo.GiftCardItems_dbo.GiftCards_GiftCardId] FOREIGN KEY([GiftCardId])
REFERENCES [dbo].[GiftCards] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GiftCardItems] CHECK CONSTRAINT [FK_dbo.GiftCardItems_dbo.GiftCards_GiftCardId]
GO
ALTER TABLE [dbo].[GiftCardItems]  WITH CHECK ADD  CONSTRAINT [FK_dbo.GiftCardItems_dbo.Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GiftCardItems] CHECK CONSTRAINT [FK_dbo.GiftCardItems_dbo.Products_ProductId]
GO
ALTER TABLE [dbo].[GiftCardItems]  WITH CHECK ADD  CONSTRAINT [FK_dbo.GiftCardItems_dbo.Shops_ShopId] FOREIGN KEY([ShopId])
REFERENCES [dbo].[Shops] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GiftCardItems] CHECK CONSTRAINT [FK_dbo.GiftCardItems_dbo.Shops_ShopId]
GO
ALTER TABLE [dbo].[ProductsInShops]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ProductsInShops_dbo.Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductsInShops] CHECK CONSTRAINT [FK_dbo.ProductsInShops_dbo.Products_ProductId]
GO
ALTER TABLE [dbo].[ProductsInShops]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ProductsInShops_dbo.Shops_ShopId] FOREIGN KEY([ShopId])
REFERENCES [dbo].[Shops] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductsInShops] CHECK CONSTRAINT [FK_dbo.ProductsInShops_dbo.Shops_ShopId]
GO

INSERT INTO [dbo].[Shops]
           ([Name]
           ,[Address])
     VALUES
           ('first shop'
           ,'first address'),
		   ('second shop'
           ,'second address')
GO

INSERT INTO [dbo].[Products]
           ([Name]
           ,[Price])
     VALUES
           ('paper'
           ,800),
		   ('pencils'
           ,300),
		   ('book'
           ,1000)
GO

INSERT INTO [dbo].[GiftCards]
           ([NominalSum]
           ,[LeftSum]
           ,[DateBought]
           ,[DateUsed]
           ,[DateExpire]
           ,[IsUsed])
     VALUES
           (500
           ,200
           ,'2022-08-01T07:36:20'
           ,'2022-08-05T07:36:20'
           ,'2022-10-01T07:36:20'
           ,1),
		   (1000
           ,0
           ,'2022-07-01T07:36:20'
           ,'2022-07-30T07:36:20'
           ,'2022-09-01T07:36:20'
           ,1),
		   (1000
           ,1000
           ,'2022-07-15T07:36:20'
           ,null
           ,'2022-09-15T07:36:20'
           ,0)
GO

INSERT INTO [dbo].[GiftCardItems]
           ([Count]
           ,[GiftCardId]
           ,[ProductId]
           ,[ShopId])
     VALUES
           (1
           ,2
           ,3
           ,2),
		   (1
           ,1
           ,2
           ,1)
GO

INSERT INTO [dbo].[ProductsInShops]
           ([Count]
           ,[ShopId]
           ,[ProductId])
     VALUES
           (6
           ,1
           ,1),
		   (5
           ,2
           ,3),
		   (10
           ,1
           ,2)
GO