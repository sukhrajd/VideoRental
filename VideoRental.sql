USE [master]
GO
/****** Object:  Database [VideoRental]    Script Date: 16/12/2019 1:31:01 PM ******/
CREATE DATABASE [VideoRental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoRental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VideoRental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VideoRental] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoRental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoRental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoRental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoRental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoRental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoRental] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoRental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoRental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoRental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoRental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoRental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoRental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoRental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoRental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoRental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoRental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoRental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoRental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoRental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoRental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoRental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoRental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoRental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoRental] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoRental] SET  MULTI_USER 
GO
ALTER DATABASE [VideoRental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoRental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoRental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoRental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoRental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoRental] SET QUERY_STORE = OFF
GO
USE [VideoRental]
GO
/****** Object:  Table [dbo].[customerData]    Script Date: 16/12/2019 1:31:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customerData](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[address] [varchar](50) NULL,
 CONSTRAINT [PK_customerData] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rentData]    Script Date: 16/12/2019 1:31:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rentData](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customerId] [int] NULL,
	[MovieId] [int] NULL,
	[dateofIssue] [varchar](50) NULL,
	[dateofReturn] [varchar](50) NULL,
 CONSTRAINT [PK_rentData] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[videoData]    Script Date: 16/12/2019 1:31:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[videoData](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[ratting] [varchar](50) NULL,
	[year] [varchar](50) NULL,
	[copies] [varchar](50) NULL,
	[cost] [varchar](50) NULL,
	[plot] [varchar](50) NULL,
	[genre] [varchar](50) NULL,
 CONSTRAINT [PK_videoData] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customerData] ON 

INSERT [dbo].[customerData] ([id], [firstname], [lastname], [phone], [address]) VALUES (1, N'Sammy', N'Li', N'2589631478', N'auckland')
INSERT [dbo].[customerData] ([id], [firstname], [lastname], [phone], [address]) VALUES (2, N'Jasmine', N'Rosie', N'1478525', N'Hamilton')
SET IDENTITY_INSERT [dbo].[customerData] OFF
SET IDENTITY_INSERT [dbo].[rentData] ON 

INSERT [dbo].[rentData] ([id], [customerId], [MovieId], [dateofIssue], [dateofReturn]) VALUES (1, 2, 1, N'16/12/2019', N'Book')
SET IDENTITY_INSERT [dbo].[rentData] OFF
SET IDENTITY_INSERT [dbo].[videoData] ON 

INSERT [dbo].[videoData] ([id], [title], [ratting], [year], [copies], [cost], [plot], [genre]) VALUES (1, N'Race', N'5', N'2015', N'10', N'5', N'Action', N'Action')
SET IDENTITY_INSERT [dbo].[videoData] OFF
USE [master]
GO
ALTER DATABASE [VideoRental] SET  READ_WRITE 
GO
