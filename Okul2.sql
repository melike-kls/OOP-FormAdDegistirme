USE [master]
GO
/****** Object:  Database [Okul2]    Script Date: 6.12.2021 16:00:13 ******/
CREATE DATABASE [Okul2] ON  PRIMARY 
( NAME = N'Okul2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Okul2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Okul2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Okul2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Okul2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Okul2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Okul2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Okul2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Okul2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Okul2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Okul2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Okul2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Okul2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Okul2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Okul2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Okul2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Okul2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Okul2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Okul2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Okul2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Okul2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Okul2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Okul2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Okul2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Okul2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Okul2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Okul2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Okul2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Okul2] SET  MULTI_USER 
GO
ALTER DATABASE [Okul2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Okul2] SET DB_CHAINING OFF 
GO
USE [Okul2]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 6.12.2021 16:00:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NOT NULL,
	[Soyad] [varchar](50) NOT NULL,
	[Numara] [int] NOT NULL,
	[SinifId] [int] NOT NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sinif]    Script Date: 6.12.2021 16:00:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sinif](
	[SinifId] [int] IDENTITY(1,1) NOT NULL,
	[SinifAd] [varchar](50) NOT NULL,
	[Kontenjan] [int] NOT NULL,
 CONSTRAINT [PK_Sinif] PRIMARY KEY CLUSTERED 
(
	[SinifId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ogrenci] ON 

INSERT [dbo].[Ogrenci] ([Id], [Ad], [Soyad], [Numara], [SinifId]) VALUES (1, N'Ali', N'Demir', 1234, 1)
INSERT [dbo].[Ogrenci] ([Id], [Ad], [Soyad], [Numara], [SinifId]) VALUES (2, N'Veli', N'Yalçın', 4564, 3)
INSERT [dbo].[Ogrenci] ([Id], [Ad], [Soyad], [Numara], [SinifId]) VALUES (3, N'Ayşe', N'Bakır', 7569, 4)
INSERT [dbo].[Ogrenci] ([Id], [Ad], [Soyad], [Numara], [SinifId]) VALUES (8, N'Melike', N'Keleş', 9584, 1)
INSERT [dbo].[Ogrenci] ([Id], [Ad], [Soyad], [Numara], [SinifId]) VALUES (9, N'Bahar', N'Tomaz', 6548, 1)
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
SET IDENTITY_INSERT [dbo].[Sinif] ON 

INSERT [dbo].[Sinif] ([SinifId], [SinifAd], [Kontenjan]) VALUES (1, N'1-A', 25)
INSERT [dbo].[Sinif] ([SinifId], [SinifAd], [Kontenjan]) VALUES (3, N'2-A', 30)
INSERT [dbo].[Sinif] ([SinifId], [SinifAd], [Kontenjan]) VALUES (4, N'3-A', 35)
SET IDENTITY_INSERT [dbo].[Sinif] OFF
ALTER TABLE [dbo].[Ogrenci]  WITH CHECK ADD  CONSTRAINT [FK_Ogrenci_Sinif] FOREIGN KEY([SinifId])
REFERENCES [dbo].[Sinif] ([SinifId])
GO
ALTER TABLE [dbo].[Ogrenci] CHECK CONSTRAINT [FK_Ogrenci_Sinif]
GO
USE [master]
GO
ALTER DATABASE [Okul2] SET  READ_WRITE 
GO
