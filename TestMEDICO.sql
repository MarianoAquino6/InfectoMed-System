USE [master]
GO
/****** Object:  Database [TestMEDICO]    Script Date: 15/02/2024 23:27:47 ******/
CREATE DATABASE [TestMEDICO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CardioCare', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CardioCare.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CardioCare_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CardioCare_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TestMEDICO] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestMEDICO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TestMEDICO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TestMEDICO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TestMEDICO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TestMEDICO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TestMEDICO] SET ARITHABORT OFF 
GO
ALTER DATABASE [TestMEDICO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TestMEDICO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TestMEDICO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TestMEDICO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TestMEDICO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TestMEDICO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TestMEDICO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TestMEDICO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TestMEDICO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TestMEDICO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TestMEDICO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TestMEDICO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TestMEDICO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TestMEDICO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TestMEDICO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TestMEDICO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TestMEDICO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TestMEDICO] SET RECOVERY FULL 
GO
ALTER DATABASE [TestMEDICO] SET  MULTI_USER 
GO
ALTER DATABASE [TestMEDICO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TestMEDICO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TestMEDICO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TestMEDICO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TestMEDICO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TestMEDICO] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TestMEDICO', N'ON'
GO
ALTER DATABASE [TestMEDICO] SET QUERY_STORE = ON
GO
ALTER DATABASE [TestMEDICO] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TestMEDICO]
GO
/****** Object:  Table [dbo].[Consultas]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consultas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[MotivoConsulta] [nvarchar](255) NULL,
	[EnfermedadActualAntecedentes] [nvarchar](max) NULL,
	[AntecedentesPersonales] [nvarchar](max) NULL,
	[ID_ExamenFisico] [int] NULL,
	[EstudioComplementario] [nvarchar](max) NULL,
	[ResumenSemiologico] [nvarchar](max) NULL,
	[DiagnosticoPresuntivo] [nvarchar](255) NULL,
	[DiagnosticosDiferenciales] [nvarchar](max) NULL,
	[TratamientoOrdenMedica] [nvarchar](max) NULL,
	[Aclaraciones] [nvarchar](max) NULL,
 CONSTRAINT [PK_Consultas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contraindicaciones]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contraindicaciones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
 CONSTRAINT [PK__Contrain__3214EC27F26101CE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EfectosAdversos]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EfectosAdversos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
 CONSTRAINT [PK__EfectosA__3214EC27B0A08FF2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enfermedades]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enfermedades](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Esquema] [nchar](200) NULL,
 CONSTRAINT [PK_Enfermedades] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamenesFisicos]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamenesFisicos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Inspeccion] [nvarchar](max) NULL,
	[SignosVitales] [nvarchar](max) NULL,
	[SistemaTegumentario] [nvarchar](max) NULL,
	[SistemaLinfoganglionar] [nvarchar](max) NULL,
	[SistemaVenosoSuperficialProfundo] [nvarchar](max) NULL,
	[SistemaOsteoarticulomuscular] [nvarchar](max) NULL,
	[CabezaCuello] [nvarchar](max) NULL,
	[SistemaCardiovascular] [nvarchar](max) NULL,
	[SistemaRespiratorio] [nvarchar](max) NULL,
	[Abdomen] [nvarchar](max) NULL,
	[SistemaNervioso] [nvarchar](max) NULL,
	[Otros] [nvarchar](max) NULL,
 CONSTRAINT [PK_ExamenesFisicos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Farmacos]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Farmacos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
 CONSTRAINT [PK__Farmacos__3214EC274A8AA0C5] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FarmacosContraindicaciones]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FarmacosContraindicaciones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Farmaco] [int] NULL,
	[ID_Contraindicacion] [int] NULL,
 CONSTRAINT [PK__Farmacos__3214EC279942C159] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FarmacosEfectosAdversos]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FarmacosEfectosAdversos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Farmaco] [int] NULL,
	[ID_EfectoAdverso] [int] NULL,
 CONSTRAINT [PK__Farmacos__3214EC2765E81F69] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoriasClinicas]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoriasClinicas](
	[ID_Consulta] [int] NULL,
	[DNI] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicos](
	[DNI] [nvarchar](100) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Contraseña] [nvarchar](100) NULL,
	[Matricula] [nchar](10) NULL,
 CONSTRAINT [PK_Medicos] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicosPacientes]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicosPacientes](
	[DNI_Medico] [nvarchar](100) NULL,
	[DNI_Paciente] [nvarchar](100) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_MedicosPacientes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[DNI] [nvarchar](100) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[FechaNacimiento] [date] NULL,
	[Profesion] [nvarchar](50) NULL,
	[Direccion] [nvarchar](255) NULL,
	[PlanObraSocial] [nvarchar](100) NULL,
	[NumeroSocio] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_Pacientes_1] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posologia]    Script Date: 15/02/2024 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posologia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Farmaco] [int] NULL,
	[ID_Enfermedad] [int] NULL,
	[Dosis] [nvarchar](100) NULL,
 CONSTRAINT [PK__Posologi__3214EC27CCA90B07] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contraindicaciones] ON 

INSERT [dbo].[Contraindicaciones] ([ID], [Nombre]) VALUES (1, N'Hipersensibilidad')
INSERT [dbo].[Contraindicaciones] ([ID], [Nombre]) VALUES (2, N'Embarazo y Lactancia')
INSERT [dbo].[Contraindicaciones] ([ID], [Nombre]) VALUES (3, N'Enfermedad neurologica severa')
INSERT [dbo].[Contraindicaciones] ([ID], [Nombre]) VALUES (4, N'Enfermedad hepatica severa')
INSERT [dbo].[Contraindicaciones] ([ID], [Nombre]) VALUES (5, N'Enfermedad renal severa')
INSERT [dbo].[Contraindicaciones] ([ID], [Nombre]) VALUES (6, N'Porfiria')
INSERT [dbo].[Contraindicaciones] ([ID], [Nombre]) VALUES (7, N'Hiperuricemia')
INSERT [dbo].[Contraindicaciones] ([ID], [Nombre]) VALUES (8, N'Neuritis Optica')
INSERT [dbo].[Contraindicaciones] ([ID], [Nombre]) VALUES (9, N'Deterioro auditivo')
INSERT [dbo].[Contraindicaciones] ([ID], [Nombre]) VALUES (10, N'Miastenia Gravis')
INSERT [dbo].[Contraindicaciones] ([ID], [Nombre]) VALUES (11, N'Menores de 8 años')
SET IDENTITY_INSERT [dbo].[Contraindicaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[EfectosAdversos] ON 

INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (1, N'Anafilaxia')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (2, N'Dermatopatia Alergica')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (3, N'Nausea, diarrea o vomitos')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (4, N'Nefrotoxicidad')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (5, N'Irritacion local')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (6, N'Granulocitopenia')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (7, N'Hemorragias')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (8, N'Rash cutaneo')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (9, N'Candidiasis')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (10, N'Diarrea por C Difficile')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (11, N'Rash Ampicilinico')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (12, N'Sindrome del Hombre Rojo')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (13, N'Ototoxicidad')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (14, N'Sme. Stevens-Johnson')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (15, N'Flebitis')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (16, N'Leucopenia')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (17, N'Parestesias')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (18, N'Neuritis periferica')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (19, N'Cefalea')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (20, N'Vertigo')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (21, N'Fiebre')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (22, N'Ictericia')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (23, N'Mialgia')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (24, N'Artralgia')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (25, N'Convulsiones')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (26, N'Hepatotoxicidad')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (27, N'Sindrome Pseudogripal')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (28, N'Anemia Hemolitica')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (29, N'Trombocitopenia')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (30, N'Hiperuricemia')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (31, N'Neuritis Optica')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (32, N'Bloqueo Neuromuscular')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (33, N'Sme Malabsorcion')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (34, N'Embriotoxicidad')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (35, N'Alopecia')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (36, N'Mielotoxicidad')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (37, N'Hipoplasia del esmalte dental')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (38, N'Hipertension endocraneana benigna')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (39, N'Fotosensibilidad')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (40, N'Insomnio')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (41, N'Aumento de peso')
INSERT [dbo].[EfectosAdversos] ([ID], [Nombre]) VALUES (42, N'Hipertension Arterial')
SET IDENTITY_INSERT [dbo].[EfectosAdversos] OFF
GO
SET IDENTITY_INSERT [dbo].[Enfermedades] ON 

INSERT [dbo].[Enfermedades] ([ID], [Nombre], [Esquema]) VALUES (1, N'Meningitis Bacteriana Aguda < 50 años', N'Ceftriaxona o cefotaxima + Vancomicina                                                                                                                                                                  ')
INSERT [dbo].[Enfermedades] ([ID], [Nombre], [Esquema]) VALUES (2, N'Enfermedad de Chagas', N'Benznidazol o Nifurtimox                                                                                                                                                                                ')
INSERT [dbo].[Enfermedades] ([ID], [Nombre], [Esquema]) VALUES (3, N'Tuberculosis', N'Esquema 2HRZE / 4HR                                                                                                                                                                                     ')
INSERT [dbo].[Enfermedades] ([ID], [Nombre], [Esquema]) VALUES (4, N'Triquinosis', N'Mebendazol o albendazol                                                                                                                                                                                 ')
INSERT [dbo].[Enfermedades] ([ID], [Nombre], [Esquema]) VALUES (5, N'Brucelosis', N'Estreptomicina + Doxociclina                                                                                                                                                                            ')
INSERT [dbo].[Enfermedades] ([ID], [Nombre], [Esquema]) VALUES (11, N'Meningitis Bacteriana Aguda > 50 años, Inmunodep', N'Ceftriaxona o cefotaxima + Vancomicina + Ampicilina                                                                                                                                                     ')
SET IDENTITY_INSERT [dbo].[Enfermedades] OFF
GO
SET IDENTITY_INSERT [dbo].[Farmacos] ON 

INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (1, N'Ceftriaxona')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (2, N'Cefotaxima')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (3, N'Vancomicina')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (4, N'Ampicilina')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (5, N'Dexametasona')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (6, N'Benznidazol')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (7, N'Nifurtimox')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (8, N'Isoniazida')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (9, N'Rifampicina')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (10, N'Pirazinamida')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (11, N'Etambutol')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (12, N'Estreptomicina')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (13, N'Mebendazol')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (14, N'Albendazol')
INSERT [dbo].[Farmacos] ([ID], [Nombre]) VALUES (16, N'Doxiciclina')
SET IDENTITY_INSERT [dbo].[Farmacos] OFF
GO
SET IDENTITY_INSERT [dbo].[FarmacosContraindicaciones] ON 

INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (2, 1, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (3, 2, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (4, 4, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (5, 3, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (6, 3, 2)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (7, 5, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (8, 6, 2)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (9, 6, 3)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (10, 6, 4)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (11, 6, 5)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (12, 7, 2)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (13, 7, 3)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (14, 7, 4)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (15, 7, 5)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (16, 8, 4)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (17, 8, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (18, 9, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (19, 9, 4)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (20, 10, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (21, 10, 4)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (22, 10, 6)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (23, 10, 7)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (24, 11, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (25, 11, 8)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (26, 12, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (27, 12, 2)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (28, 12, 9)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (29, 12, 10)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (30, 13, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (31, 13, 2)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (32, 14, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (33, 14, 2)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (34, 16, 1)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (35, 16, 2)
INSERT [dbo].[FarmacosContraindicaciones] ([ID], [ID_Farmaco], [ID_Contraindicacion]) VALUES (36, 16, 11)
SET IDENTITY_INSERT [dbo].[FarmacosContraindicaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[FarmacosEfectosAdversos] ON 

INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (1, 1, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (2, 1, 2)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (3, 1, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (4, 1, 4)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (5, 1, 5)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (6, 1, 6)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (7, 1, 7)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (8, 1, 8)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (9, 1, 9)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (10, 2, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (11, 2, 2)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (12, 2, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (13, 2, 4)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (14, 2, 5)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (15, 2, 6)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (16, 2, 7)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (17, 2, 8)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (18, 2, 9)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (19, 4, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (20, 4, 2)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (21, 4, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (22, 4, 4)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (23, 4, 5)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (24, 4, 6)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (25, 4, 7)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (26, 4, 8)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (27, 4, 9)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (28, 4, 10)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (29, 4, 11)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (30, 3, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (31, 3, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (32, 3, 4)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (33, 3, 12)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (34, 3, 13)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (35, 3, 14)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (36, 3, 15)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (37, 6, 2)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (38, 6, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (39, 6, 16)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (40, 6, 7)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (41, 6, 17)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (42, 6, 18)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (43, 6, 19)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (44, 6, 20)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (45, 7, 2)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (46, 7, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (47, 7, 18)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (48, 7, 19)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (49, 7, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (50, 7, 21)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (51, 7, 22)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (52, 7, 23)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (53, 7, 24)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (54, 8, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (55, 8, 18)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (56, 8, 17)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (57, 8, 25)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (58, 8, 26)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (59, 9, 26)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (60, 9, 27)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (61, 9, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (62, 9, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (63, 9, 28)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (64, 9, 29)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (65, 10, 26)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (66, 10, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (67, 10, 30)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (68, 10, 24)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (69, 11, 31)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (70, 11, 30)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (71, 11, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (72, 11, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (73, 12, 4)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (74, 12, 13)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (75, 12, 32)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (76, 12, 33)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (77, 12, 34)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (78, 12, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (79, 12, 2)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (80, 13, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (81, 13, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (82, 13, 35)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (83, 13, 26)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (84, 13, 36)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (85, 14, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (86, 14, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (87, 14, 35)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (88, 14, 26)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (89, 14, 36)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (90, 16, 1)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (91, 16, 2)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (92, 16, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (93, 16, 26)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (94, 16, 4)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (95, 16, 20)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (96, 16, 34)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (97, 16, 15)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (98, 16, 37)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (99, 16, 38)
GO
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (100, 16, 39)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (101, 5, 3)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (102, 5, 40)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (103, 5, 41)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (104, 5, 19)
INSERT [dbo].[FarmacosEfectosAdversos] ([ID], [ID_Farmaco], [ID_EfectoAdverso]) VALUES (105, 5, 42)
SET IDENTITY_INSERT [dbo].[FarmacosEfectosAdversos] OFF
GO
SET IDENTITY_INSERT [dbo].[Posologia] ON 

INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (1, 1, 1, N'2 gr cada 12 hs EV')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (2, 2, 1, N'2 gr cada 14 hs EV')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (3, 3, 1, N'15-20 mg/kg cada 8-12 hs EV')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (4, 4, 11, N' 2 gr cada 4 hs EV')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (5, 5, 1, N'10 mg 15-20 min antes del ATB')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (6, 6, 2, N'5-7 mg/kg/dia (Administrado en dos tomas diarias)')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (7, 7, 2, N'8-10 mg/kg/dia (Administrado en tres tomas diarias)')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (8, 8, 3, N'5 mg/kg/dia (Max 300 mg/dia)')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (9, 9, 3, N'10 mg/kg/dia (Max 600 mg/dia)')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (10, 10, 3, N'25-30 mg/kg/dia (Max 2 gr/dia)')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (11, 11, 3, N'15-20 mg/kg/dia')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (12, 12, 3, N'15 mg/kg/dia (Max 1 gr/dia)')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (13, 13, 4, N'5 mg/kg/dia (Administrado en dos tomas diarias) durante 10 a 15 dias')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (14, 14, 4, N'15 mg/kg/dia (Administrado en dos tomas diarias) durante 10 a 15 dias')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (15, 12, 5, N'1 gr cada 24 hs por 2 a 3 semanas')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (16, 16, 5, N'100 mg cada 12 hs por 6 semanas')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (17, 1, 11, N'2 gr cada 12 hs EV')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (18, 2, 11, N'2 gr cada 14 hs EV')
INSERT [dbo].[Posologia] ([ID], [ID_Farmaco], [ID_Enfermedad], [Dosis]) VALUES (19, 3, 11, N'15-20 mg/kg cada 8-12 hs EV')
SET IDENTITY_INSERT [dbo].[Posologia] OFF
GO
ALTER TABLE [dbo].[Consultas]  WITH CHECK ADD  CONSTRAINT [FK_Consultas_ExamenesFisicos] FOREIGN KEY([ID_ExamenFisico])
REFERENCES [dbo].[ExamenesFisicos] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Consultas] CHECK CONSTRAINT [FK_Consultas_ExamenesFisicos]
GO
ALTER TABLE [dbo].[FarmacosContraindicaciones]  WITH CHECK ADD  CONSTRAINT [FK__FarmacosC__ID_Co__47A6A41B] FOREIGN KEY([ID_Contraindicacion])
REFERENCES [dbo].[Contraindicaciones] ([ID])
GO
ALTER TABLE [dbo].[FarmacosContraindicaciones] CHECK CONSTRAINT [FK__FarmacosC__ID_Co__47A6A41B]
GO
ALTER TABLE [dbo].[FarmacosContraindicaciones]  WITH CHECK ADD  CONSTRAINT [FK__FarmacosC__ID_Fa__46B27FE2] FOREIGN KEY([ID_Farmaco])
REFERENCES [dbo].[Farmacos] ([ID])
GO
ALTER TABLE [dbo].[FarmacosContraindicaciones] CHECK CONSTRAINT [FK__FarmacosC__ID_Fa__46B27FE2]
GO
ALTER TABLE [dbo].[FarmacosEfectosAdversos]  WITH CHECK ADD  CONSTRAINT [FK__FarmacosE__ID_Ef__43D61337] FOREIGN KEY([ID_EfectoAdverso])
REFERENCES [dbo].[EfectosAdversos] ([ID])
GO
ALTER TABLE [dbo].[FarmacosEfectosAdversos] CHECK CONSTRAINT [FK__FarmacosE__ID_Ef__43D61337]
GO
ALTER TABLE [dbo].[FarmacosEfectosAdversos]  WITH CHECK ADD  CONSTRAINT [FK__FarmacosE__ID_Fa__42E1EEFE] FOREIGN KEY([ID_Farmaco])
REFERENCES [dbo].[Farmacos] ([ID])
GO
ALTER TABLE [dbo].[FarmacosEfectosAdversos] CHECK CONSTRAINT [FK__FarmacosE__ID_Fa__42E1EEFE]
GO
ALTER TABLE [dbo].[HistoriasClinicas]  WITH NOCHECK ADD  CONSTRAINT [FK_HistoriasClinicas_Consultas1] FOREIGN KEY([ID_Consulta])
REFERENCES [dbo].[Consultas] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HistoriasClinicas] NOCHECK CONSTRAINT [FK_HistoriasClinicas_Consultas1]
GO
ALTER TABLE [dbo].[HistoriasClinicas]  WITH NOCHECK ADD  CONSTRAINT [FK_HistoriasClinicas_Pacientes] FOREIGN KEY([DNI])
REFERENCES [dbo].[Pacientes] ([DNI])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HistoriasClinicas] NOCHECK CONSTRAINT [FK_HistoriasClinicas_Pacientes]
GO
ALTER TABLE [dbo].[MedicosPacientes]  WITH CHECK ADD  CONSTRAINT [FK_MedicosPacientes_Medicos] FOREIGN KEY([DNI_Medico])
REFERENCES [dbo].[Medicos] ([DNI])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MedicosPacientes] CHECK CONSTRAINT [FK_MedicosPacientes_Medicos]
GO
ALTER TABLE [dbo].[MedicosPacientes]  WITH NOCHECK ADD  CONSTRAINT [FK_MedicosPacientes_Pacientes] FOREIGN KEY([DNI_Paciente])
REFERENCES [dbo].[Pacientes] ([DNI])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MedicosPacientes] NOCHECK CONSTRAINT [FK_MedicosPacientes_Pacientes]
GO
ALTER TABLE [dbo].[Posologia]  WITH CHECK ADD  CONSTRAINT [FK__Posologia__ID_Fa__5BAD9CC8] FOREIGN KEY([ID_Farmaco])
REFERENCES [dbo].[Farmacos] ([ID])
GO
ALTER TABLE [dbo].[Posologia] CHECK CONSTRAINT [FK__Posologia__ID_Fa__5BAD9CC8]
GO
ALTER TABLE [dbo].[Posologia]  WITH CHECK ADD  CONSTRAINT [FK_Posologia_Enfermedades] FOREIGN KEY([ID_Enfermedad])
REFERENCES [dbo].[Enfermedades] ([ID])
GO
ALTER TABLE [dbo].[Posologia] CHECK CONSTRAINT [FK_Posologia_Enfermedades]
GO
USE [master]
GO
ALTER DATABASE [TestMEDICO] SET  READ_WRITE 
GO
