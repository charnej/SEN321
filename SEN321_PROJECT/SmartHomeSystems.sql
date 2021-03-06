USE [master]
GO
/****** Object:  Database [SmartHomeSystems]    Script Date: 06/04/2018 19:15:19 ******/
CREATE DATABASE [SmartHomeSystems] ON  PRIMARY 
( NAME = N'SmartHomeSystems', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SmartHomeSystems.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SmartHomeSystems_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SmartHomeSystems_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SmartHomeSystems] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SmartHomeSystems].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SmartHomeSystems] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SmartHomeSystems] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SmartHomeSystems] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SmartHomeSystems] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SmartHomeSystems] SET ARITHABORT OFF
GO
ALTER DATABASE [SmartHomeSystems] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SmartHomeSystems] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SmartHomeSystems] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SmartHomeSystems] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SmartHomeSystems] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SmartHomeSystems] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SmartHomeSystems] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SmartHomeSystems] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SmartHomeSystems] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SmartHomeSystems] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SmartHomeSystems] SET  DISABLE_BROKER
GO
ALTER DATABASE [SmartHomeSystems] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SmartHomeSystems] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SmartHomeSystems] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SmartHomeSystems] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SmartHomeSystems] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SmartHomeSystems] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SmartHomeSystems] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SmartHomeSystems] SET  READ_WRITE
GO
ALTER DATABASE [SmartHomeSystems] SET RECOVERY SIMPLE
GO
ALTER DATABASE [SmartHomeSystems] SET  MULTI_USER
GO
ALTER DATABASE [SmartHomeSystems] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SmartHomeSystems] SET DB_CHAINING OFF
GO
USE [SmartHomeSystems]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 06/04/2018 19:15:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[HouseNumber] [varchar](50) NOT NULL,
	[StreetName] [varchar](50) NOT NULL,
	[Suburb] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Province] [varchar](50) NOT NULL,
	[PostalCode] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Address__091C2A1B07020F21] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Address] ON
