USE [master]
GO
/****** Object:  Database [GSB_gesAMM]    Script Date: 08/01/2023 19:28:55 ******/
CREATE DATABASE [GSB_gesAMM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GSB_gesAMM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\GSB_gesAMM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GSB_gesAMM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\GSB_gesAMM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GSB_gesAMM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GSB_gesAMM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ARITHABORT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GSB_gesAMM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GSB_gesAMM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GSB_gesAMM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GSB_gesAMM] SET  MULTI_USER 
GO
ALTER DATABASE [GSB_gesAMM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GSB_gesAMM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GSB_gesAMM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GSB_gesAMM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GSB_gesAMM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GSB_gesAMM] SET QUERY_STORE = OFF
GO
USE [GSB_gesAMM]
GO
/****** Object:  Table [dbo].[DECISION]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DECISION](
	[DCS_ID] [int] IDENTITY(1,1) NOT NULL,
	[DCS_LIBELLE] [varchar](50) NOT NULL,
 CONSTRAINT [PK1] PRIMARY KEY CLUSTERED 
(
	[DCS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ETAPE]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ETAPE](
	[ETP_NUM] [int] IDENTITY(1,1) NOT NULL,
	[ETP_LIBELLE] [varchar](500) NOT NULL,
 CONSTRAINT [PK4] PRIMARY KEY CLUSTERED 
(
	[ETP_NUM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ETAPE_NORME]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ETAPE_NORME](
	[NORME] [varchar](500) NULL,
	[NORME_DATE] [date] NULL,
	[ETAPE_ETP_NUM] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FAMILLE]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FAMILLE](
	[FAM_CODE] [varchar](50) NOT NULL,
	[FAM_LIBELLE] [varchar](500) NULL,
	[FAM_NB_MEDI_AMM] [varchar](500) NULL,
 CONSTRAINT [PK2] PRIMARY KEY CLUSTERED 
(
	[FAM_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HISTORIQUE]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORIQUE](
	[HIST_ID] [int] IDENTITY(1,1) NOT NULL,
	[HIST_USR] [varchar](50) NOT NULL,
	[HIST_ETP_AV] [int] NOT NULL,
	[HIST_ETP_AP] [int] NOT NULL,
	[HIST_DATE_AV] [date] NOT NULL,
	[HIST_DATE_AP] [date] NOT NULL,
	[HIST_DATE_MAJ] [date] NOT NULL,
	[HIST_MED_DEPOT] [varchar](5000) NULL,
	[HIST_ETP_NUM] [int] NOT NULL,
 CONSTRAINT [PK6] PRIMARY KEY CLUSTERED 
(
	[HIST_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICAMENT]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICAMENT](
	[MED_DEPOTLEGAL] [varchar](5000) NOT NULL,
	[MED_NOMCOMMERCIAL] [varchar](5000) NULL,
	[FAM_MED_CODE] [varchar](5000) NULL,
	[MED_COMPOSITION] [varchar](5000) NULL,
	[MED_EFFETS] [varchar](5000) NULL,
	[MED_CONTREINDIC] [varchar](5000) NULL,
	[MED_PRIXECHANTILLON] [varchar](5000) NULL,
 CONSTRAINT [PK3] PRIMARY KEY CLUSTERED 
(
	[MED_DEPOTLEGAL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USER]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER](
	[identifiant] [varchar](100) NOT NULL,
	[motDePasse] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WORKFLOW]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WORKFLOW](
	[WRK_MED_DEPOT] [varchar](5000) NOT NULL,
	[WRK_ETP_NUM] [int] NOT NULL,
	[WRK_DCS_ID] [int] NOT NULL,
	[WRK_DATE] [datetime] NOT NULL,
 CONSTRAINT [PK5] PRIMARY KEY CLUSTERED 
(
	[WRK_MED_DEPOT] ASC,
	[WRK_ETP_NUM] ASC,
	[WRK_DATE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ETAPE_NORME]  WITH CHECK ADD  CONSTRAINT [FK1] FOREIGN KEY([ETAPE_ETP_NUM])
REFERENCES [dbo].[ETAPE] ([ETP_NUM])
GO
ALTER TABLE [dbo].[ETAPE_NORME] CHECK CONSTRAINT [FK1]
GO
ALTER TABLE [dbo].[HISTORIQUE]  WITH CHECK ADD  CONSTRAINT [FK6] FOREIGN KEY([HIST_MED_DEPOT])
REFERENCES [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL])
GO
ALTER TABLE [dbo].[HISTORIQUE] CHECK CONSTRAINT [FK6]
GO
ALTER TABLE [dbo].[WORKFLOW]  WITH CHECK ADD  CONSTRAINT [FK2] FOREIGN KEY([WRK_MED_DEPOT])
REFERENCES [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL])
GO
ALTER TABLE [dbo].[WORKFLOW] CHECK CONSTRAINT [FK2]
GO
ALTER TABLE [dbo].[WORKFLOW]  WITH CHECK ADD  CONSTRAINT [FK3] FOREIGN KEY([WRK_ETP_NUM])
REFERENCES [dbo].[ETAPE] ([ETP_NUM])
GO
ALTER TABLE [dbo].[WORKFLOW] CHECK CONSTRAINT [FK3]
GO
ALTER TABLE [dbo].[WORKFLOW]  WITH CHECK ADD  CONSTRAINT [FK4] FOREIGN KEY([WRK_DCS_ID])
REFERENCES [dbo].[DECISION] ([DCS_ID])
GO
ALTER TABLE [dbo].[WORKFLOW] CHECK CONSTRAINT [FK4]
GO
/****** Object:  StoredProcedure [dbo].[prc_ajout_historique]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_ajout_historique]

	@HIST_USR varchar(50),
	@norme_av varchar(500),
	@norme_ap varchar(500),
	@ancienneDate DATE,
	@HIST_DATE_AP DATE,
	@HIST_DATE_MAJ DATE,
	@HIST_ETP_NUM int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO HISTORIQUE (HIST_USR, HIST_ETP_AV, HIST_ETP_AP, HIST_DATE_AV, HIST_DATE_AP, HIST_DATE_MAJ, HIST_ETP_NUM)
	VALUES (@HIST_USR, @norme_av, @norme_ap, @ancienneDate, @HIST_DATE_AP, @HIST_DATE_MAJ, @HIST_ETP_NUM)
END
GO
/****** Object:  StoredProcedure [dbo].[prc_ajoutNewMed]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure ajoute un nouveau médicament dont les informations sont saisies par l'utilisateur.
--				Elle vérifie aussi le dépot légal avant insertion.
-- =============================================
CREATE PROCEDURE [dbo].[prc_ajoutNewMed] (@medDepotLegal as varchar(5000), @nomCommercial as varchar(5000),
	@famCode as varchar(5000), @composition as varchar(5000), @effets as varchar(5000),
	@contreIndic as varchar(5000), @prixEchant as varchar(5000))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    if exists(select * from MEDICAMENT where MED_DEPOTLEGAL = @medDepotLegal)
	begin
		print ('Erreur, un médicament avec ce dépot légal existe déjà.')
		return
	end

	else
	begin
		insert into MEDICAMENT
		values (@medDepotLegal, @nomCommercial, @famCode, @composition, @effets, @contreIndic, @prixEchant)

		print ('Ajout effectué avec succès.')
		return
	end
END
GO
/****** Object:  StoredProcedure [dbo].[prc_etape_suivante]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure retourne l'étape suivante à une étape entrée ainsi que sa norme si elle existe
-- =============================================
CREATE PROCEDURE [dbo].[prc_etape_suivante](@numEtape as int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	declare @numEtapeSuivante as int;
	set @numEtapeSuivante = @numEtape + 1


	if exists(select * from ETAPE E inner join ETAPE_NORME N on E.ETP_NUM = N.ETAPE_ETP_NUM where ETP_NUM = @numEtapeSuivante)
	begin
		select ETP_NUM, ETP_LIBELLE, NORME, NORME_DATE
		from ETAPE E
		inner join ETAPE_NORME N on E.ETP_NUM = N.ETAPE_ETP_NUM
		where ETP_NUM = @numEtapeSuivante
	end

	else
	begin
		select ETP_NUM, ETP_LIBELLE, NORME=null, NORME_DATE='01/01/0001'
		from ETAPE E
		where ETP_NUM = @numEtapeSuivante
	end
END
GO
/****** Object:  StoredProcedure [dbo].[prc_etapeNormees]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_etapeNormees]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT NORME, NORME_DATE, ETAPE_ETP_NUM
	FROM ETAPE_NORME
	ORDER BY NORME


END
GO
/****** Object:  StoredProcedure [dbo].[prc_listeTousUser]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure retourne la liste des identifiants et des mots de passe de la table USER
-- =============================================
CREATE PROCEDURE [dbo].[prc_listeTousUser]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT identifiant, motDePasse FROM [USER]
END
GO
/****** Object:  StoredProcedure [dbo].[prc_med_encours]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_med_encours]

AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    SELECT DISTINCT FAM_CODE, MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, FAM_LIBELLE
    FROM MEDICAMENT
    INNER JOIN FAMILLE ON FAM_CODE = FAM_MED_CODE
    INNER JOIN WORKFLOW ON WRK_MED_DEPOT = MED_DEPOTLEGAL
    INNER JOIN ETAPE ON WRK_ETP_NUM = ETP_NUM
    WHERE ETP_NUM != 8
END
GO
/****** Object:  StoredProcedure [dbo].[prc_med_famille]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_med_famille]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT FAM_CODE, FAM_LIBELLE, COUNT(*) As NbMedicaments
	FROM MEDICAMENT
	INNER JOIN FAMILLE ON FAM_CODE = FAM_MED_CODE
	INNER JOIN WORKFLOW ON WRK_MED_DEPOT = MED_DEPOTLEGAL
	INNER JOIN DECISION ON WRK_DCS_ID = DCS_ID
	WHERE DCS_ID = 1
	GROUP BY FAM_CODE, FAM_LIBELLE
	ORDER BY FAM_CODE


END
GO
/****** Object:  StoredProcedure [dbo].[prc_med_selectionne]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_med_selectionne]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, FAM_MED_CODE, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, MED_PRIXECHANTILLON
	FROM MEDICAMENT
	INNER JOIN FAMILLE ON FAM_CODE = FAM_MED_CODE
	ORDER BY MED_DEPOTLEGAL


END
GO
/****** Object:  StoredProcedure [dbo].[prc_saisieDecision]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure met à jour la table WORKFLOW et FAMILLE après saisie de la décision d'une étape par l'utilisateur
-- =============================================
CREATE PROCEDURE [dbo].[prc_saisieDecision](@medDepotLegal as varchar(5000), @numEtape as int, @idDecision as int, @dateDecision as DateTime)
AS
BEGIN
	SET NOCOUNT ON;

	declare @nbMedFam as int
	declare @nbMedFamMax as int

    if(@numEtape = 8)
	begin
		select @nbMedFam = count(*)
		from WORKFLOW W
		inner join MEDICAMENT M on M.MED_DEPOTLEGAL = W.WRK_MED_DEPOT
		where WRK_ETP_NUM = 8
		and FAM_MED_CODE in (select FAM_CODE from FAMILLE F inner join MEDICAMENT M on M.FAM_MED_CODE = F.FAM_CODE where MED_DEPOTLEGAL = @medDepotLegal)
		
		select @nbMedFamMax = FAM_NB_MEDI_AMM from FAMILLE F inner join MEDICAMENT M on M.FAM_MED_CODE = F.FAM_CODE where MED_DEPOTLEGAL = @medDepotLegal

		/* Si on ne dépasse pas le nombre de médicament max par famille */
		if((@nbMedFam + 1) <= @nbMedFamMax and @idDecision = 1)
		begin
			/* On insert dans la table Workflow */
			insert into WORKFLOW
			values(@medDepotLegal, @numEtape, @idDecision, @dateDecision)

			print 'Etape mise à jour avec succès'
		end


		else
		begin
			print 'Erreur, le nombre de médicament par famille est dépassé'
		end
	end

	else
	begin
		/* On insert dans la table Workflow */
		insert into WORKFLOW
		values(@medDepotLegal, @numEtape, @idDecision, @dateDecision)

		print 'Etape mise à jour avec succès'
	end
