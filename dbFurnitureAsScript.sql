USE [master]
GO
/****** Object:  Database [TheBestFurniture]    Script Date: 11/20/2019 11:16:15 PM ******/
CREATE DATABASE [TheBestFurniture]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TheBestFurniture', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TheBestFurniture.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TheBestFurniture_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TheBestFurniture_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TheBestFurniture] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TheBestFurniture].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TheBestFurniture] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TheBestFurniture] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TheBestFurniture] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TheBestFurniture] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TheBestFurniture] SET ARITHABORT OFF 
GO
ALTER DATABASE [TheBestFurniture] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TheBestFurniture] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TheBestFurniture] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TheBestFurniture] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TheBestFurniture] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TheBestFurniture] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TheBestFurniture] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TheBestFurniture] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TheBestFurniture] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TheBestFurniture] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TheBestFurniture] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TheBestFurniture] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TheBestFurniture] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TheBestFurniture] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TheBestFurniture] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TheBestFurniture] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [TheBestFurniture] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TheBestFurniture] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TheBestFurniture] SET  MULTI_USER 
GO
ALTER DATABASE [TheBestFurniture] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TheBestFurniture] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TheBestFurniture] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TheBestFurniture] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TheBestFurniture] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TheBestFurniture] SET QUERY_STORE = OFF
GO
USE [TheBestFurniture]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/20/2019 11:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 11/20/2019 11:16:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 11/20/2019 11:16:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 11/20/2019 11:16:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 11/20/2019 11:16:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 11/20/2019 11:16:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 11/20/2019 11:16:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Firstname] [nvarchar](256) NULL,
	[Lastname] [nvarchar](256) NULL,
	[Birthdate] [datetime2](7) NOT NULL,
	[Livingplace] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 11/20/2019 11:16:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 11/20/2019 11:16:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[CategoryImage] [nvarchar](300) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Favorites]    Script Date: 11/20/2019 11:16:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Favorites](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Favorites] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 11/20/2019 11:16:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MainImage] [nvarchar](300) NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/20/2019 11:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[HasDiscount] [bit] NOT NULL,
	[DiscountedPrice] [decimal](18, 2) NOT NULL,
	[Height] [int] NOT NULL,
	[Width] [int] NOT NULL,
	[Length] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ratings]    Script Date: 11/20/2019 11:16:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ratings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Score] [decimal](18, 2) NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Ratings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191120113856_initial', N'2.1.4-rtm-31024')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Firstname], [Lastname], [Birthdate], [Livingplace]) VALUES (N'abe866a9-4191-416f-90a5-0f20b85a27a8', N'spide', N'SPIDE', N'mail1@mail.az', N'MAIL1@MAIL.AZ', 0, N'AQAAAAEAACcQAAAAEPXp3/FzgWBWgcHwPHWFUY+XIjsgO4jVD6edlj/beNNVvpxMnpsIHgVBs7Yycw6y8Q==', N'OEQ3J5BBQ4JCBQLXS2TLWRMZD2GB6EFS', N'66d2d72c-cbc3-4d30-a651-6f5c59afe51c', NULL, 0, 0, NULL, 1, 0, N'Spiderman', N'Good', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([Id], [Name], [CategoryImage]) VALUES (1, N'Bathroom', N'bathroom2.png')
