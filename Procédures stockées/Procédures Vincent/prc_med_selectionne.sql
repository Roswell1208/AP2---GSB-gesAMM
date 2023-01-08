USE [GSB_gesAMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_med_selectionne]    Script Date: 06/01/2023 17:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[prc_med_selectionne]

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
