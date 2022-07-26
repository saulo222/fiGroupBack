USE [master]
GO
/****** Object:  Database [DCfiGroup]    Script Date: 21/07/2022 8:47:43 p. m. ******/
CREATE DATABASE [DCfiGroup]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DCfiGroup', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DCfiGroup.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DCfiGroup_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DCfiGroup_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DCfiGroup] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DCfiGroup].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DCfiGroup] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DCfiGroup] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DCfiGroup] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DCfiGroup] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DCfiGroup] SET ARITHABORT OFF 
GO
ALTER DATABASE [DCfiGroup] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DCfiGroup] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DCfiGroup] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DCfiGroup] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DCfiGroup] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DCfiGroup] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DCfiGroup] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DCfiGroup] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DCfiGroup] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DCfiGroup] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DCfiGroup] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DCfiGroup] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DCfiGroup] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DCfiGroup] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DCfiGroup] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DCfiGroup] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DCfiGroup] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DCfiGroup] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DCfiGroup] SET  MULTI_USER 
GO
ALTER DATABASE [DCfiGroup] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DCfiGroup] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DCfiGroup] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DCfiGroup] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DCfiGroup] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DCfiGroup] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DCfiGroup] SET QUERY_STORE = OFF
GO
USE [DCfiGroup]
GO
/****** Object:  Table [dbo].[tbTask]    Script Date: 21/07/2022 8:47:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTask](
	[idTask] [bigint] IDENTITY(1,1) NOT NULL,
	[nameTask] [varchar](120) NULL,
	[state] [bit] NULL,
	[dateCreate] [datetime] NULL,
 CONSTRAINT [PK_tbTask] PRIMARY KEY CLUSTERED 
(
	[idTask] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbTask] ON 

INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (1, N'Regar las plantas', 0, CAST(N'2022-07-20T08:18:13.677' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (2, N'Bañar los perros', 1, CAST(N'2022-07-20T08:18:24.390' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (3, N'Hacer las compras', 1, CAST(N'2022-07-20T08:18:37.647' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (5, N'uyuyu', 0, CAST(N'2022-07-20T20:45:21.187' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (6, N'Pruebas front update 3', 1, CAST(N'2022-07-20T20:46:31.913' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (8, N'holas', 0, CAST(N'2022-07-20T21:19:26.433' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (13, N'dfdf', 0, CAST(N'2022-07-20T21:29:02.190' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (20, N'Pruebas front insert', 1, CAST(N'2022-07-20T22:46:12.237' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (21, N'Pruebas tareas', 0, CAST(N'2022-07-21T12:25:19.257' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (22, N'pruebas tareas', 0, CAST(N'2022-07-21T12:25:52.717' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (23, N'fgfdgfd', 1, CAST(N'2022-07-21T12:41:22.920' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (25, N'rretretre', 0, CAST(N'2022-07-21T13:11:57.463' AS DateTime))
INSERT [dbo].[tbTask] ([idTask], [nameTask], [state], [dateCreate]) VALUES (28, N'Pruebas de front 2 fg', 0, CAST(N'2022-07-21T17:01:05.807' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbTask] OFF
GO
ALTER TABLE [dbo].[tbTask] ADD  CONSTRAINT [DF_tbTask_dateCreate]  DEFAULT (getdate()) FOR [dateCreate]
GO
USE [master]
GO
ALTER DATABASE [DCfiGroup] SET  READ_WRITE 
GO