GO
INSERT [dbo].[Categories] ([Id], [Name], [CategoryImage]) VALUES (2, N'Livingroom', N'livingroom2.png')
GO
INSERT [dbo].[Categories] ([Id], [Name], [CategoryImage]) VALUES (7, N'Kitchen', N'99317fa5-c00f-4f4f-9bfd-abe50cd09192kitchen.png')
GO
INSERT [dbo].[Categories] ([Id], [Name], [CategoryImage]) VALUES (8, N'Bedroom', N'375ce565-1039-49b6-b8a8-cb4d34c65b31bedroom.png')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Favorites] ON 
GO
INSERT [dbo].[Favorites] ([Id], [ProductId], [UserId]) VALUES (14, 4, N'abe866a9-4191-416f-90a5-0f20b85a27a8')
GO
SET IDENTITY_INSERT [dbo].[Favorites] OFF
GO
SET IDENTITY_INSERT [dbo].[Images] ON 
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (13, N'product_4.png', 4)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (14, N'product_4.png', 4)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (15, N'product_4.png', 4)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (16, N'product_4.png', 4)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (17, N'product_5.png', 5)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (18, N'product_5.png', 5)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (19, N'product_5.png', 5)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (20, N'product_5.png', 5)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (25, N'product_7.png', 7)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (26, N'product_7.png', 7)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (27, N'product_7.png', 7)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (28, N'product_7.png', 7)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (41, N'820e6262-96b9-4bef-88d9-9663ef6a509fproduct_1.png', 11)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (42, N'1f50fcbe-99f7-472d-bc5f-413d3984c3f3product_11.png', 11)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (43, N'4d17e4be-b010-45f7-a9f1-91a128e0d818product_12.png', 11)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (44, N'581c561f-f6eb-45ac-a27f-8c71a4fde7e6product_13.png', 11)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (45, N'f059e6e9-e4a5-45cf-9234-e36c6ba7290fproduct_2.png', 12)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (46, N'6284e128-bd11-4d62-b0be-d5a2df9ffaddproduct_21.png', 12)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (47, N'5cb2cfa7-967e-4e7b-9053-c7392ed7ecb8product_22.png', 12)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (48, N'15f76ad9-7e5d-46e1-a54e-eb7a9c08445eproduct_23.png', 12)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (49, N'38a2dba0-274d-4836-b4ed-c8ad32c235f7product_3.png', 13)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (50, N'd290b058-e924-475f-be54-b57db74f6721product_31.png', 13)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (51, N'4a6430ab-1e1d-41b4-83b3-abbe19279b04product_32.png', 13)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (52, N'5e40e186-1b9c-4c29-9fcb-e08574f3a2d5product_33.png', 13)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (53, N'bd25f953-170b-40c6-9711-08d9d24ab5e9product_6.png', 14)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (54, N'b9f6b27a-e6c9-497f-8a36-5002b883108fproduct_61.png', 14)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (55, N'59e0edd3-9649-4160-93dc-e0d14c9f8232product_62.png', 14)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (56, N'824ee908-ddc7-4af5-a76e-9fadffa358caproduct_63.png', 14)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (57, N'5044d853-02c8-44be-a3b9-1ba55a731272product_8.png', 15)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (58, N'5517a5e3-3aaa-4271-8292-1800edcc6dc6product_81.png', 15)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (59, N'4a99fa31-70a0-4741-8db8-36cf2f9797fbproduct_82.png', 15)
GO
INSERT [dbo].[Images] ([Id], [MainImage], [ProductId]) VALUES (60, N'28aded69-98d9-4b99-bc7c-d82aafc3d2adproduct_83.png', 15)
GO
SET IDENTITY_INSERT [dbo].[Images] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [HasDiscount], [DiscountedPrice], [Height], [Width], [Length], [CategoryId]) VALUES (4, N'Livingroom Chair', CAST(250.00 AS Decimal(18, 2)), 0, CAST(0.00 AS Decimal(18, 2)), 500, 128, 58, 2)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [HasDiscount], [DiscountedPrice], [Height], [Width], [Length], [CategoryId]) VALUES (5, N'Comfortable Bathroom Chair', CAST(200.00 AS Decimal(18, 2)), 1, CAST(180.00 AS Decimal(18, 2)), 508, 128, 58, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [HasDiscount], [DiscountedPrice], [Height], [Width], [Length], [CategoryId]) VALUES (7, N'Bathroom Chair', CAST(70.00 AS Decimal(18, 2)), 0, CAST(0.00 AS Decimal(18, 2)), 508, 128, 58, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [HasDiscount], [DiscountedPrice], [Height], [Width], [Length], [CategoryId]) VALUES (11, N'Green Kitchen Chair', CAST(200.00 AS Decimal(18, 2)), 1, CAST(100.00 AS Decimal(18, 2)), 200, 300, 100, 7)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [HasDiscount], [DiscountedPrice], [Height], [Width], [Length], [CategoryId]) VALUES (12, N'Orange Kitchen Chair', CAST(250.00 AS Decimal(18, 2)), 1, CAST(200.00 AS Decimal(18, 2)), 300, 200, 100, 7)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [HasDiscount], [DiscountedPrice], [Height], [Width], [Length], [CategoryId]) VALUES (13, N'Yellow Kitchen Chair', CAST(150.00 AS Decimal(18, 2)), 1, CAST(100.00 AS Decimal(18, 2)), 200, 150, 100, 7)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [HasDiscount], [DiscountedPrice], [Height], [Width], [Length], [CategoryId]) VALUES (14, N'Green Bedroom Chair', CAST(100.00 AS Decimal(18, 2)), 0, CAST(0.00 AS Decimal(18, 2)), 200, 150, 150, 1)
GO
INSERT [dbo].[Products] ([Id], [Name], [Price], [HasDiscount], [DiscountedPrice], [Height], [Width], [Length], [CategoryId]) VALUES (15, N'Red Bedroom Chair', CAST(130.00 AS Decimal(18, 2)), 0, CAST(0.00 AS Decimal(18, 2)), 100, 200, 113, 8)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Favorites_ProductId]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_Favorites_ProductId] ON [dbo].[Favorites]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Favorites_UserId]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_Favorites_UserId] ON [dbo].[Favorites]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Images_ProductId]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_Images_ProductId] ON [dbo].[Images]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Ratings_ProductId]    Script Date: 11/20/2019 11:16:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_Ratings_ProductId] ON [dbo].[Ratings]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Favorites]  WITH CHECK ADD  CONSTRAINT [FK_Favorites_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Favorites] CHECK CONSTRAINT [FK_Favorites_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Favorites]  WITH CHECK ADD  CONSTRAINT [FK_Favorites_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Favorites] CHECK CONSTRAINT [FK_Favorites_Products_ProductId]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Products_ProductId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Ratings]  WITH CHECK ADD  CONSTRAINT [FK_Ratings_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ratings] CHECK CONSTRAINT [FK_Ratings_Products_ProductId]
GO
USE [master]
GO
ALTER DATABASE [TheBestFurniture] SET  READ_WRITE 
GO
