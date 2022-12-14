USE [GSB_gesAMM]
GO
/****** Object:  StoredProcedure [dbo].[prc_med_famille]    Script Date: 06/01/2023 17:22:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[prc_med_famille]
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
