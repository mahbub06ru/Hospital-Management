USE [master]
GO
/****** Object:  Database [HospitalDB]    Script Date: 5/18/2015 5:29:12 PM ******/
CREATE DATABASE [HospitalDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HospitalDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\HospitalDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HospitalDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\HospitalDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HospitalDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HospitalDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HospitalDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HospitalDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HospitalDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HospitalDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HospitalDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HospitalDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HospitalDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [HospitalDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HospitalDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HospitalDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HospitalDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HospitalDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HospitalDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HospitalDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HospitalDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HospitalDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HospitalDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HospitalDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HospitalDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HospitalDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HospitalDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HospitalDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HospitalDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HospitalDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HospitalDB] SET  MULTI_USER 
GO
ALTER DATABASE [HospitalDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HospitalDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HospitalDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HospitalDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [HospitalDB]
GO
/****** Object:  Table [dbo].[DepartmentTable]    Script Date: 5/18/2015 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DepartmentTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DepartmentTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DiseaseTable]    Script Date: 5/18/2015 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DiseaseTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DiseaseTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DoctorTable]    Script Date: 5/18/2015 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DoctorTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[DepartmentId] [int] NOT NULL,
 CONSTRAINT [PK_DoctorTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PatientDiseaseTable]    Script Date: 5/18/2015 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientDiseaseTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NOT NULL,
	[DiseaseId] [int] NOT NULL,
 CONSTRAINT [PK_PatientDiseaseTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PatientTable]    Script Date: 5/18/2015 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PatientTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[DoctorId] [int] NOT NULL,
 CONSTRAINT [PK_PatientTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[DoctorDepartmentView]    Script Date: 5/18/2015 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW  [dbo].[DoctorDepartmentView] AS
SELECT DoctorTable.Id AS Id, DoctorTable.Name AS DoctorName, DepartmentTable.Name AS DepartmentName
FROM DoctorTable
LEFT OUTER JOIN DepartmentTable
ON DoctorTable.DepartmentId=DepartmentTable.Id
GO
/****** Object:  View [dbo].[DoctorPatientView]    Script Date: 5/18/2015 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[DoctorPatientView] AS
SELECT DoctorTable.Id AS Id,DoctorTable.Name As DoctorName,PatientTable.Name As PatientName
FROM DoctorTable
LEFT OUTER JOIN PatientTable
ON DoctorTable.Id=PatientTable.DoctorId

GO
/****** Object:  View [dbo].[PatientDiseaseView]    Script Date: 5/18/2015 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PatientDiseaseView] AS
SELECT PatientDiseaseTable.PatientId AS Id,DiseaseTable.Id AS DiseaseId,DiseaseTable.Name AS DiseaseName
FROM PatientDiseaseTable
LEFT OUTER JOIN DiseaseTable
ON PatientDiseaseTable.DiseaseId=DiseaseTable.Id
GO
/****** Object:  View [dbo].[PatientDoctorView]    Script Date: 5/18/2015 5:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PatientDoctorView] AS
SELECT        PatientTable.Id, PatientTable.Name AS PatientName, DoctorTable.Id AS DoctorId,DoctorTable.Name AS DoctorName
FROM            PatientTable LEFT OUTER JOIN
                         DoctorTable ON PatientTable.DoctorId = DoctorTable.Id
GO
/****** Object:  Index [IX_DepartmentTable]    Script Date: 5/18/2015 5:29:12 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DepartmentTable] ON [dbo].[DepartmentTable]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DiseaseTable]    Script Date: 5/18/2015 5:29:12 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DiseaseTable] ON [dbo].[DiseaseTable]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DoctorTable]    Script Date: 5/18/2015 5:29:12 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DoctorTable] ON [dbo].[DoctorTable]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PatientDiseaseTable]    Script Date: 5/18/2015 5:29:12 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_PatientDiseaseTable] ON [dbo].[PatientDiseaseTable]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PatientTable]    Script Date: 5/18/2015 5:29:12 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_PatientTable] ON [dbo].[PatientTable]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DoctorTable]  WITH CHECK ADD  CONSTRAINT [FK_DoctorTable_DepartmentTable] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[DepartmentTable] ([Id])
GO
ALTER TABLE [dbo].[DoctorTable] CHECK CONSTRAINT [FK_DoctorTable_DepartmentTable]
GO
ALTER TABLE [dbo].[PatientDiseaseTable]  WITH CHECK ADD  CONSTRAINT [FK_PatientDiseaseTable_DiseaseTable] FOREIGN KEY([DiseaseId])
REFERENCES [dbo].[DiseaseTable] ([Id])
GO
ALTER TABLE [dbo].[PatientDiseaseTable] CHECK CONSTRAINT [FK_PatientDiseaseTable_DiseaseTable]
GO
ALTER TABLE [dbo].[PatientDiseaseTable]  WITH CHECK ADD  CONSTRAINT [FK_PatientDiseaseTable_PatientTable] FOREIGN KEY([PatientId])
REFERENCES [dbo].[PatientTable] ([Id])
GO
ALTER TABLE [dbo].[PatientDiseaseTable] CHECK CONSTRAINT [FK_PatientDiseaseTable_PatientTable]
GO
ALTER TABLE [dbo].[PatientTable]  WITH CHECK ADD  CONSTRAINT [FK_PatientTable_DoctorTable] FOREIGN KEY([DoctorId])
REFERENCES [dbo].[DoctorTable] ([Id])
GO
ALTER TABLE [dbo].[PatientTable] CHECK CONSTRAINT [FK_PatientTable_DoctorTable]
GO
USE [master]
GO
ALTER DATABASE [HospitalDB] SET  READ_WRITE 
GO
