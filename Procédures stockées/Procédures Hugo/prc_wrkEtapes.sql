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
-- Author:		Hugo Poquet
-- Create date: <Create Date,,>
-- Description:	Cette procédure retourne les étapes d'un médicament entré
-- =============================================
ALTER PROCEDURE prc_wrkEtapes (@medDepotLegal as varchar(5000))
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
