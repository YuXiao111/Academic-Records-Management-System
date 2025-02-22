USE [master]
GO
/****** Object:  Database [StudentInfoDB]    Script Date: 2024/10/26 23:40:12 ******/
CREATE DATABASE [StudentInfoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentInfoDB', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\StudentInfoDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StudentInfoDB_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\StudentInfoDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StudentInfoDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentInfoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentInfoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentInfoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentInfoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentInfoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentInfoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentInfoDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentInfoDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [StudentInfoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentInfoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentInfoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentInfoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentInfoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentInfoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentInfoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentInfoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentInfoDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentInfoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentInfoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentInfoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentInfoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentInfoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentInfoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentInfoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentInfoDB] SET RECOVERY FULL 
GO
ALTER DATABASE [StudentInfoDB] SET  MULTI_USER 
GO
ALTER DATABASE [StudentInfoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentInfoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentInfoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentInfoDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'StudentInfoDB', N'ON'
GO
USE [StudentInfoDB]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2024/10/26 23:40:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Sex] [nvarchar](5) NULL,
	[Telephne] [nvarchar](50) NULL,
	[Address] [nvarchar](255) NULL,
	[Major] [nvarchar](50) NULL,
	[ClassNumber] [nvarchar](50) NULL,
	[EnrolDate] [datetime] NOT NULL,
	[GraduateDate] [datetime] NULL,
	[InsertDate] [datetime] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 2024/10/26 23:40:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](32) NOT NULL,
	[InsertDate] [datetime] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [Number], [Name], [Sex], [Telephne], [Address], [Major], [ClassNumber], [EnrolDate], [GraduateDate], [InsertDate]) VALUES (3, N'1008611', N'李四', N'男', N'100861111', N'安徽省芜湖市镜湖区1', N'书法学啊', N'二班', CAST(0x0000B1F4012CDDA3 AS DateTime), CAST(0x0000B1F30176E769 AS DateTime), CAST(0x0000B1F4012CDDA3 AS DateTime))
INSERT [dbo].[Student] ([Id], [Number], [Name], [Sex], [Telephne], [Address], [Major], [ClassNumber], [EnrolDate], [GraduateDate], [InsertDate]) VALUES (4, N'110', N'张三', N'男', N'1111', N'北京市', N'软件工程', N'1', CAST(0x0000B1F4015CE1D5 AS DateTime), CAST(0x0000B7A9015CE1D5 AS DateTime), CAST(0x0000B1F4015CE1D5 AS DateTime))
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Name], [Password], [InsertDate]) VALUES (1, N'admin', N'123456', CAST(0x0000B1F301465F01 AS DateTime))
INSERT [dbo].[User] ([Id], [Name], [Password], [InsertDate]) VALUES (2, N'guest', N'0000', CAST(0x0000B1F30146A451 AS DateTime))
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Number'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学生姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学生电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Telephne'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学生地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学生专业' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Major'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'班级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'ClassNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'入学时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'EnrolDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'毕业时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'GraduateDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'InsertDate'
GO
USE [master]
GO
ALTER DATABASE [StudentInfoDB] SET  READ_WRITE 
GO