END
GO
/****** Object:  StoredProcedure [dbo].[prc_update_etpnorme]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_update_etpnorme]

	@norme varchar(500),
	@norme_date date,
	@etp_num int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE ETAPE_NORME
	SET NORME = @norme, NORME_DATE = @norme_date
	WHERE @etp_num = ETAPE_ETP_NUM

END
GO
/****** Object:  StoredProcedure [dbo].[prc_work_selection_med]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_work_selection_med]
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT WRK_MED_DEPOT, WRK_ETP_NUM,  WRK_DCS_ID, WRK_DATE
    FROM WORKFLOW
    INNER JOIN MEDICAMENT ON MED_DEPOTLEGAL = WRK_MED_DEPOT
    ORDER BY WRK_MED_DEPOT
END 
GO
/****** Object:  StoredProcedure [dbo].[prc_workflow_dern_etape]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure retourne les informations du workflow d'un médicament donné
-- =============================================
CREATE PROCEDURE [dbo].[prc_workflow_dern_etape] (@medDepotLegal as varchar(500))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if exists(select * from ETAPE_NORME N INNER JOIN ETAPE E ON E.ETP_NUM = N.ETAPE_ETP_NUM INNER JOIN WORKFLOW W ON W.WRK_ETP_NUM = E.ETP_NUM where WRK_MED_DEPOT = @medDepotLegal)
	begin
		select WRK_ETP_NUM, ETP_LIBELLE, WRK_DATE, DCS_LIBELLE, NORME, NORME_DATE
		from WORKFLOW W
		inner join ETAPE E on E.ETP_NUM = W.WRK_ETP_NUM
		inner join ETAPE_NORME N on E.ETP_NUM = N.ETAPE_ETP_NUM
		inner join DECISION D on D.DCS_ID = W.WRK_DCS_ID
		where WRK_MED_DEPOT = @medDepotLegal
	end

	else
	begin
		select WRK_ETP_NUM, ETP_LIBELLE, WRK_DATE, DCS_LIBELLE, NORME=null, NORME_DATE='01/01/0001'
		from WORKFLOW W
		inner join ETAPE E on E.ETP_NUM = W.WRK_ETP_NUM
		inner join DECISION D on D.DCS_ID = W.WRK_DCS_ID
		where WRK_MED_DEPOT = @medDepotLegal
	end

END
GO
/****** Object:  StoredProcedure [dbo].[prc_workflow_med]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure retourne les informations du workflow d'un médicament donné si sa dernière étape a été acceptée
-- =============================================
CREATE PROCEDURE [dbo].[prc_workflow_med] (@medDepotLegal as varchar(5000))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	declare @numLastEtape as int
	declare @lastDecision as int

	select @numLastEtape = WRK_ETP_NUM
	from WORKFLOW
	where WRK_MED_DEPOT = @medDepotLegal
	and WRK_ETP_NUM in (select MAX(WRK_ETP_NUM) from WORKFLOW where WRK_MED_DEPOT = @medDepotLegal)
	
	select @lastDecision = WRK_DCS_ID from WORKFLOW where WRK_MED_DEPOT = @medDepotLegal and WRK_ETP_NUM = @numLastEtape

	if (@lastDecision = 2)
	begin
		print('Erreur, la dernière étape a été refusée pour ce médicament')
		return
	end

	if exists(select * from ETAPE_NORME N INNER JOIN ETAPE E ON E.ETP_NUM = N.ETAPE_ETP_NUM INNER JOIN WORKFLOW W ON W.WRK_ETP_NUM = E.ETP_NUM where WRK_MED_DEPOT = @medDepotLegal and WRK_ETP_NUM = @numLastEtape)
	begin
		select WRK_ETP_NUM, ETP_LIBELLE, WRK_DATE, DCS_LIBELLE, NORME, NORME_DATE
		from WORKFLOW W
		inner join ETAPE E on E.ETP_NUM = W.WRK_ETP_NUM
		inner join ETAPE_NORME N on E.ETP_NUM = N.ETAPE_ETP_NUM
		inner join DECISION D on D.DCS_ID = W.WRK_DCS_ID
		where WRK_MED_DEPOT = @medDepotLegal
		and WRK_ETP_NUM = @numLastEtape
	end

	else
	begin
		select WRK_ETP_NUM, ETP_LIBELLE, WRK_DATE, DCS_LIBELLE, NORME=null, NORME_DATE='01/01/0001'
		from WORKFLOW W
		inner join ETAPE E on E.ETP_NUM = W.WRK_ETP_NUM
		inner join DECISION D on D.DCS_ID = W.WRK_DCS_ID
		where WRK_MED_DEPOT = @medDepotLegal
		and WRK_ETP_NUM = @numLastEtape
	end

END
GO
/****** Object:  StoredProcedure [dbo].[prc_wrkEtapes]    Script Date: 08/01/2023 19:28:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure retourne les étapes d'un médicament entré
-- =============================================
CREATE PROCEDURE [dbo].[prc_wrkEtapes] (@medDepotLegal as varchar(5000))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select ETP_NUM, ETP_LIBELLE, WRK_DATE, DCS_LIBELLE, NORME, NORME_DATE
	from ETAPE E
	left join ETAPE_NORME N on E.ETP_NUM = N.ETAPE_ETP_NUM
	inner join WORKFLOW W on E.ETP_NUM = W.WRK_ETP_NUM
	inner join DECISION D on W.WRK_DCS_ID = D.DCS_ID
	where WRK_MED_DEPOT = @medDepotLegal
END
GO
USE [master]
GO
ALTER DATABASE [GSB_gesAMM] SET  READ_WRITE 
GO