INSERT [dbo].[Address] ([AddressID], [HouseNumber], [StreetName], [Suburb], [City], [Province], [PostalCode]) VALUES (2, N'222', N'Tamatie Ave', N'PTA North', N'Pretoria', N'Gauteng', N'0182')
INSERT [dbo].[Address] ([AddressID], [HouseNumber], [StreetName], [Suburb], [City], [Province], [PostalCode]) VALUES (5, N'216', N'Erich', N'Tileba', N'Pretoria', N'Gauteng', N'0182')
INSERT [dbo].[Address] ([AddressID], [HouseNumber], [StreetName], [Suburb], [City], [Province], [PostalCode]) VALUES (7, N'213', N'gj', N'gf', N'dfg', N'fdg', N'0182')
INSERT [dbo].[Address] ([AddressID], [HouseNumber], [StreetName], [Suburb], [City], [Province], [PostalCode]) VALUES (8, N'111', N'Hill Street', N'Dorandia', N'Pretoria', N'Gauteng', N'1156')
INSERT [dbo].[Address] ([AddressID], [HouseNumber], [StreetName], [Suburb], [City], [Province], [PostalCode]) VALUES (9, N'144', N'BessieStreet', N'Tileba', N'Pretoria', N'Gauteng', N'0116')
SET IDENTITY_INSERT [dbo].[Address] OFF
/****** Object:  Table [dbo].[Contracts]    Script Date: 06/04/2018 19:15:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contracts](
	[ContractID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[ContractNumber] [char](1) NULL,
	[ContractName] [varchar](50) NULL,
	[Months] [varchar](50) NULL,
	[ContractDescription] [varchar](max) NULL,
 CONSTRAINT [PK_Contracts] PRIMARY KEY CLUSTERED 
(
	[ContractID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Contracts] ON
INSERT [dbo].[Contracts] ([ContractID], [ProductID], [ContractNumber], [ContractName], [Months], [ContractDescription]) VALUES (1, 1, N'F', N'E9', N'9', N'Home energy management 9 month contract')
INSERT [dbo].[Contracts] ([ContractID], [ProductID], [ContractNumber], [ContractName], [Months], [ContractDescription]) VALUES (2, 1, N'G', N'E12', N'12', N'Home energy management 12 month contract')
INSERT [dbo].[Contracts] ([ContractID], [ProductID], [ContractNumber], [ContractName], [Months], [ContractDescription]) VALUES (3, 1, N'H', N'E24', N'24', N'Home energy management 24 month contract')
INSERT [dbo].[Contracts] ([ContractID], [ProductID], [ContractNumber], [ContractName], [Months], [ContractDescription]) VALUES (10, 2, N'I', N'S9', N'9', N'Home security management 9 month contract')
INSERT [dbo].[Contracts] ([ContractID], [ProductID], [ContractNumber], [ContractName], [Months], [ContractDescription]) VALUES (11, 2, N'J', N'S12', N'12', N'Home security management 12 month contract')
INSERT [dbo].[Contracts] ([ContractID], [ProductID], [ContractNumber], [ContractName], [Months], [ContractDescription]) VALUES (12, 2, N'K', N'S24', N'24', N'Home security management 24 month contract')
INSERT [dbo].[Contracts] ([ContractID], [ProductID], [ContractNumber], [ContractName], [Months], [ContractDescription]) VALUES (13, 3, N'L', N'C9', N'9', N'Home convenience management 9 month contract')
INSERT [dbo].[Contracts] ([ContractID], [ProductID], [ContractNumber], [ContractName], [Months], [ContractDescription]) VALUES (14, 3, N'M', N'C12', N'12', N'Home convenience management 12 month contract')
INSERT [dbo].[Contracts] ([ContractID], [ProductID], [ContractNumber], [ContractName], [Months], [ContractDescription]) VALUES (15, 3, N'N', N'C24', N'24', N'Home convenience management 24  month contract')
SET IDENTITY_INSERT [dbo].[Contracts] OFF
/****** Object:  Table [dbo].[Contract]    Script Date: 06/04/2018 19:15:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contract](
	[ContractID] [int] IDENTITY(1,1) NOT NULL,
	[ContractNumber] [char](1) NOT NULL,
	[ContractName] [varchar](50) NOT NULL,
	[ContractDescription] [varchar](50) NULL,
 CONSTRAINT [PK__Contract__C90D3409282DF8C2] PRIMARY KEY CLUSTERED 
(
	[ContractID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Contract] ON
INSERT [dbo].[Contract] ([ContractID], [ContractNumber], [ContractName], [ContractDescription]) VALUES (1, N'F', N'Energy 9', N'Home enrgy management 9 month contract')
INSERT [dbo].[Contract] ([ContractID], [ContractNumber], [ContractName], [ContractDescription]) VALUES (2, N'G', N'Energy 12', N'Home energy management 12 month contract')
INSERT [dbo].[Contract] ([ContractID], [ContractNumber], [ContractName], [ContractDescription]) VALUES (3, N'H', N'Energy 24', N'Home energy management 24 month contract')
INSERT [dbo].[Contract] ([ContractID], [ContractNumber], [ContractName], [ContractDescription]) VALUES (4, N'I', N'Security 9', N'Home security management 9 month contract')
INSERT [dbo].[Contract] ([ContractID], [ContractNumber], [ContractName], [ContractDescription]) VALUES (5, N'J', N'Security 12', N'Home security management 12 month contract')
INSERT [dbo].[Contract] ([ContractID], [ContractNumber], [ContractName], [ContractDescription]) VALUES (6, N'K', N'Security 24', N'Home security management 24 month contract')
INSERT [dbo].[Contract] ([ContractID], [ContractNumber], [ContractName], [ContractDescription]) VALUES (7, N'L', N'Convenience 9', N'Home convenience management 9 month contract')
INSERT [dbo].[Contract] ([ContractID], [ContractNumber], [ContractName], [ContractDescription]) VALUES (8, N'M', N'Convenience 12', N'Home convenience management 12 month contract')
INSERT [dbo].[Contract] ([ContractID], [ContractNumber], [ContractName], [ContractDescription]) VALUES (9, N'N', N'Convenience 24', N'Home convenience management 24 month contract')
SET IDENTITY_INSERT [dbo].[Contract] OFF
/****** Object:  Table [dbo].[Component]    Script Date: 06/04/2018 19:15:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Component](
	[ComponentID] [int] IDENTITY(1,1) NOT NULL,
	[ComponentName] [varchar](50) NOT NULL,
	[ComponentCost] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK__Componen__D79CF02E03317E3D] PRIMARY KEY CLUSTERED 
(
	[ComponentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Component] ON
INSERT [dbo].[Component] ([ComponentID], [ComponentName], [ComponentCost], [Quantity]) VALUES (1, N'Controller', 900.0000, 1000)
INSERT [dbo].[Component] ([ComponentID], [ComponentName], [ComponentCost], [Quantity]) VALUES (2, N'Sensor', 1500.0000, 1000)
INSERT [dbo].[Component] ([ComponentID], [ComponentName], [ComponentCost], [Quantity]) VALUES (3, N'Smoke detector', 1100.0000, 1000)
INSERT [dbo].[Component] ([ComponentID], [ComponentName], [ComponentCost], [Quantity]) VALUES (4, N'Application', 500.0000, 1000)
SET IDENTITY_INSERT [dbo].[Component] OFF
/****** Object:  Table [dbo].[ServiceTickets]    Script Date: 06/04/2018 19:15:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ServiceTickets](
	[ServiceTicketID] [int] IDENTITY(1,1) NOT NULL,
	[ClientName] [varchar](max) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[Complete] [varchar](3) NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ServiceTicketID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceTickets] ON
INSERT [dbo].[ServiceTickets] ([ServiceTicketID], [ClientName], [ProductName], [OrderNumber], [Complete]) VALUES (1, N'Charne Jordaan', N'Home Energy Management', 10, N'yes')
INSERT [dbo].[ServiceTickets] ([ServiceTicketID], [ClientName], [ProductName], [OrderNumber], [Complete]) VALUES (8, N'Ilicia Trichardt', N'Home Convenience Management', 33, N'yes')
INSERT [dbo].[ServiceTickets] ([ServiceTicketID], [ClientName], [ProductName], [OrderNumber], [Complete]) VALUES (13, N'Charne Jordaan', N'Home Energy Management', 10, N'no')
SET IDENTITY_INSERT [dbo].[ServiceTickets] OFF
/****** Object:  Table [dbo].[Services]    Script Date: 06/04/2018 19:15:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Services](
	[ServiceID] [char](1) NOT NULL,
	[Description] [varchar](max) NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Services] ([ServiceID], [Description]) VALUES (N'A', NULL)
INSERT [dbo].[Services] ([ServiceID], [Description]) VALUES (N'B', NULL)
INSERT [dbo].[Services] ([ServiceID], [Description]) VALUES (N'C', NULL)
INSERT [dbo].[Services] ([ServiceID], [Description]) VALUES (N'D', NULL)
/****** Object:  Table [dbo].[Product]    Script Date: 06/04/2018 19:15:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[ProductDescription] [varchar](max) NOT NULL,
 CONSTRAINT [PK__Product__B40CC6ED7F60ED59] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductDescription]) VALUES (1, N'Home Energy Management', N'Energy production and consumption, maintain temps in geysers, switch lights on and off')
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductDescription]) VALUES (2, N'Home Security Management', N'Security systems, contact external security providers, schedule modes by time of day, deliver notifications and warnings, activate alarms')
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductDescription]) VALUES (3, N'Home Convenience Management', N'Task automation, prepare house to users'' requirements, perform household functions, adjust schedules')
SET IDENTITY_INSERT [dbo].[Product] OFF
/****** Object:  Table [dbo].[Appointments]    Script Date: 06/04/2018 19:15:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Appointments](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [char](9) NOT NULL,
	[TechnicianID] [int] NOT NULL,
	[AppointmentDate] [date] NOT NULL,
	[AppointmentType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON
INSERT [dbo].[Appointments] ([AppointmentID], [ClientID], [TechnicianID], [AppointmentDate], [AppointmentType]) VALUES (2, N'A04005716', 2, CAST(0x4F3E0B00 AS Date), N'Installation')
INSERT [dbo].[Appointments] ([AppointmentID], [ClientID], [TechnicianID], [AppointmentDate], [AppointmentType]) VALUES (3, N'E98340167', 3, CAST(0x593E0B00 AS Date), N'Installation')
SET IDENTITY_INSERT [dbo].[Appointments] OFF
/****** Object:  Table [dbo].[CallInformation]    Script Date: 06/04/2018 19:15:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CallInformation](
	[CallID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [char](9) NOT NULL,
	[CallStartTime] [varchar](50) NOT NULL,
	[CallEndTime] [varchar](50) NOT NULL,
	[Notes] [varchar](max) NOT NULL,
	[CallDate] [date] NOT NULL,
 CONSTRAINT [PK_CallInformation] PRIMARY KEY CLUSTERED 
(
	[CallID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CallInformation] ON
INSERT [dbo].[CallInformation] ([CallID], [ClientID], [CallStartTime], [CallEndTime], [Notes], [CallDate]) VALUES (1, N'A04005716', N'15:49:06', N'15:49:25', N'fgdgdg', CAST(0x4F3E0B00 AS Date))
SET IDENTITY_INSERT [dbo].[CallInformation] OFF
/****** Object:  StoredProcedure [dbo].[UpdateProducts]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateProducts]
	@productid int,
	@productname varchar(50),
	@description varchar(MAX)
	
AS
BEGIN	
	
	UPDATE Product SET ProductName = @productname, ProductDescription = @description
	WHERE ProductID = @productid
	
END
GO
/****** Object:  Table [dbo].[Person]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[IDNumber] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[AddressID] [int] NOT NULL,
 CONSTRAINT [PK__Person__564DB08B0AD2A005] PRIMARY KEY CLUSTERED 
(
	[IDNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Person] ([IDNumber], [FirstName], [LastName], [Email], [PhoneNumber], [AddressID]) VALUES (N'6308300018080', N'James', N'Charles', N'james@shs.com', N'0825462218', 2)
INSERT [dbo].[Person] ([IDNumber], [FirstName], [LastName], [Email], [PhoneNumber], [AddressID]) VALUES (N'7908300018083', N'Stefan', N'Grobler', N'stefan.g@shs.com', N'0789875563', 8)
INSERT [dbo].[Person] ([IDNumber], [FirstName], [LastName], [Email], [PhoneNumber], [AddressID]) VALUES (N'9101270018080', N'Ilicia', N'Trichardt', N'iliciaj@gmail.com', N'0829772557', 9)
INSERT [dbo].[Person] ([IDNumber], [FirstName], [LastName], [Email], [PhoneNumber], [AddressID]) VALUES (N'9308300018080', N'Charne', N'Jordaan', N'charne.cj@gmail.com', N'0829758893', 5)
INSERT [dbo].[Person] ([IDNumber], [FirstName], [LastName], [Email], [PhoneNumber], [AddressID]) VALUES (N'9308300018081', N'Adri', N'Koen', N'adri@shs.com', N'0829772556', 7)
/****** Object:  StoredProcedure [dbo].[AddProducts]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddProducts]	
	@productname varchar(50),
	@description varchar(MAX)
	
AS
BEGIN	
	
	INSERT INTO Product(ProductName, ProductDescription) 
	VALUES (@productname, @description)
	
END
GO
/****** Object:  StoredProcedure [dbo].[AddCallInfo]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCallInfo]
	@clientid char(9),
	@callstart varchar(50),
	@callend varchar(50),
	@callnotes varchar(max),
	@calldate date
AS
BEGIN
	
	INSERT INTO CallInformation(ClientID,CallStartTime,CallEndTime,Notes, CallDate)
	VALUES(@clientid, @callstart, @callend, @callnotes, @calldate)
END
GO
/****** Object:  StoredProcedure [dbo].[AddContract]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddContract]
	@contractname varchar(50),
	@contractdescription varchar(50),
	@contractnumber char(1)
AS
BEGIN
	INSERT INTO Contract(ContractNumber,ContractName,ContractDescription) 
	VALUES (@contractnumber,@contractname,@contractdescription)
END
GO
/****** Object:  StoredProcedure [dbo].[AddComponent]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddComponent] 
	@compname varchar(50),
	@compcost money,
	@compqty int
	
AS
BEGIN
	INSERT INTO Component(ComponentName,ComponentCost,Quantity)
	VALUES(@compname,@compcost,@compqty)
END
GO
/****** Object:  Table [dbo].[Client]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [char](9) NOT NULL,
	[NewsLetters] [varchar](3) NOT NULL,
	[IDNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Client__E67E1A040F975522] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Client] ([ClientID], [NewsLetters], [IDNumber]) VALUES (N'A04005716', N'No', N'9308300018080')
INSERT [dbo].[Client] ([ClientID], [NewsLetters], [IDNumber]) VALUES (N'E98340167', N'No', N'9101270018080')
/****** Object:  Table [dbo].[Personnel]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personnel](
	[PersonnelID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[JobTitle] [varchar](50) NOT NULL,
	[IDNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Personne__CAFBCB6F145C0A3F] PRIMARY KEY CLUSTERED 
(
	[PersonnelID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Personnel] ON
INSERT [dbo].[Personnel] ([PersonnelID], [Username], [Password], [JobTitle], [IDNumber]) VALUES (1, N'jamesc', N'1234', N'Call Agent', N'6308300018080')
INSERT [dbo].[Personnel] ([PersonnelID], [Username], [Password], [JobTitle], [IDNumber]) VALUES (2, N'adrik', N'1234', N'Technician', N'9308300018081')
INSERT [dbo].[Personnel] ([PersonnelID], [Username], [Password], [JobTitle], [IDNumber]) VALUES (3, N'stefang', N'1234', N'Technician', N'7908300018083')
SET IDENTITY_INSERT [dbo].[Personnel] OFF
/****** Object:  Table [dbo].[Billing]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Billing](
	[BillingID] [int] IDENTITY(1,1) NOT NULL,
	[BillingAmount] [money] NOT NULL,
	[ClientID] [char](9) NOT NULL,
 CONSTRAINT [PK__Billing__F1656D132B3F6F97] PRIMARY KEY CLUSTERED 
(
	[BillingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[DisplayClient]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DisplayClient]
	@idnumber varchar(50)
AS
BEGIN
	SELECT  Client.ClientID, 
			Person.IDNumber,
			Person.FirstName,
			Person.LastName, 
			Person.PhoneNumber, 
			Person.Email, 
			Client.NewsLetters, 
			Address.HouseNumber, 
			Address.StreetName, 
			Address.Suburb,
			Address.City, 
			Address.Province,
			Address.PostalCode 
	FROM Person 
	INNER JOIN Client on Client.IDNumber = Person.IDNumber 
	INNER JOIN Address on Person.AddressID = Address.AddressID 
	WHERE Person.IDNumber = @idnumber
END
GO
/****** Object:  Table [dbo].[ClientProducts]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ClientProducts](
	[ClientProductsID] [int] IDENTITY(1,1) NOT NULL,
	[CancelDate] [date] NULL,
	[ClientID] [char](9) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Contract] [varchar](12) NOT NULL,
	[ContractStartDate] [date] NOT NULL,
 CONSTRAINT [PK__ClientPr__C5E9C72125869641] PRIMARY KEY CLUSTERED 
(
	[ClientProductsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ClientProducts] ON
INSERT [dbo].[ClientProducts] ([ClientProductsID], [CancelDate], [ClientID], [ProductID], [Contract], [ContractStartDate]) VALUES (10, NULL, N'A04005716', 1, N'2018FA941364', CAST(0x493E0B00 AS Date))
INSERT [dbo].[ClientProducts] ([ClientProductsID], [CancelDate], [ClientID], [ProductID], [Contract], [ContractStartDate]) VALUES (29, NULL, N'E98340167', 3, N'2018LA777158', CAST(0x503E0B00 AS Date))
SET IDENTITY_INSERT [dbo].[ClientProducts] OFF
/****** Object:  Table [dbo].[Orders]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderNumber] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[ClientID] [char](9) NOT NULL,
	[PersonnelID] [int] NOT NULL,
 CONSTRAINT [PK__Orders__CAC5E7421920BF5C] PRIMARY KEY CLUSTERED 
(
	[OrderNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT [dbo].[Orders] ([OrderNumber], [OrderDate], [ClientID], [PersonnelID]) VALUES (10, CAST(0x493E0B00 AS Date), N'A04005716', 1)
INSERT [dbo].[Orders] ([OrderNumber], [OrderDate], [ClientID], [PersonnelID]) VALUES (33, CAST(0x503E0B00 AS Date), N'E98340167', 1)
SET IDENTITY_INSERT [dbo].[Orders] OFF
/****** Object:  StoredProcedure [dbo].[AddClient]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddClient]
	@clientnumber char(9),
	@idnumber varchar(50),
	@fname varchar(50),
	@surname varchar(50),
	@email varchar(50),
	@phone varchar(50),
	@housenr varchar(50),
	@streetname varchar(50),
	@suburb varchar(50),
	@city varchar(50),
	@province varchar(50),
	@postal varchar(50),
	@newsletter varchar(3)
AS
BEGIN
	DECLARE @addressid int

	INSERT INTO Address (HouseNumber, StreetName, Suburb, City, Province, PostalCode) 
	VALUES (@housenr, @streetname, @suburb, @city, @province, @postal)
	
	SET @addressid = SCOPE_IDENTITY()
	
	INSERT INTO Person (IDNumber, FirstName, LastName, Email, PhoneNumber, AddressID)
	VALUES (@idnumber,@fname, @surname, @email, @phone, @addressid)
	
	
	INSERT INTO Client (ClientID,NewsLetters, IDNumber) 
	VALUES (@clientnumber, @newsletter, @idnumber)
	
END
GO
/****** Object:  StoredProcedure [dbo].[AddAppointment]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddAppointment]
	@clientid char(9),
	@technicianid int,
	@appdate date,
	@apptype varchar(50)
AS
BEGIN
	INSERT INTO Appointments(ClientID,TechnicianID,AppointmentDate,AppointmentType)
	VALUES(@clientid, @technicianid, @appdate, @apptype)
	
	UPDATE ServiceTickets SET Complete = 'yes'
	WHERE ServiceTickets.OrderNumber = (SELECT Orders.OrderNumber
										FROM Orders
										WHERE Orders.ClientID = @clientid)
END
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[ComponentQty] [int] NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[ComponentID] [int] NOT NULL,
 CONSTRAINT [PK__OrderDet__9DD74D9D1ED998B2] PRIMARY KEY CLUSTERED 
(
	[OrderDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON
INSERT [dbo].[OrderDetail] ([OrderDetailsID], [ComponentQty], [OrderNumber], [ProductID], [ComponentID]) VALUES (27, 1, 10, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailsID], [ComponentQty], [OrderNumber], [ProductID], [ComponentID]) VALUES (53, 1, 33, 3, 2)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
/****** Object:  Table [dbo].[Maintenance]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Maintenance](
	[MaintenanceID] [int] IDENTITY(1,1) NOT NULL,
	[CalloutDate] [date] NOT NULL,
	[Notes] [varchar](max) NOT NULL,
	[Technician] [varchar](50) NOT NULL,
	[ClientProductsID] [int] NOT NULL,
 CONSTRAINT [PK__Maintena__E60542B5398D8EEE] PRIMARY KEY CLUSTERED 
(
	[MaintenanceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ClientConfigurations]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ClientConfigurations](
	[CCID] [int] IDENTITY(1,1) NOT NULL,
	[Component] [int] NOT NULL,
	[Range] [varchar](50) NOT NULL,
	[ClientProductsID] [int] NOT NULL,
 CONSTRAINT [PK__ClientCo__A9561A42300424B4] PRIMARY KEY CLUSTERED 
(
	[CCID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Upgrades]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Upgrades](
	[UpgradeID] [int] IDENTITY(1,1) NOT NULL,
	[CalloutDate] [date] NOT NULL,
	[Technician] [varchar](50) NOT NULL,
	[ClientProductsID] [int] NOT NULL,
 CONSTRAINT [PK__Upgrades__CA188BC53E52440B] PRIMARY KEY CLUSTERED 
(
	[UpgradeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Installation]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Installation](
	[InstallationID] [int] IDENTITY(1,1) NOT NULL,
	[InstallationDate] [date] NOT NULL,
	[Technician] [varchar](50) NOT NULL,
	[ClientProductsID] [int] NOT NULL,
 CONSTRAINT [PK__Installa__5F69B61434C8D9D1] PRIMARY KEY CLUSTERED 
(
	[InstallationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[AddServiceTicket]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddServiceTicket]
	@clientid char(9)
AS
BEGIN
DECLARE @serviceticketid int
	
	INSERT INTO ServiceTickets (ClientName,ProductName, OrderNumber)		
	SELECT DISTINCT Person.FirstName+' '+ Person.LastName, Product.ProductName, Orders.OrderNumber
FROM Orders
INNER JOIN OrderDetail ON Orders.OrderNumber = OrderDetail.OrderNumber
INNER JOIN Product ON OrderDetail.ProductID = Product.ProductID
INNER JOIN Client ON Orders.ClientID = Client.ClientID
INNER JOIN Person ON Client.IDNumber = Person.IDNumber
WHERE Client.ClientID = @clientid


SET @serviceticketid = SCOPE_IDENTITY()

UPDATE ServiceTickets SET Complete = 'no'
WHERE ServiceTicketID = @serviceticketid

END
GO
/****** Object:  StoredProcedure [dbo].[Invoice]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Invoice] 
	@client char(9)
AS
BEGIN
	
	DECLARE @clientsearchid char(9),
		@firstname varchar(50),
		@lastname varchar(50),
		@clientID char(9),
		@orderdate date,
		@ordernumber INT,
		@productname VARCHAR(50)
		
		
		SET @clientsearchid = @client
SELECT @firstname = FirstName, @lastname = LastName, @clientID = Client.ClientID, @orderdate = Orders.OrderDate,
@productname = Product.ProductName, @ordernumber = Orders.OrderNumber
FROM Person
INNER JOIN Client ON Person.IDNumber = Client.IDNumber
INNER JOIN Orders ON Client.ClientID = Orders.ClientID
INNER JOIN OrderDetail ON Orders.OrderNumber = OrderDetail.OrderNumber
INNER JOIN Product ON OrderDetail.ProductID = Product.ProductID
WHERE Client.ClientID = @clientsearchid

PRINT 
'-----------------------------------------------------------------------------------
									CUSTOMER INVOICE
-----------------------------------------------------------------------------------'
PRINT 'ORDER:		'+CONVERT(VARCHAR,@ordernumber)	+'									'+'DATE: '+CONVERT(VARCHAR,@orderdate,110)
PRINT 'CUSTOMER:	'+@clientID
PRINT '  '
PRINT 'Ship To:'
PRINT @firstname
PRINT @lastname
PRINT @productname
PRINT ' '
PRINT '	Component			UnitPrice			Quantity			Total'
PRINT '-----------------------------------------------------------------------------------'
	
DECLARE @compcost money,
		@compname VARCHAR(50),
		@compqty INT,
		@total MONEY
		
DECLARE cur4 CURSOR FOR SELECT ComponentName, ComponentCost, ComponentQty, ComponentCost*ComponentQty
						FROM Component
						INNER JOIN OrderDetail
						ON Component.ComponentID = OrderDetail.ComponentID 
						INNER JOIN Orders ON OrderDetail.OrderNumber = Orders.OrderNumber
						WHERE Orders.ClientID = @clientsearchid
						
OPEN cur4
FETCH NEXT FROM cur4 INTO @compname, @compcost, @compqty, @total
WHILE @@FETCH_STATUS =0
BEGIN


PRINT @compname+'			'+CONVERT(VARCHAR,@compcost)+'					'+convert(varchar,@compqty)+'		'+convert(varchar,@total)


FETCH NEXT FROM cur4 INTO @compname, @compcost, @compqty, @total
END
CLOSE cur4
DEALLOCATE cur4

	
	
END
GO
/****** Object:  StoredProcedure [dbo].[AddInstallation]    Script Date: 06/04/2018 19:15:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddInstallation]
	@instaldate date,
	@technician int,
	@clientproductsid int
AS
BEGIN
	
	INSERT INTO Installation(InstallationDate,Technician,ClientProductsID)
	VALUES(@instaldate,@technician,@clientproductsid)
END
GO
/****** Object:  ForeignKey [FK__Person__AddressI__0CBAE877]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK__Person__AddressI__0CBAE877] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Address] ([AddressID])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK__Person__AddressI__0CBAE877]
GO
/****** Object:  ForeignKey [FK__Client__IDNumber__117F9D94]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK__Client__IDNumber__117F9D94] FOREIGN KEY([IDNumber])
REFERENCES [dbo].[Person] ([IDNumber])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK__Client__IDNumber__117F9D94]
GO
/****** Object:  ForeignKey [FK__Personnel__IDNum__164452B1]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[Personnel]  WITH CHECK ADD  CONSTRAINT [FK__Personnel__IDNum__164452B1] FOREIGN KEY([IDNumber])
REFERENCES [dbo].[Person] ([IDNumber])
GO
ALTER TABLE [dbo].[Personnel] CHECK CONSTRAINT [FK__Personnel__IDNum__164452B1]
GO
/****** Object:  ForeignKey [FK__Billing__ClientI__2D27B809]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[Billing]  WITH CHECK ADD  CONSTRAINT [FK__Billing__ClientI__2D27B809] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[Billing] CHECK CONSTRAINT [FK__Billing__ClientI__2D27B809]
GO
/****** Object:  ForeignKey [FK__ClientPro__Clien__276EDEB3]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[ClientProducts]  WITH CHECK ADD  CONSTRAINT [FK__ClientPro__Clien__276EDEB3] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[ClientProducts] CHECK CONSTRAINT [FK__ClientPro__Clien__276EDEB3]
GO
/****** Object:  ForeignKey [FK__ClientPro__Produ__286302EC]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[ClientProducts]  WITH CHECK ADD  CONSTRAINT [FK__ClientPro__Produ__286302EC] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[ClientProducts] CHECK CONSTRAINT [FK__ClientPro__Produ__286302EC]
GO
/****** Object:  ForeignKey [FK__Orders__ClientID__1B0907CE]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__ClientID__1B0907CE] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__ClientID__1B0907CE]
GO
/****** Object:  ForeignKey [FK__Orders__Personne__1BFD2C07]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__Personne__1BFD2C07] FOREIGN KEY([PersonnelID])
REFERENCES [dbo].[Personnel] ([PersonnelID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__Personne__1BFD2C07]
GO
/****** Object:  ForeignKey [FK__OrderDeta__Compo__22AA2996]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK__OrderDeta__Compo__22AA2996] FOREIGN KEY([ComponentID])
REFERENCES [dbo].[Component] ([ComponentID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK__OrderDeta__Compo__22AA2996]
GO
/****** Object:  ForeignKey [FK__OrderDeta__Order__20C1E124]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK__OrderDeta__Order__20C1E124] FOREIGN KEY([OrderNumber])
REFERENCES [dbo].[Orders] ([OrderNumber])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK__OrderDeta__Order__20C1E124]
GO
/****** Object:  ForeignKey [FK__OrderDeta__Produ__21B6055D]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK__OrderDeta__Produ__21B6055D] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK__OrderDeta__Produ__21B6055D]
GO
/****** Object:  ForeignKey [FK__Maintenan__Clien__3B75D760]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[Maintenance]  WITH CHECK ADD  CONSTRAINT [FK__Maintenan__Clien__3B75D760] FOREIGN KEY([ClientProductsID])
REFERENCES [dbo].[ClientProducts] ([ClientProductsID])
GO
ALTER TABLE [dbo].[Maintenance] CHECK CONSTRAINT [FK__Maintenan__Clien__3B75D760]
GO
/****** Object:  ForeignKey [FK__ClientCon__Clien__31EC6D26]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[ClientConfigurations]  WITH CHECK ADD  CONSTRAINT [FK__ClientCon__Clien__31EC6D26] FOREIGN KEY([ClientProductsID])
REFERENCES [dbo].[ClientProducts] ([ClientProductsID])
GO
ALTER TABLE [dbo].[ClientConfigurations] CHECK CONSTRAINT [FK__ClientCon__Clien__31EC6D26]
GO
/****** Object:  ForeignKey [FK__Upgrades__Client__403A8C7D]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[Upgrades]  WITH CHECK ADD  CONSTRAINT [FK__Upgrades__Client__403A8C7D] FOREIGN KEY([ClientProductsID])
REFERENCES [dbo].[ClientProducts] ([ClientProductsID])
GO
ALTER TABLE [dbo].[Upgrades] CHECK CONSTRAINT [FK__Upgrades__Client__403A8C7D]
GO
/****** Object:  ForeignKey [FK__Installat__Clien__36B12243]    Script Date: 06/04/2018 19:15:20 ******/
ALTER TABLE [dbo].[Installation]  WITH CHECK ADD  CONSTRAINT [FK__Installat__Clien__36B12243] FOREIGN KEY([ClientProductsID])
REFERENCES [dbo].[ClientProducts] ([ClientProductsID])
GO
ALTER TABLE [dbo].[Installation] CHECK CONSTRAINT [FK__Installat__Clien__36B12243]
GO
