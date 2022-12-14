USE [GSB_gesAMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_etape_suivante]    Script Date: 06/01/2023 01:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure retourne l'étape suivante à une étape entrée ainsi que sa norme si elle existe
-- =============================================
ALTER PROCEDURE [dbo].[prc_etape_suivante](@numEtape as int)
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
