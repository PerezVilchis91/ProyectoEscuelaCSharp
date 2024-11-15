USE [master]
GO
/****** Object:  Database [bd_gestion_alumnos]    Script Date: 08/11/2024 08:38:11 p. m. ******/
CREATE DATABASE [bd_gestion_alumnos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bd_gestion_alumnos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\bd_gestion_alumnos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bd_gestion_alumnos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\bd_gestion_alumnos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [bd_gestion_alumnos] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd_gestion_alumnos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd_gestion_alumnos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd_gestion_alumnos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd_gestion_alumnos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bd_gestion_alumnos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd_gestion_alumnos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET RECOVERY FULL 
GO
ALTER DATABASE [bd_gestion_alumnos] SET  MULTI_USER 
GO
ALTER DATABASE [bd_gestion_alumnos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd_gestion_alumnos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bd_gestion_alumnos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bd_gestion_alumnos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bd_gestion_alumnos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bd_gestion_alumnos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bd_gestion_alumnos', N'ON'
GO
ALTER DATABASE [bd_gestion_alumnos] SET QUERY_STORE = ON
GO
ALTER DATABASE [bd_gestion_alumnos] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [bd_gestion_alumnos]
GO
/****** Object:  Table [dbo].[tb_alumnos]    Script Date: 08/11/2024 08:38:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_alumnos](
	[id_alumno] [int] IDENTITY(1,1) NOT NULL,
	[nombre_alumno] [varchar](100) NULL,
	[correo_alumno] [varchar](50) NULL,
	[fecha_nacimiento_alumno] [date] NULL,
	[telefono_alumno] [varchar](50) NULL,
	[edad_alumno] [int] NULL,
	[id_curso] [int] NULL,
	[id_horario] [int] NULL,
	[activo_alumno] [bit] NULL,
 CONSTRAINT [PK_tb_alumnos] PRIMARY KEY CLUSTERED 
(
	[id_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_cursos]    Script Date: 08/11/2024 08:38:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_cursos](
	[id_curso] [int] IDENTITY(1,1) NOT NULL,
	[nombre_curso] [varchar](50) NULL,
	[activo_curso] [bit] NULL,
 CONSTRAINT [PK_tb_cursos] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_horarios]    Script Date: 08/11/2024 08:38:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_horarios](
	[id_horarios] [int] IDENTITY(1,1) NOT NULL,
	[nombre_horario] [varchar](50) NULL,
	[activo_horario] [bit] NULL,
 CONSTRAINT [PK_tb_horarios] PRIMARY KEY CLUSTERED 
(
	[id_horarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_alumnos]  WITH CHECK ADD  CONSTRAINT [FK_tb_alumnos_tb_cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[tb_cursos] ([id_curso])
GO
ALTER TABLE [dbo].[tb_alumnos] CHECK CONSTRAINT [FK_tb_alumnos_tb_cursos]
GO
ALTER TABLE [dbo].[tb_alumnos]  WITH CHECK ADD  CONSTRAINT [FK_tb_alumnos_tb_horarios] FOREIGN KEY([id_horario])
REFERENCES [dbo].[tb_horarios] ([id_horarios])
GO
ALTER TABLE [dbo].[tb_alumnos] CHECK CONSTRAINT [FK_tb_alumnos_tb_horarios]
GO
/****** Object:  StoredProcedure [dbo].[SP_ACTUALIZAR_ALUMNOS]    Script Date: 08/11/2024 08:38:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ACTUALIZAR_ALUMNOS]
@nIDALUMNO INT,
@cNOMBRE VARCHAR(100),
@cCORREO VARCHAR(100),
@cFECHA_NACIMIENTO VARCHAR(100),
@cTELEFONO VARCHAR(100),
@nEDAD INT,
@nID_CURSO INT,
@nID_HORARIO INT
AS
	UPDATE	tb_alumnos SET  nombre_alumno=@cNOMBRE,
							correo_alumno=@cCORREO,
							fecha_nacimiento_alumno=@cFECHA_NACIMIENTO,
							telefono_alumno=@cTELEFONO,
							edad_alumno=@nEDAD,
							id_curso=@nID_CURSO,
							id_horario=@nID_HORARIO
	WHERE id_alumno=@nIDALUMNO
GO
/****** Object:  StoredProcedure [dbo].[SP_DESACTIVAR_ALUMNOS]    Script Date: 08/11/2024 08:38:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DESACTIVAR_ALUMNOS]
@nIDALUMNO INT

AS
	UPDATE	tb_alumnos SET  activo_alumno=0
	WHERE id_alumno=@nIDALUMNO
GO
/****** Object:  StoredProcedure [dbo].[SP_GUARDAR_ALUMNOS]    Script Date: 08/11/2024 08:38:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GUARDAR_ALUMNOS]
@cNOMBRE VARCHAR(100),
@cCORREO VARCHAR(100),
@cFECHA_NACIMIENTO VARCHAR(100),
@cTELEFONO VARCHAR(100),
@nEDAD INT,
@nID_CURSO INT,
@nID_HORARIO INT
AS
	INSERT INTO tb_alumnos(
							nombre_alumno,
							correo_alumno,
							fecha_nacimiento_alumno,
							telefono_alumno,
							edad_alumno,
							id_curso,
							id_horario,
							activo_alumno)
				VALUES	  (
							@cNOMBRE,
							@cCORREO,
							@cFECHA_NACIMIENTO,
							@cTELEFONO,
							@nEDAD,
							@nID_CURSO,
							@nID_HORARIO,
							1)
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAR_ALUMNOS]    Script Date: 08/11/2024 08:38:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LISTAR_ALUMNOS]
@cBUSQUEDA VARCHAR (100)=''
AS
SELECT id_alumno AS [ID],
	nombre_alumno AS [NOMBRE],
	d.nombre_curso AS [Curso],
	c.nombre_horario AS[HORARIO],
	e.edad_alumno AS [EDAD],
	e.correo_alumno AS [CORREO],
	e.telefono_alumno AS [TELEFONO],
	e.fecha_nacimiento_alumno AS [Fecha Nac]

FROM tb_alumnos e
INNER JOIN tb_cursos d ON e.id_curso=d.id_curso
INNER JOIN tb_horarios c ON e.id_horario=c.id_horarios
WHERE e.activo_alumno=1 AND
UPPER (e.nombre_alumno)+
UPPER (d.nombre_curso)+
upper (c.nombre_horario)
LIKE '%'+UPPER(@cBusqueda)+'%'
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAR_CURSOS]    Script Date: 08/11/2024 08:38:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LISTAR_CURSOS]
AS
SELECT id_curso,nombre_curso FROM tb_cursos
WHERE activo_curso=1;
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAR_HORARIOS]    Script Date: 08/11/2024 08:38:11 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LISTAR_HORARIOS]
AS
	SELECT id_horarios,nombre_horario FROM tb_horarios
	WHERE activo_horario=1;
GO
USE [master]
GO
ALTER DATABASE [bd_gestion_alumnos] SET  READ_WRITE 
GO
