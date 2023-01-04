USE [GSB_gesAMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_workflow_med]    Script Date: 04/01/2023 23:49:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[prc_workflow_med] (@medDepotLegal as varchar(500))
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
