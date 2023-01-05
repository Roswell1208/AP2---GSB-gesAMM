-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE prc_etape_suivante(@numEtape as int)
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
