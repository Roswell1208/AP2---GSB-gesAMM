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
ALTER PROCEDURE prc_workflow_med (@medDepotLegal as varchar(500))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	declare @lastDecision as int
	
	select @lastDecision = WRK_DCS_ID from WORKFLOW where WRK_MED_DEPOT = @medDepotLegal

	if (@lastDecision = 2)
	begin
		print('Erreur, la dernière étape a été refusée pour ce médicament')
		return
	end

	select WRK_ETP_NUM, ETP_LIBELLE, WRK_DATE,
	DCS_LIBELLE, NORME, NORME_DATE
	from WORKFLOW W
	inner join ETAPE E on E.ETP_NUM = W.WRK_ETP_NUM
	inner join DECISION D on D.DCS_ID = W.WRK_DCS_ID
	inner join ETAPE_NORME N on N.ETAPE_ETP_NUM = W.WRK_ETP_NUM
	where WRK_MED_DEPOT = @medDepotLegal

END
GO
